using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;
using System.Threading.Tasks;
using System.Windows;

namespace Hellworker.Wow.Commands.Implementation;

public class OpenSelectHeroPanelRequest : AbstractRequest
{
public OpenSelectHeroPanelRequest(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
{
}

protected override string CommandString => "OpenSelectHeroPanelCommand";

protected override void InternalLogic()
{
    _view.MenuButtons.Visibility = Visibility.Collapsed;
    _view.SelectHero.Visibility = Visibility.Visible;
    _view.CreateHero.Visibility = Visibility.Collapsed;
}
}