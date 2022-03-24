namespace DesignPatterns.Factory
{
    public class BankFactory : IBankFactory {
        public IBank GetBank (string bankcode)
        {
            switch(bankcode){
                case "123456" : return new BankA();
                case "111111" : return new BankB();
            }   
            return null;

        }
    }
}