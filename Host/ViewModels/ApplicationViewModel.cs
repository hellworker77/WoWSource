using AutoMapper;
using Dai.Entities.Implementation;
using Hellworker.Wow.Core.Domain.Models;
using Hellworker.Wow.DataAccess.Abstractions;
using Hellworker.Wow.Host.Abstraction;
using Host.Models;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;

namespace Host.ViewModels;

public class ApplicationViewModel : INotifyPropertyChanged
{
    public ObservableCollection<PlayerDto> Players { get; set; }
    public ObservableCollection<WayPointDto> WayPoints { get; set; }

    private readonly Func<string, AbstractRequest> _requestFactory;

    private readonly Func<string, AbstractEquipCommand> _commandFactory;


    private readonly IPlayersRepository _playersRepository;
    private readonly IWayPointsRepository _wayPointsRepository;

    public ApplicationViewModel(Func<string, AbstractRequest> requestFactory,
        Func<string, AbstractEquipCommand> commandFactory, 
        IPlayersRepository playersRepository,
        IWayPointsRepository wayPointsRepository)
    {
        _requestFactory = requestFactory;
        _commandFactory = commandFactory;
        _playersRepository = playersRepository;
        _wayPointsRepository = wayPointsRepository;
    }
    public void StartUp()
    {
        Players = new ObservableCollection<PlayerDto>(_playersRepository.GetAll());
        WayPoints = new ObservableCollection<WayPointDto>(_wayPointsRepository.GetAll());

        SelectedWayPoint = WayPoints.First();
        SelectedLairEnemy = SelectedWayPoint.Location.Enemies.First();
    }

    public PlayerDto SelectedPlayer
    {
        get => _selectedPlayer;
        set
        {
            _selectedPlayer = value;
            _selectedPlayer.Update();
            OnPropertyChanged("SelectedPlayer");
        }
    }

    public WayPointDto SelectedWayPoint
    {
        get => _selectedWayPoint;
        set
        {
            _selectedWayPoint = value;
            SelectedLairEnemy = SelectedWayPoint.Location.Enemies.First(x => !x.IsDeath);
            OnPropertyChanged("SelectedWayPoint");
            GetAway();
        }
    }

    public EnemyDto SelectedLairEnemy
    {
        get => _selectedLairEnemy;
        set
        {
            _selectedLairEnemy = value;
            OnPropertyChanged("SelectedLairEnemy");
        }
    }

    public Command SendRequestCommand
    {
        get
        {
            return _sendRequestCommand ??
                   (_sendRequestCommand = new Command(obj =>
                   {
                       var requestName = obj as string;
                       var request = _requestFactory(requestName);
                       request.RunRequst();
                   }));
        }
    }


    public Command EquipCommand
    {
        get
        {
            return _equipCommand ??
                   (_equipCommand = new Command(obj =>
                   {
                       var selectedItemType = SelectedPlayer?.Bag?.SelectedItem.Type;
                       if (selectedItemType == ItemType.None)
                       {
                           return;
                       }

                       var commandName = string.Empty;
                       if (selectedItemType == ItemType.RingLeft || selectedItemType == ItemType.RingRight)
                       {
                           commandName = "Ring";
                       }
                       else
                       {
                           commandName = selectedItemType.ToString();
                       }
                       var command = _commandFactory(commandName);
                       command.RunCommand();
                   }));
        }
    }


    public void OnPropertyChanged([CallerMemberName] string prop = "")
    {
        if (PropertyChanged != null)
            PropertyChanged(this, new PropertyChangedEventArgs(prop));
    }

    public void GetAway()
    {
        try
        {
            SelectedLairEnemy?.Heal();
            SelectedPlayer?.Heal();
        }
        catch (NullReferenceException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    private PlayerDto _selectedPlayer;
    private WayPointDto _selectedWayPoint;
    private EnemyDto _selectedLairEnemy;
    private Command _sendRequestCommand;
    private Command _equipCommand;
    public event PropertyChangedEventHandler PropertyChanged;
}