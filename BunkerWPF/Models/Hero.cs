using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Bunker.ViewModels;

namespace Bunker.Models
{
    public class Hero
    {
        public Hero()
        { }
        public Hero(byte id, string name, Uri imagePath)
        {
            Id = id;
            Name = name;
            ImageSource = imagePath;
        }

        private byte _id;
        private string _name;
        private string _description;
        private byte _health;
        private Garments _hat;
        private Garments _body;
        private Garments _shoe;
        private Weapon _weapon;
        private Item _item1;
        private Item _item2;
        private Item _item3;

        private byte _force;
        private byte _agility;
        private byte _oratory;
        private byte _fortune;

        private Uri _imageSource;

        public byte Id
        {
            get
            {
                return _id;
            }
            set
            {
                _id = value;
                OnPropertyChanged("Id");
            }
        }
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
        public string Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
                OnPropertyChanged("Description");
            }
        }
        public byte Health
        {
            get
            {
                return _health;
            }
            set
            {
                _health = value;
                OnPropertyChanged("Health");
            }
        }
        public Garments Hat
        {
            get
            {
                return _hat;
            }
            set
            {
                _hat = value;
                OnPropertyChanged("Hat");
            }
        }
        public Garments Body
        {
            get
            {
                return _body;
            }
            set
            {
                _body = value;
                OnPropertyChanged("Body");
            }
        }
        public Garments Shoe
        {
            get
            {
                return _shoe;
            }
            set
            {
                _shoe = value;
                OnPropertyChanged("Shoe");
            }
        }
        public Weapon Weapon
        {
            get
            {
                return _weapon;
            }
            set
            {
                _weapon = value;
                OnPropertyChanged("Weapon");
            }
        }
        public Item Item1
        {
            get
            {
                return _item1;
            }
            set
            {
                _item1 = value;
                OnPropertyChanged("Item1");
            }
        }
        public Item Item2
        {
            get
            {
                return _item2;
            }
            set
            {
                _item2 = value;
                OnPropertyChanged("Item2");
            }
        }
        public Item Item3
        {
            get
            {
                return _item3;
            }
            set
            {
                _item3 = value;
                OnPropertyChanged("Item3");
            }
        }

        public byte Force
        {
            get
            {
                return _force;
            }
            set
            {
                _force = value;
                OnPropertyChanged("Force");
            }
        }
        public byte Agility
        {
            get
            {
                return _agility;
            }
            set
            {
                _agility = value;
                OnPropertyChanged("Agility");
            }
        }
        public byte Oratory
        {
            get
            {
                return _oratory;
            }
            set
            {
                _oratory = value;
                OnPropertyChanged("Oratory");
            }
        }
        public byte Fortune
        {
            get
            {
                return _fortune;
            }
            set
            {
                _fortune = value;
                OnPropertyChanged("Fortune");
            }
        }

        public Uri ImageSource
        {
            get
            {
                return _imageSource;
            }
            set
            {
                _imageSource = value;
                OnPropertyChanged("ImageSource");
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
