using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Hamburger : IProduct
    {
        string brand = "Nice Slice";
        string name = "Double Flippin Chees";
        readonly int price = 50;



        public string Name { get { return name; } }

        public int Price { get { return price; } }

        public string Brand { get { return brand; } }

        public string Examine()
        {
            return $"Brand: {Brand}\n Name: {Name}\n Price: {Price}";
        }

        public string Purcase()
        {
            string hamburger = "You have purcase Burger";
            return hamburger;            
        }

        public string Use()
        {
            string useHamburger = "Tasted like Death";
            return useHamburger;
        }
    }
}
