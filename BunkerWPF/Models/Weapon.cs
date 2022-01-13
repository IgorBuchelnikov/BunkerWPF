using System;
using System.Collections.Generic;
using System.Text;

namespace Bunker.Models
{
    public class Weapon : Item
    {
        public enum WearponType
        {
            NearRange,
            LongRange
        }

        private byte _damage;
        private byte _range;
        private WearponType _wearponType;

        public byte Damage
        {
            get
            {
                return _damage;
            }
            set
            {
                _damage = value;
            }
        }
        public byte Range
        {
            get
            {
                return _range;
            }
            set
            {
                _range = value;
            }
        }
        public WearponType WearponsType
        {
            get
            {
                return _wearponType;
            }
            set
            {
                _wearponType = value;
            }
        }
    }
}
