using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;
using System.Threading.Tasks;
using Host.ViewModels;
using Host.Views;

namespace Hellworker.Wow.Host.Abstraction
{
    public abstract class AbstractRequest
    {
        protected readonly ApplicationView _view;
        protected readonly ApplicationViewModel _viewModel;
        protected AbstractRequest(ApplicationView window, ApplicationViewModel applicationViewModel)
        {
            _view = window;
            _viewModel = applicationViewModel;
        }
        public virtual bool IsRequestNameFor(string input)
        {
            return CommandString.Contains(input);
        }
        public void RunRequst()
        {
            InternalLogic();
        }
        protected abstract void InternalLogic();
        public static Func<IServiceProvider, Func<string, AbstractRequest>> GetRequest =>
        provider => input =>
        {
            var command = provider.GetServices<AbstractRequest>().First(c => c.IsRequestNameFor(input));

            return command;
        };
        protected abstract string CommandString { get; }
    }
}
