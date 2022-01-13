using System;
using System.Collections.Generic;
using System.Text;

namespace Bunker.Models
{
    public class Item
    {
        public Item()
        { }

        public Item(string name, string description, bool isUnique)
        {
            Name = name;
            Description = description;
            IsUnique = isUnique;
        }

        private string _name;
        private string _description;
        private bool _isUnique;
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
        public bool IsUnique
        {
            get
            {
                return _isUnique;
            }
            set
            {
                _isUnique = value;
            }
        }
    }
}
