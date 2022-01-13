using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bunker.Data;
using Bunker.ViewModels;

namespace Bunker.Models
{
    public class Player
    {
        public Player()
        {
            _availableHeroes = HeroesData.GetAllSavedHero();
        }
        public Player(string name)
        {
            Name = name;
            _availableHeroes = HeroesData.GetAllSavedHero();
        }
        private string _name;
        private Purpose _purpose;
        private Hero _hero;
        private ObservableCollection<Hero> _availableHeroes;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
                OnPropertyChanged("Name");
            }
        }
        public Hero Hero
        {
            get
            {
                return _hero;
            }
            set
            {                
                _hero = value;
                OnPropertyChanged("Hero");
            }
        }
        public ObservableCollection<Hero> AvailableHeroes
        {
            get
            {
                return _availableHeroes;
            }
            set
            {
                _availableHeroes = value;
                OnPropertyChanged("AvailableHeroes");
            }
        }
        public Purpose Purpose
        {
            get
            {
                return _purpose;
            }
            set
            {
                _purpose = value;
                OnPropertyChanged("Purpose");
            }
        }

        public void SetRandomHero()
        {
            Random random = new Random();
            Hero = AvailableHeroes[random.Next(1, AvailableHeroes.Count)];
        }

        public override string ToString()
        {
            return Name;
        }
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
        }
    }
}
