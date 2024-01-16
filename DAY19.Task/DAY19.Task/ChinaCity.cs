using System;
using System.Collections.Generic;
using System.Text;

namespace DAY19.Task
{
    internal class ChinaCity:City
    {
        public new int Population
        {
            get
            {
                return base.Population;
            }
            set
            {
                if(value > 100000) 
                    base.Population = value;    
                
            }

        }

       





    }
}
