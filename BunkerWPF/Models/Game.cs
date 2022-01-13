using System;
using System.Collections.Generic;

namespace Bunker.Models
{
    public class Game
    {
        private bool _isActive = false;
        private List<Player> _playerList;
        private List<Item> _itemsList;
        private List<Hero> _heroList;
        private List<Garments> _garmentsList;
        private List<Weapon> _weaponList;
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
            }
        }
        public List<Player> Players
        {
            get
            {
                return _playerList;
            }
            set
            {
                _playerList = value;
            }
        }
    }
}
