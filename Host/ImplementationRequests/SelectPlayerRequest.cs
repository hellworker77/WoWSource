using System.Threading.Tasks;
using System.Windows;
using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;

namespace Hellworker.Wow.Commands.Implementation;

public class SelectPlayerRequest : AbstractRequest
{
    public SelectPlayerRequest(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }

    protected override string CommandString => "SelectPlayerCommand";

    protected override void InternalLogic()
    {
        _view.Menu.Visibility = Visibility.Collapsed;
        _view.Game.Visibility = Visibility.Visible;
    }
}