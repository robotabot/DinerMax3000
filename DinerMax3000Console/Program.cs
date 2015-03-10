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
            FoodMenu summerMenu = new FoodMenu();
            summerMenu.Name = "Summer menu";
            summerMenu.AddMenuItem("Mostaciolli", "Noodles, Sauce, Cheese, Oh My!", 12.50);
            summerMenu.AddMenuItem("Garlic Bread", "Fresh bread, butter, and garlic", 3.95);
            summerMenu.HospitalDirections = "HAHAHAHAHAHAHA";

            DrinkMenu outsideDrinks = new DrinkMenu();
            outsideDrinks.Disclaimer = "Take care now";
            outsideDrinks.AddMenuItem("Rum Chata", "Tastes like cinnamon", 3.95);
        }
    }
}
