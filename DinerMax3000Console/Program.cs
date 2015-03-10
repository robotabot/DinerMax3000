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
            MenuItem mostaciolli = new MenuItem();
            mostaciolli.Title = "Mostaciolli";
            mostaciolli.Description = "Noodles, Sauce, Cheese, Oh My!";
            mostaciolli.Price = 12.50;
            summerMenu.Items.Add(mostaciolli);
        }
    }
}
