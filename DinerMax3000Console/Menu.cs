﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DinerMax3000Console
{
    public class Menu
    {
        public Menu()
        {
            Items = new List<MenuItem>();
        }

        public void AddMenuItem(string Title, string Description, double Price)
        {
            MenuItem item = new MenuItem();
            item.Title = Title;
            item.Description = Description;
            item.Price = Price;
            Items.Add(item);
        }

        public string Name;
        public List<MenuItem> Items;
    }
}
