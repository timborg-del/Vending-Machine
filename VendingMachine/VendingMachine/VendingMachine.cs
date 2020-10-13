using System;
using System.Collections.Generic;
using System.Threading;

namespace VendingMachine
{
    public class VendingMachine
    {
        double storedMony;
        List<IProduct> allProducts = new List<IProduct>();
        int[] acceptedCoins = { 1, 5, 10, 20, 50, 100, 500, 1000, };

        // Access Propertys from objects. 





        public VendingMachine()
        {
            allProducts.Add(new Pistol(800, "James", "Eagel"));
            allProducts.Add(new Hamburger(250, "DubbleTruble", "Burger"));
            allProducts.Add(new Ammunition(500, "Supershoot", "9,5 "));
            allProducts.Add(new GunLicens(600, "Dirty", "Harry"));
        }


        //there is onely one way to get input to a method and one way to get something out from a method: In parameter and out :
        public IProduct Choose(int button)
        { 
            if (button < 1 || button > allProducts.Count )
            {
                throw new ArgumentException("This is not Valid Button ");
                           
            }
            int number = button - 1;
            IProduct product = allProducts[number];
            if (storedMony >= product.Price)
                storedMony = storedMony - product.Price;
            
            else if (storedMony < product.Price)
            {
 
                throw new ArgumentException("YOU DONT HAVE ENOUGH MONY");
            } 
            return product;



            // Giving instruction to buttons
            //if (button < 1 || button > 3)
            //{
            //    throw new ArgumentException("Thats not Valid Button");
            //}
            //else if (button == 1 && storedMony >= wholePackPistol.Price)
            //{
            //    storedMony = storedMony - wholePackPistol.Price;

            //    return wholePackPistol;
            //}

            //else if (button == 2 && storedMony >= wholePackHamburger.Price)
            //{
            //    storedMony = storedMony - wholePackHamburger.Price;

            //    return wholePackHamburger;

            //}
            //else if (button == 3 && storedMony >= wholePackAmmuntions.Price)
            //{
            //    storedMony = storedMony - wholePackAmmuntions.Price;

            //    return wholePackAmmuntions;

            //}

            //throw new ArgumentException("You cant afford this thing");
            //else
            //{
            // throw new ArgumentException("Thats not Valid Button");
            // }
        }
        public void InputMony(double userMony)
        {
            //To dO Check


            //int count = 0;
            bool validCoin = false;
            foreach (var item in acceptedCoins)
            {
                // count++;
                if (userMony == item)
                {
                    validCoin = true;

                    storedMony = storedMony + userMony;

                    break;
                }
                //    else if (userMony == acceptedCoins[1])
                //    {
                //        storedMony = userMony;
                //    }
                //    else if (userMony == acceptedCoins[2])
                //    {
                //        storedMony = userMony;
                //    }
                //    else if (userMony == acceptedCoins[3])
                //    {
                //        storedMony = userMony;
                //    }
                //    else if (userMony == acceptedCoins[4])
                //    {
                //        storedMony = userMony;
                //    }
                //    else if (userMony == acceptedCoins[5])
                //    {
                //        storedMony = userMony;
                //    }
                //    else if (userMony == acceptedCoins[6])
                //    {
                //        storedMony = userMony;
                //    }
                //    else if (userMony == acceptedCoins[7])
                //    {
                //        storedMony = userMony;

                //    }

            }
            if (!validCoin)
            {
                throw new ArgumentException("Thats not Valid coins");
            }



        }

        //dont have to give anyting in parameter cux its just a show
        public string[] ShowAllProducts()
        {



            //Pistol pistol = new Pistol();
            //Hamburger hamburger = new Hamburger();
            //Ammunition ammunition = new Ammunition();
            //string storeammunition = ammunition.Examine();
            //string storeHamburgerShow = hamburger.Examine();
            //string storePistolShow = pistol.Examine();
            string[] allProductInfo = new string[allProducts.Count];
            int count = -1;
            foreach (var item in allProducts)
            {
                count++;
                allProductInfo[count] = item.Examine();

            }
            //storedItems[0] = storePistolShow;
            //storedItems[1] = storeHamburgerShow;
            //storedItems[2] = storeammunition;            
            return allProductInfo;
            // return storedItems;
        }
        public double CashOut()
        {
            double reset = storedMony;
            storedMony = 0;

            return reset;
            

        }


        // choose int:1 
        // Int: userInputCach
        // showAllProducts


    }

}
