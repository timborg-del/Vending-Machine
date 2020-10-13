using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;

namespace VendingMachine
{
    class GunLicens : IProduct
    {
        string brand;
        string name;
        int price;

        public string Name { get { return name; } }

        public int Price { get { return price; } }
        
        public string Brand { get { return brand; } }

        public string Examine()
        {
            return $"Brand: {Brand}\n Name: {Name}\n Price: {Price}";
        }

        public string Purcase()
        {
            string gunLicens = "You have bought the licens";
            return gunLicens;
        }

        public string Use()
        {
            string useLicens = "You are now able to kill GL";
            return useLicens;
        }
        public GunLicens(int newprice, string newname, string newbrand)
        {
            brand = newbrand;
            name = newname;
            price = newprice;

        }
    }
}
