using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu summerMenu = new Menu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Mostaciolli", "Noodles, Sauce, Cheese, Oh My!", 12.50);
            summerMenu.AddMenuItem("Garlic Bread", "Fresh bread, butter, and garlic", 3.95);
        }
    }
}
