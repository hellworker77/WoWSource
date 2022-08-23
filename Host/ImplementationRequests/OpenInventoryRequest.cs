using Hellworker.Wow.Host.Abstraction;
using Host.ViewModels;
using Host.Views;
using System.Threading.Tasks;
using System.Windows;

namespace Hellworker.Wow.Commands.Implementation;

public class OpenInventoryRequest : AbstractRequest
{
    public OpenInventoryRequest(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }

    protected override string CommandString => "OpenInventoryCommand";

    protected override void InternalLogic()
    {
        if (_view.Inventory.Visibility != Visibility.Collapsed)
        {
            _view.Inventory.Visibility = Visibility.Collapsed;
        }
        else
        {
            _view.Inventory.Visibility = Visibility.Visible;
        }
    }
}