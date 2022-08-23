using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;
using System.Linq;
using System.Threading.Tasks;

namespace Hellworker.Wow.Commands.Implementation;

public class AttackRequest : AbstractRequest
{
    public AttackRequest(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }

    protected override string CommandString => "AttackCommand";

    protected override void InternalLogic()
    {
        _viewModel.SelectedLairEnemy.GetHit(_viewModel.SelectedPlayer);

        _viewModel.SelectedPlayer.GetHit(_viewModel.SelectedLairEnemy);



        if (_viewModel.SelectedLairEnemy.IsDefeated)
        {
            var nextEnemy = _viewModel.SelectedWayPoint.Location.Enemies.FirstOrDefault(x => !x.IsDefeated);
            if (nextEnemy != null)
            {
                _viewModel.SelectedLairEnemy = nextEnemy;
            }
            else
            {
                _viewModel.SelectedWayPoint.Location.Restart();

                var nextWayPoint = _viewModel.WayPoints.SkipWhile(x => x != _viewModel.SelectedWayPoint).Skip(1)
                    .FirstOrDefault();

                if (nextWayPoint != null)
                {
                    _viewModel.SelectedWayPoint = nextWayPoint;
                }

                _viewModel.SelectedLairEnemy = _viewModel.SelectedWayPoint.Location.Enemies.First(x => !x.IsDefeated);
            }
        }

        _viewModel.OnPropertyChanged("SelectedLairEnemy");

        _viewModel.OnPropertyChanged("SelectedPlayer");
    }
}