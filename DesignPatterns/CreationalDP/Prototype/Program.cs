// See https://aka.ms/new-console-template for more information
namespace DesignPatterns.Prototype
{
    public class Program
    {
        static void Main(string[] args)
        {
            // #region prototype
            EmployeePrototype tempEmp1 = new TempEmployee();
            tempEmp1.Id = 1;
            tempEmp1.Name = "temp employee 1";
            tempEmp1.EmpAddress = new Address{City="city 1",Building= "B1",StreetName="street nmae"};
            // apply prototype shalllow copy 
            EmployeePrototype tempEmp2 = tempEmp1.DeepCopy();
            Console.WriteLine("====== Temp Employee 1 Original Values =======");
            Console.WriteLine(tempEmp1.ToString()); 
            Console.WriteLine("====== Temp Employee 2 Copy ======="); 
            Console.WriteLine(tempEmp2.ToString()); 

            // try to hange on the  shallow copied values of temp2
            tempEmp2.EmpAddress.City = "new City";
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("====== Temp Employee 1 After Change =======");
            Console.WriteLine(tempEmp1.ToString()); 
            Console.WriteLine("====== Temp Employee 2  ======="); 
            Console.WriteLine(tempEmp2.ToString()); 


        }
    }
}