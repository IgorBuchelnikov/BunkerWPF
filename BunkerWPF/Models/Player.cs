using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bunker.Data;
using Bunker.ViewModels;

namespace Bunker.Models
{
    public class Player : INotifyPropertyChanged
    {
        public Player()
        {
        }
        public Player(string name)
        {
            Name = name;
        }
        private string _name;
        private Purpose _purpose;
        private Hero _hero;

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
