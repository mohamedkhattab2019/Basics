namespace solidConsleDemo.DIP
{
    public class Notification
    {
    //     private Gmail   _gmail      = new Gmail();
    //     private Hotmail  _hotmail   = new Hotmail();
    // //------- Adding new featuere that send multi mails web service ------
    // // adding new object and new method which violate OCP and DIP
    
    //     private WebMail  _webmail   = new WebMail();

    //     public void SendGmail(){_gmail.Send();}
    //     public void SendHotmail(){_hotmail.Send();}

    //     public void SendWebMail(){_webmail.Send();}
        
        
    // sln : add new layer interface layer Imessage Interface
    //use the constractor to specify the notifiction type class that will be implemented
    //which implement the IMessage Inerface 



        //------Constructor injection
        private IMessage _mailService;
        public Notification(IMessage mailservice)
        {
            _mailService=mailservice;
        }
        public void SendMail(){_mailService.Send();}
        
        //-------- Method Injection 
        // public void SendMail(IMessage mailService){mailService.Send();}

        //---------------- Prop Injection 
        // public IMessage mailType {get;set;}
        // public void SendMail(){mailType.Send();}


        
    }
}