using System;
using System.Collections.Generic;
using System.Text;

namespace VendingMachine
{
    interface IProduct  
    {

        public int Price { get; }
        public string Brand { get; } 
        public string Name { get; }


        /// <summary>
        /// USE to put the product to use once it has been purchased (output amessage to the console)     
        /// </summary>
        /// <returns></returns>
        public string Use();

        /// <summary>
        /// EXAMINE  To show the products and info
        /// </summary>
        /// <returns></returns>
        public string Examine();

        
        /// <summary>
        /// PURCASE  to buy the product
        /// </summary>
        /// <returns></returns>
        public string Purcase();






        /* 
         * Its Propterty 
         * 
         * 
         */
    }
}
