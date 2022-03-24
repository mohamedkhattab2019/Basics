// See https://aka.ms/new-console-template for more information
using System;

namespace DesignPatterns.Factory{
    public class Program 
    {
        static void Main(string[] args)
        {
                string cardNumber,bankCode;

                // ========= now client not resbonsible of creating object =======
                // BankA bankA = new BankA();
                // BankB bankB = new BankB();
                BankFactory bankFactory = new BankFactory();

                // Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Enter your card Number :",ConsoleColor.Cyan);
                cardNumber = Console.ReadLine();
                bankCode   = cardNumber.Substring(0,6);

                // applying Factory pattern 

                // make factory class responsible of return banck type throuth the logic
                // switch(bankCode){
                //     case "123456" : Console.WriteLine(bankA.withdrow());break;
                //     case "111111" : Console.WriteLine(bankB.withdrow());break;

                // }        
                IBank  bank =bankFactory.GetBank(bankCode);
                 Console.WriteLine(bank.WithDrow());
        }
    }
}