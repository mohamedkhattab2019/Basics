using System;
using System.Collections.Generic;
using System.Linq;  
using SalesInvoice;
namespace solidConsoleDemo
{
    public class Item{
        public String code;
        public double price;
        public double qty;
    }

    public class stock {
        public static List<Item> items = new List<Item> {
            new Item{code="123",price=10,qty=10},
            new Item{code="456",price=12,qty=2},
            new Item{code="789",price=14,qty=1},

        };

        public static bool IsAvailableQuantity(Item item)  // 1- soln
        {
            if(item.qty < items.Where(x => x.code==item.code).FirstOrDefault().qty)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    public class shopingCart{
        List<Item> cartItems = new List<Item>(); 

        public void RemoveFromCart(Item item)
        {
            if (cartItems.Contains(item)) cartItems.Remove(item);
        }

        public bool AddItem(Item item)
        {
        //    var quantityInstock =  stock.items.Where(x => x.code==item.code).FirstOrDefault().qty; // 1- violate srp this must be in stock class
        //    if (quantityInstock > item.qty)
            if(stock.IsAvailableQuantity(item))    
           {
               cartItems.Add(item);
               return true;
           }
           else return false;
        }

        public int GetItemsCount(){return cartItems.Count;}

        // public void CreateInvoce () // 2- violate on methode responsibilities single reasone to edits solved by extract method in external class
        // {
        //     // calc total price 
        //     var total = cartItems.Sum(x=> x.price);
        //     // get customer data and save it in data base 
        //     // print invoice 
        //     // send invoice to customer email
        // }
    }

    class program
    {
        static void Main(String[] aargs)
        {
            shopingCart myCart = new shopingCart();
            myCart.Add(new Item());
            SalesInvoice.CreateInvoce(myCart,1); // 2- soln    ---- '1' is the customer id
            Console.WriteLine("Items count " + myCart.GetItemsCount().ToString());
        }
        
    }
    
}