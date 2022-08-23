using Host.ViewModels;
using Host.Views;
using Microsoft.Extensions.DependencyInjection;
using System.Windows;
using Hellworker.Wow.Commands.Implementation;
using Hellworker.Wow.DataAccess.Abstractions;
using Hellworker.Wow.DataAccess.Data;
using Hellworker.Wow.DataAccess.Repository;
using Hellworker.Wow.Host.Abstraction;
using Host.ImplementationEquipCommands;
using Microsoft.EntityFrameworkCore;
using AutoMapper;
using Mapping.Mappers;

namespace Hellworker.Wow.Source
{

    public partial class App : Application
    {
        private ServiceProvider _serviceProvider;
        public App()
        {
            ServiceCollection services = new ServiceCollection();
            ConfigureServices(services);
            _serviceProvider = services.BuildServiceProvider();
        }
        
        private void OnStartup(object sender, StartupEventArgs e)
        {
            var initializer = _serviceProvider.GetService<IDBInitializer>();
            initializer.Initialize();

            var viewModel = _serviceProvider.GetService<ApplicationViewModel>();
            viewModel.StartUp();

            var mainWindow = _serviceProvider.GetService<ApplicationView>();
            mainWindow.Show();
        }

        private void ConfigureServices(ServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
            {
                options.UseSqlServer("Server=localhost\\SQLEXPRESS01;Database=AppDB;Trusted_Connection=True;");
                options.UseLazyLoadingProxies();
            });
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new ItemMapper());
                mc.AddProfile(new InventoryMapper());
                mc.AddProfile(new BagMapper());
                mc.AddProfile(new EnemyMapper());
                mc.AddProfile(new PlayerMapper());
                mc.AddProfile(new LocationMapper());
                mc.AddProfile(new WayPointMapper());
                
            });

            var mapper = mapperConfig.CreateMapper();
            services.AddSingleton(mapper);
            services.AddSingleton<ApplicationView>();
            services.AddSingleton<ApplicationViewModel>();
            services.AddTransient<IDBInitializer, DBInitializer>();
            services.AddTransient<IPlayersRepository, PlayersRepository>();
            services.AddTransient<IWayPointsRepository, WayPointsRepository>();

            services.AddTransient<AbstractRequest, AttackRequest>();
            services.AddTransient<AbstractRequest, ExitRequest>();
            services.AddTransient<AbstractRequest, OpenInventoryRequest>();
            services.AddTransient<AbstractRequest, OpenMenuButtonsPanelRequest>();
            services.AddTransient<AbstractRequest, OpenNewHeroPanelRequest>();
            services.AddTransient<AbstractRequest, OpenSelectHeroPanelRequest>();
            services.AddTransient<AbstractRequest, OpenWayPointsRequest>();
            services.AddTransient<AbstractRequest, SelectPlayerRequest>();
            services.AddTransient(AbstractRequest.GetRequest);

            services.AddTransient<AbstractEquipCommand, AmuletEquipCommand>();
            services.AddTransient<AbstractEquipCommand, BeltEquipCommand>();
            services.AddTransient<AbstractEquipCommand, BootsEquipCommand>();
            services.AddTransient<AbstractEquipCommand, BracersEquipCommand>();
            services.AddTransient<AbstractEquipCommand, ChestplateEquipCommand>();
            services.AddTransient<AbstractEquipCommand, GlovesEquipCommand>();
            services.AddTransient<AbstractEquipCommand, HelmEquipCommand>();
            services.AddTransient<AbstractEquipCommand, OffHandEquipCommand>();
            services.AddTransient<AbstractEquipCommand, PantsEquipCommand>();
            services.AddTransient<AbstractEquipCommand, RingEquipCommand>();
            services.AddTransient<AbstractEquipCommand, ShouldersEquipCommand>();
            services.AddTransient<AbstractEquipCommand, WeaponEquipCommand>();
            services.AddTransient(AbstractEquipCommand.GetCommand);
        }
    }
}
