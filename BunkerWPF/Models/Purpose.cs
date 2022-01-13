using System;
using System.Collections.Generic;
using System.Text;

namespace Bunker.Models
{
    public class Purpose
    {
        private string _name;
        private string _description;
        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
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
            }
        }
    }
}
