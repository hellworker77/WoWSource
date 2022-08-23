using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Host.ViewModels;

namespace Host.Views
{
    /// <summary>
    /// Логика взаимодействия для ApplicationView.xaml
    /// </summary>
    public partial class ApplicationView : Window
    {
        public ApplicationView(ApplicationViewModel applicationViewModel)
        {
            

            InitializeComponent();
            DataContext = applicationViewModel;
        }
        public Grid WayPointsPanel
        {
            get => wayPointsPanel;
            set => wayPointsPanel = value;
        }

        public Grid Inventory
        {
            get => inventory;
            set => inventory = value;
        }
        public Grid Menu
        {
            get => menu;
            set => menu = value;
        }
        public Grid Game
        {
            get => game;
            set => game = value;
        }
        public Grid SelectHero
        {
            get => selectHero;
            set => selectHero = value;
        }
        public Grid CreateHero
        {
            get => createHero;
            set => createHero = value;
        }
        public Grid MenuButtons
        {
            get => menuButtons;
            set => menuButtons = value;
        }
    }
}
