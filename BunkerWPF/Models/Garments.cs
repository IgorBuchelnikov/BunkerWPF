using System;
using System.Collections.Generic;
using System.Text;

namespace Bunker.Models
{
    public class Garments : Item
    {
        public enum GarmentsType
        {
            Hat,
            Body,
            Shoe
        }
        private GarmentsType _garmentsType;
        private byte _protection;
        public GarmentsType GarmentType
        {
            get
            {
                return _garmentsType;
            }
            set
            {
                _garmentsType = value;
            }
        }
        public byte Protection
        {
            get
            {
                return _protection;
            }
            set
            {
                _protection = value;
            }
        }
    }
}
