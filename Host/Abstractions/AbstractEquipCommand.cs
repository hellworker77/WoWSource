using System;
using System.Linq;
using Host.ViewModels;
using Host.Views;
using Microsoft.Extensions.DependencyInjection;

namespace Hellworker.Wow.Host.Abstraction;

public abstract class AbstractEquipCommand
{
    protected readonly ApplicationView _view;
    protected readonly ApplicationViewModel _viewModel;

    protected AbstractEquipCommand(ApplicationView window, ApplicationViewModel applicationViewModel)
    {
        _view = window;
        _viewModel = applicationViewModel;
    }
    public virtual bool IsCommandNameFor(string input)
    {
        return CommandString.Contains(input);
    }
    public void RunCommand()
    {
        InternalLogic();
    }

    protected virtual void InternalLogic()
    {
        _viewModel.SelectedPlayer.Update();
        _viewModel.OnPropertyChanged("SelectedPlayer");
    }
    public static Func<IServiceProvider, Func<string, AbstractEquipCommand>> GetCommand =>
        provider => input =>
        {
            var command = provider.GetServices<AbstractEquipCommand>().First(c => c.IsCommandNameFor(input));

            return command;
        };
    protected abstract string CommandString { get; }
}