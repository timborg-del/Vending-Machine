using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    public class Pistol : IProduct
    {

        
        string brand = "Magnum 9,5mm";
        string name = "The Golden Gun";
        int price = 750;

        public int Price { get { return price; } }
        public string Brand { get { return brand; } }
        public string Name { get { return name; } }


        public string Examine()
        {
            return $"Brand: {Brand}\n Name: {Name}\n Price: {Price}";
                                 
        }
        public string Purcase()

        {
            string boughtGun = "Now when you have you new TOOL";
            return boughtGun;          
        }
        void dosomething()
        {
       
        }

        public string Use()
        {
            string useGun = "You feel the power";
            return useGun; 
        }
        public Pistol(int newprice, string newbrand, string newname)
        {
            brand = newbrand;
            name = newname;
            price = newprice;

        }
        
    }
}
