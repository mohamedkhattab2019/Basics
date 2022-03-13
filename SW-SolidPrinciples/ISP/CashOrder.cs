namespace solidConsoleDemo.ISP{


    // her this class to implement cash Invoice only 
    //but interface force the class implement whol methodes it has
    // so if you remove the another to methods implrmrntaion
    //EROR:'CashOrder' does not implement interface member 'IOrder.processCreditInvoice()'
    //EROR:'CashOrder' does not implement interface member 'IOrder.processOnlinPaymentInvoice()'
    
    // public class CashOrder : IOrder
    // {
    //     public void processCashInvoice()
    //     {
    //         throw new System.NotImplementedException();
    //     }
    //     public void processCreditInvoice()
    //     {
    //         throw new System.NotImplementedException();
    //     }
    //     public void processOnlinPaymentInvoice()
    //     {
    //         throw new System.NotImplementedException();
    //     }
    // }


    // ---------------------------soln -----------------------

    public class CashOrder : ICashOrder 
    {
        public void processCashInvoice ()
        {
            //code
        }
        //'CashOrder' does not implement interface member 'ICashOrder.Complete()'
        public void Complete()
        {
            // code
        }
    }
}