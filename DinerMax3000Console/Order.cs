using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Order
    {
        public  List<MenuItem> Items = new List<MenuItem>();

        public double Total
        {
            get
            {
                double calculatedTotal = 0;
                foreach (MenuItem item in Items)
                {
                    calculatedTotal += item.Price;
                }
                return calculatedTotal;
            }
        }
    }
}
