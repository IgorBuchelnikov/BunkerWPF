﻿using System;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using Bunker.ViewModels;
using BunkerWPF.ViewModels.StartGame;

namespace BunkerWPF.Pages
{
    /// <summary>
    /// Логика взаимодействия для LogonPage.xaml
    /// </summary>
    public partial class LogonPage : Page
    {
        public LogonPage()
        {
            InitializeComponent();
            this.DataContext = ViewModel.Instance;
        }
        private void PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            { ((dynamic)this.DataContext).Password = ((PasswordBox)sender).Password; }
        }
    }
}
