namespace solidConsleDemo.DIP
{
    // public class Gmail 
    // {
    //     public string Address="address";
    //     public string from="from mail";
    //     public string ToAddress="ToAddress";

    //     public void Send(){
    //         //some code 
    //     }
    // }

    // public class Hotmail 
    // {
    //     public string Address="address";
    //     public string from="from mail";
    //     public string ToAddress="ToAddress";

    //     public void Send(){
    //         //some code 
    //     }
    // }

    // ////// ----------------- Adding new featuere that send multi mails web service 
    // public class WebMail 
    // {
    //     public string Address="address";
    //     public string from="from mail";
    //     public string ToAddress="ToAddress";

    //     public void Send(){
    //         //some code 
    //     }
    // }


    // soln : let the lower ,modules implement the abstract layer (IMessage)
    public class Gmail :IMessage
    {
        public string Address="address";
        public string from="from mail";
        public string ToAddress="ToAddress";

        public void Send(){
            //some code 
            Console.WriteLine("Hello,Gmail!");

        }
    }

    public class Hotmail :IMessage
    {
        public string Address="address";
        public string from="from mail";
        public string ToAddress="ToAddress";

        public void Send(){
            //some code 
        }
    }

    ////// ----------------- Adding new featuere that send multi mails web service 
    public class WebMail :IMessage
    {
        public string Address="address";
        public string from="from mail";
        public string ToAddress="ToAddress";

        public void Send(){
            //some code 
        }
    }

}