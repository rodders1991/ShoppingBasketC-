using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class ItemOrder
    {
       
        public string name
        {
            get;
            set;
        }
        
        public double latestPrice
        {
            get;
            set;
        }

        public int quantity
        {
            get;
            set;
        }


        public ItemOrder(string name, double latestPrice, int quantity)
        {
            this.name = name;
            this.latestPrice = latestPrice;
            this.quantity = quantity;
        }

        public ItemOrder(string name, double latestPrice)
        {
            this.name = name;
            this.latestPrice = latestPrice;
            quantity = 1;
        }

       
    }
}
