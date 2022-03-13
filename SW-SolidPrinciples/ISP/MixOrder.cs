namespace solidConsoleDemo.ISP{
///class to inherit from mix interface which inhirite from all interfaces

    public class MixOrder: IMixOrder {
        public void processOnlinPaymentInvoice()
        {
            throw new System.NotImplementedException();
        }
        public void processCashInvoice()
        {
            throw new System.NotImplementedException();
        }
        public void Complete()
        {
            // code
        }
        public void processCreditInvoice()
        {
            throw new System.NotImplementedException();
        }

        public void newMehtode()
        {
            //code
        }

    }
}