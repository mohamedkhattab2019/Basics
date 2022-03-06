// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace solidConsoleDemo
{
    class Program
    {

        static void Main(string[] aargs)
        {
            // Employee Emp1    = new Employee();
            // Emp1.Name        = "mohamed Khattab" ;
            // Emp1.ID          = "2019";
            // Emp1.BasicSalary = 900;     
            // Emp1.empType     = "Manager";

            // Employee Emp2    = new Employee();
            // Emp2.Name        = "Khattab" ;
            // Emp2.ID          = "2020";
            // Emp2.BasicSalary = 900;     
            // Emp2.empType     = "regulr";

            Manager Emp1    = new Manager();
            Emp1.Name        = "mohamed Khattab" ;
            Emp1.ID          = "2019";
            Emp1.BasicSalary = 900; 

            RegularEmp Emp2    = new RegularEmp();
            Emp2.Name        = "Khattab" ;
            Emp2.ID          = "2020";
            Emp2.BasicSalary = 900;    

            Console.WriteLine(Emp1.ToString()
                            + Environment.NewLine
                            + "Bouns :" + Emp1.CalcHoursBouns(5).ToString() +"\n"
                            + Emp2.ToString()
                            + Environment.NewLine
                            + "Bouns :" + Emp2.CalcHoursBouns(5).ToString()
                            );
        }
    }
        
}
