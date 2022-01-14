using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Bunker.ViewModels;
using Bunker.Models;
using BunkerWPF.ViewModels.StartGame;

namespace BunkerWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewGamePage.xaml
    /// </summary>
    public partial class NewGamePage : Page
    {
        public NewGamePage()
        {
            InitializeComponent();
            DataContext = ViewModel.Instance;
        }
    }
}
