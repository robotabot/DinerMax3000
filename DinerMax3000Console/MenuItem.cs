using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class MenuItem
    {
        public string Title;
        public string Description;
        public double Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ApplicationException("Price must be greater than 0");
                }
            }
    }

        private double _price;
    }
}
