namespace solidConsoleDemo.ISP
{
    public interface IOrder 
    {
        // void processCashInvoice();
        // void processCreditInvoice();

        // void processOnlinPaymentInvoice();

    }

//solution 
    public interface ICashOrder{
        void processCashInvoice();
        // adding new method will only affect the classes extend the interface
        void Complete();
    }
    public interface IOnlineOrder{
        void processOnlinPaymentInvoice();
    }
    public interface ICreditOrder{
        void processCreditInvoice();
    }

    // if you need to implement case that you can use all payment method once**
    //then create class that implement all the inherted methodes
    public interface IMixOrder : ICashOrder ,IOnlineOrder,ICreditOrder
    {/// that is better than iplement direct class inherit from the three interface 
    // as if you need to add some thing special to that class or interface 
        void newMehtode();

    }

}