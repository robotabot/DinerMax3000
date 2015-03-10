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

            Order guestOrder = new Order();

            foreach (MenuItem dish in summerMenu.Items)
            {
                guestOrder.Items.Add(dish);
            }

            foreach (MenuItem drink  in outsideDrinks.Items)
            {
                guestOrder.Items.Add(drink);
            }

            Console.WriteLine("The order total is " + guestOrder.Total);

            try
            {
                outsideDrinks.AddMenuItem("WhatDrink", "I don't know", 0);
            }
            catch(Exception thrownException)
            {
                Console.WriteLine(thrownException.Message);
            }

            Console.ReadKey();
        }
    }
}
