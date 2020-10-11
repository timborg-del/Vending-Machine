using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Ammunition : IProduct
    {
        string name = "9,5";
        readonly int price = 300;
        string brand = "Heavy Gun Bullets";
        public string Name { get { return name; } }

        public int Price { get { return price; } }

        public string Brand { get { return brand; } }


        public string Examine()
        {
            return $"Brand: {Brand}\n Name: {Name}\n Price: {Price}";
        }

        public string Purcase()
        {
            string bullets = "You have purcase the Bullets";
            return bullets;
        }

        public string Use()
        {
           string useBullets = "You have used the bullets";
           return useBullets; 
        }
    }
}
