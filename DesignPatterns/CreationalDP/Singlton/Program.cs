// Author : khattab
// client to implement counter class 
// Singlton implementation 
using System;
namespace DesignPatterns.Snglton{
    class Program
    {
        static public void Main(String[] args)
        {
            // Counter counter1 = new Counter();
            // Counter counter2 = new Counter();
            // counter1.AddOne();
            // counter2.AddOne();

            // Console.WriteLine("counter1:"+counter1.counter.ToString());
            // Console.WriteLine("counter2:"+counter2.counter.ToString()+"\n");

            // counter1.AddOne();
            // Console.WriteLine("counter1:"+counter1.counter.ToString());
            // Console.WriteLine("counter2:"+counter2.counter.ToString());

           
           
            // apply Singlton  Make all object  point to the same istance address and update on its value
           
            // // Counter counter1 = Counter.GetInstance(); // return instance of the class
            // // Counter counter2 = Counter.GetInstance(); // return instance of the class
            // // counter1.AddOne();
            // // counter2.AddOne();

            // // Console.WriteLine("counter1:"+counter1.counter.ToString());
            // // Console.WriteLine("counter2:"+counter2.counter.ToString()+"\n");

            // // counter1.AddOne();
            // // Console.WriteLine("counter1:"+counter1.counter.ToString());
            // // Console.WriteLine("counter2:"+counter2.counter.ToString());

            // applying multi thread 
            // with out lock every task will create instance on memory and the counter will not be 2 on both write line
            // use lock to lock crating new object 
            Task task1=Task.Factory.StartNew(()=> {
                Counter counter1 = Counter.GetInstance(); // return instance of the class
                counter1.AddOne();
                Console.WriteLine("counter1:"+counter1.counter.ToString());

            });

            Task task2=Task.Factory.StartNew(()=> {
                Counter counter2 = Counter.GetInstance(); // return instance of the class
                counter2.AddOne();
                Console.WriteLine("counter2:"+counter2.counter.ToString());
                Console.WriteLine();
            });

            Console.ReadKey();
        }
    }
} 
