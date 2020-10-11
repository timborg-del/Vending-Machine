using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;

namespace VendingMachine
{
    public class VendingMachine
    {
        double storedMony;

        Pistol wholePackPistol = new Pistol(); // Access Propertys from objects. 
        Hamburger wholePackHamburger = new Hamburger();
        Ammunition wholePackAmmuntions = new Ammunition();


        int[] acceptedCoins = { 1, 5, 10, 20, 50, 100, 500, 1000, };


        //there is onely one way to get input to a method and one way to get something out from a method: In parameter and out :
        public IProduct Choose(int button)
        { // Giving instruction to buttons
            if (button < 1 || button > 3)
            {
                throw new ArgumentException("Thats not Valid Button");
            }
            else if (button == 1 && storedMony >= wholePackPistol.Price)
            {

                storedMony = storedMony - wholePackPistol.Price;
                                
                return wholePackPistol;
            }

            else if (button == 2 && storedMony >= wholePackHamburger.Price)
            {
                storedMony = storedMony - wholePackHamburger.Price;
                
                return wholePackHamburger;
            
            }
            else if (button == 3 && storedMony >= wholePackAmmuntions.Price)
            {
                storedMony = storedMony - wholePackAmmuntions.Price;
                
                return wholePackAmmuntions;
            
            }

            throw new ArgumentException("You cant afford this thing");
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

            
            Pistol pistol = new Pistol();
            Hamburger hamburger = new Hamburger();
            Ammunition ammunition = new Ammunition();
            string storeammunition = ammunition.Examine();
            string storeHamburgerShow = hamburger.Examine();
            string storePistolShow = pistol.Examine();
            string[] storedItems = new string[3];
            storedItems[0] = storePistolShow;
            storedItems[1] = storeHamburgerShow;
            storedItems[2] = storeammunition;

            return storedItems;

        }
        public double CashOut()
        {

            if (true)
            {

                return storedMony;
            }

        }


        // choose int:1 
        // Int: userInputCach
        // showAllProducts


    }

}
