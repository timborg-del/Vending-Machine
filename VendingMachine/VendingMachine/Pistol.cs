using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Pistol : IProduct
    {
        string brand = "Magnum 9,5mm";
        string name = "The Golden Gun";
        readonly int price = 750;

        public int Price { get { return price; } }
        public string Brand { get { return brand; } }
        public string Name { get { return name; } }

        public string Examine()
        {
            return $"Brand: {Brand}\n Name: {Name}\n Price: {Price}";
                      
           
        }
        public string Purcase()
        {
            return "";
            
        }

        public string Use()
        {
            return ""; 
        }


        
    }
}
