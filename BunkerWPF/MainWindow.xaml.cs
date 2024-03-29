﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Bunker.ViewModels;
using BunkerWPF.ViewModels.StartGame;

namespace BunkerWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new ViewModel();
            ViewModel.Instance.Login = "Dev";
            ViewModel.Instance.Password = "Bunker";
            ViewModel.Instance.NavigationService = iAppBrowser.NavigationService;
            iAppBrowser.Navigate(new Uri("Pages/LogonPage.xaml", UriKind.Relative));
        }

        private void DragWindow(object sender, MouseButtonEventArgs e)
        {
            DragMove();

            if (e.ClickCount == 2) // прячем форму
            {
                if (this.WindowState == WindowState.Maximized)
                {
                    this.WindowState = WindowState.Normal;
                    return;
                }
                if (this.WindowState == WindowState.Normal)
                    this.WindowState = WindowState.Maximized;
            }            
        }

        private void MinimizedApp(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }
    }
}
