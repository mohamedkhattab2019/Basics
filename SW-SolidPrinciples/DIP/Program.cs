// See https://aka.ms/new-console-template for more information

namespace solidConsleDemo.DIP {
    class Program
    {
        static void Main (string[] arg)
        {
            // Notification notification =new Notification();
            // notification.SendGmail();
            // notification.SendHotmail;
            // // after adding new class
            // notification.SendWebMail();
            //----after soln
            //----- Constructor injection
            
            Notification notification =new Notification(new Gmail());
            // or 
            // Notification notification =new Notification(new Hotmail());
            // //or 
            // Notification notification =new Notification(new WebMail());
            notification.SendMail();

            // --- Methode Injection
            // Notification notification =new Notification();
            // notification.SendMail(new Gmail());

            // --- Propety Injection
            // Notification notification =new Notification();
            // notification.mailType =new Gmail();
            // notification.SendMail();



        }
    }
}