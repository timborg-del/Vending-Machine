using System;
using System.Collections.Generic;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating an object
            
            VendingMachine vendingMachine = new VendingMachine();
            vendingMachine.ShowAllProducts();
            string[] items = vendingMachine.ShowAllProducts();
            foreach (var item in items)
            {

                Console.WriteLine(item);
            }
            try
            {
            vendingMachine.InputMony(1000);
            IProduct gun = vendingMachine.Choose(1);
                Console.WriteLine("You bought:" + gun.Examine());  // Good thing about inheritench i can have a whole class in one veribal

            }
            catch (Exception EX)
            {

                Console.WriteLine(EX.Message);
            }
            
            Console.WriteLine("Here is you Cange:" + vendingMachine.CashOut());

            
            
            
            
            
            
        

            /*
             * Array 3 pruducts
             * Monypool
             * creat class Products / Propertys / Childre: Inheriteche set items to constructors and give the value to produkt class
             * 
             * 
             * 


           */
        }
    }
}
