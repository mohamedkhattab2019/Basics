public class SalesInvoice { // 2- violate single reasone to edit solved by extract method in external class
        public static void CreateInvoce (shopingCart cart , int custId) // 2- violate single reasone to edit
        {
            // calc total price 
            var total = cart.Sum(x=> x.price);
            // get customer data and save it in data base 


            // print invoice    3 - violation on methode level   violate single reasone to edit 

            PrintingManager.Print(""); // 3- soln

            // send invoice to customer email 4 - violation on methode level   violate single reasone to edit 
            EmailService.send(new object());  // 4 -soln
        }
}