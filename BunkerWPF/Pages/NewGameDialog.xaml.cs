using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Bunker.ViewModels;
using BunkerWPF.ViewModels.StartGame;

namespace BunkerWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для NewGameDialog.xaml
    /// </summary>
    public partial class NewGameDialog : Page
    {
        public NewGameDialog()
        {
            InitializeComponent();
            this.DataContext = ViewModel.Instance;
        }
    }
}
