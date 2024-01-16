using System;
using System.Collections.Generic;
using System.Text;

namespace DAY19.Task
{
    internal class City
    {

        private string _name;
        private int _population;
        public string Name {
            get
            {
                return _name;
            }
            set 
            { 
                if( value.Length >3 && value.Length <20 && AllLetter(value))
                    _name = value;
            }
        }
        public int Population
        {
            get
            {
                return _population;
            }
            set 
            { 
                if(value > 0)
                    _population = value;
            }
        }

        public bool AllLetter(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                if (!char.IsLetter(str[i]))
                {
                    return false;
                }
            }
            return true;
        }

    }
}
