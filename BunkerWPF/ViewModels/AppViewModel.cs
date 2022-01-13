using System;
//using System.Linq;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Navigation;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bunker.Models;
using Bunker.Data;
using BunkerWPF.Pages;

namespace Bunker.ViewModels
{
    public class AppViewModel
    {
        #region Instance
        private static AppViewModel _instance;
        public AppViewModel() 
        {
            SelectedPlayers = new ObservableCollection<Player>();
        }
        public static AppViewModel Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AppViewModel();
                }

                return _instance;
            }
        }
        #endregion
        #region AppService
        private Command _closeCommand;
        public Command CloseApp
        {
            get
            {
                return _closeCommand ??
                    (_closeCommand = new Command(action => { Environment.Exit(0); }));
            }
        }
        #endregion
        #region LogonService
        private string _login;
        private string _password;
        private Command _checkAuth;

        public string Login
        {
            get
            {
                return _login;
            }
            set
            {
                _login = value;
                OnPropertyChanged("Login");
            }
        }
        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                _password = value;
                OnPropertyChanged("Password");
            }
        }

        public Command CheckAuth
        {
            get
            {
                return _checkAuth ??
                    (_checkAuth = new Command(action => { CheckAutorification(); }));
            }
        }

        private void CheckAutorification()
        {
            if (Login == "Dev" && Password == "Bunker")
            {
                NavigationService.Navigate(new Uri("Pages/NewGameDialog.xaml", UriKind.Relative));
            }
            else
            {
                System.Windows.MessageBox.Show("Wrong login/password. Access denied.");
            }
        }
        #endregion
        #region NewGame
        private Command _startNewGame;
        private Command _loadSavedGames;
        private Command _addPlayer;
        private Command _deletePlayer;
        private Command _startGame;
        //private Command _allPlayerRandomHeroes;
        private Command _clearAllUsedHeroes;

        public Command StartNewGame
        {
            get
            {
                return _startNewGame ??
                    (_startNewGame = new Command(action => { ShowStartNewGameScreen(); }));
            }
        }
        public Command LoadSavedGames
        {
            get
            {
                return _loadSavedGames ??
                    (_loadSavedGames = new Command(action => { LoadSavedGamesFromFile(); }));
            }
        }
        public Command AddPlayerToList
        {
            get
            {
                return _addPlayer ??
                    (_addPlayer = new Command(action => { AddNewPlayer(); }));
            }
        }
        public Command DeleteLastPlayer
        {
            get
            {
                return _deletePlayer ??
                    (_deletePlayer = new Command(action => { DeleteLastSelectedPlayer(); }));
            }
        }

        

        public Command StartGame
        {
            get
            {
                return _startGame ??
                    (_startGame = new Command(action => { LoadPlayersAndStartGame(); }));
            }
        }
        public Command ClearAllUsedHeroes
        {
            get
            {
                return _clearAllUsedHeroes ??
                    (_clearAllUsedHeroes = new Command(action => { ClearUsedHeroesFromAvailableList(); }));
            }
        }

        private void LoadPlayersAndStartGame()
        {
            SelectedPlayers[1].AvailableHeroes.RemoveAt(1); //TODO
        }
        private void ShowStartNewGameScreen()
        {
            SelectedPlayers.Add(new Player());
            SelectedPlayers.Add(new Player());
            OnPropertyChanged("SelectedPlayers");
            NavigationService.Navigate(new Uri("Pages/NewGamePage.xaml", UriKind.Relative));
        }
        private void LoadSavedGamesFromFile()
        {
            System.Windows.MessageBox.Show("This feature not work in this build. Update your application.");
        }
        private void AddNewPlayer()
        {
            if (SelectedPlayers.Count < 9)
            {
                Player newPlayer = new Player();
                SelectedPlayers.Add(newPlayer);
                //ClearUsedHeroesFromAvailableList();
                OnPropertyChanged("SelectedPlayers");
                OnPropertyChanged("AvailableHeroes");
            }
        }

        private void DeleteLastSelectedPlayer()
        {
            if (SelectedPlayers.Count > 2)
            {
                SelectedPlayers.RemoveAt(SelectedPlayers.Count - 1);
                OnPropertyChanged("SelectedPlayers");
            }
        }

        private void ClearUsedHeroesFromAvailableList()
        {
            SelectedPlayers[1].AvailableHeroes.RemoveAt(1); //TODO
        }


        #endregion
        #region Game
        private ObservableCollection<Player> _selectedPlayers;
        public ObservableCollection<Player> SelectedPlayers
        {
            get
            {
                return _selectedPlayers;
            }
            set
            {
                _selectedPlayers = value;
                //OnPropertyChanged("SelectedPlayers");
            }
        }
        #endregion
        #region Navigation
        private NavigationService _navigationService;
        public NavigationService NavigationService
        {
            get
            {
                return _navigationService;
            }
            set
            {
                _navigationService = value;
            }
        }
        #endregion
        #region Services
        public bool IsEventLocked { get; set; }
        #endregion
        #region NotifyPropertyChanges
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
        #endregion
    }
}
