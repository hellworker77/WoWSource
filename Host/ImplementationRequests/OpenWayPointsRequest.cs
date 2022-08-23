using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;
using System.Threading.Tasks;
using System.Windows;

namespace Hellworker.Wow.Commands.Implementation;

public class OpenWayPointsRequest : AbstractRequest
{
    public OpenWayPointsRequest(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }

    protected override string CommandString => "OpenWayPointsCommand";

    protected override void InternalLogic()
    {
        if (_view.WayPointsPanel.Visibility != Visibility.Collapsed)
        {
            _view.WayPointsPanel.Visibility = Visibility.Collapsed;
        }
        else
        {
            _view.WayPointsPanel.Visibility = Visibility.Visible;
        }
    }
}