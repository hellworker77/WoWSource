using Host.ViewModels;
using Host.Views;
using System.Threading.Tasks;
using System.Windows;
using Hellworker.Wow.Host.Abstraction;

namespace Hellworker.Wow.Commands.Implementation;

public class OpenMenuButtonsPanelRequest : AbstractRequest
{
    public OpenMenuButtonsPanelRequest(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }

    protected override string CommandString => "OpenMenuButtonsPanelCommand";

    protected override void InternalLogic()
    {
        _view.MenuButtons.Visibility = Visibility.Visible;
        _view.SelectHero.Visibility = Visibility.Collapsed;
        _view.CreateHero.Visibility = Visibility.Collapsed;
    }
}