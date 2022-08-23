using Host.ViewModels;
using Host.Views;
using System.Threading.Tasks;
using System.Windows;
using Hellworker.Wow.Host.Abstraction;

namespace Hellworker.Wow.Commands.Implementation;

public class ExitRequest : AbstractRequest
{
    public ExitRequest(ApplicationView window, ApplicationViewModel applicationViewModel) : base(window, applicationViewModel)
    {
    }

    protected override string CommandString => "ExitCommand";

    protected override void InternalLogic()
    {
        Application.Current.Shutdown();
    }
}