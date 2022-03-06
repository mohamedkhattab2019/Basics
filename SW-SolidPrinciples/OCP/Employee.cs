using solidConsoleDemo;
namespace solidConsoleDemo
{
    public abstract class Employee  // closed for change 
    {
        public string ID{get;set;}
        public string Name{get;set;}
        public decimal BasicSalary{get;set;}

    // assume we need to modify in CalcHoursBouns based on the job title level
        public string empType{get;set;}

        // before doing any thing the methode was :
        // public decimal CalcHoursBouns(decimal hours)
        // {
        //     return ((BasicSalary/30)/8)*hours;  
        // }


        // after modification which is violate OCP Priciple
        //  public decimal CalcHoursBouns(decimal hours)
        // {
        //     if (empType =="Manager"){return (((BasicSalary/30)/8)*hours*2);}
        //     else {return ((BasicSalary/30)/8)*hours;} 
        // }

        // after adding abstract 

        public abstract  decimal CalcHoursBouns(decimal hours); // closed for change


        public override string ToString()
        {
            return $"Emplyee Id : {ID}, Name : {Name}";
        }

    }
    /*
        For any new feature depend on method in the class
        you can create new class extends from the general abstract class
        with new emlemenation to the method
        which is easy to add feature and eas Teasting Opertation 
    */

    // --------------------- abstract Implementation ----------------------//
    // public class Manager : Employee
    // {
    //     public override decimal CalcHoursBouns(decimal hours)
    //     {
    //         return ((BasicSalary/30)/8)*hours*2;  
    //     }
    // }
    // public class RegularEmp : Employee
    // {
    //     public override decimal CalcHoursBouns(decimal hours)
    //     {
    //         return ((BasicSalary/30)/8)*hours;  
    //     }

        
    // }

    // ----------------------Interface implementaio-------------//
    public class Manager : IEmpoyee
    {
        public string ID{get;set;}
        public string Name{get;set;}
        public decimal BasicSalary{get;set;}
        
        public  decimal CalcHoursBouns(decimal hours)
        {
            return ((BasicSalary/30)/8)*hours*2;  
        }

         public override string ToString()
        {
            return $"Emplyee Id : {ID}, Name : {Name}";
        }
    }
    public class RegularEmp : IEmpoyee
    {
        public string ID{get;set;}
        public string Name{get;set;}
        public decimal BasicSalary{get;set;}
        
        public  decimal CalcHoursBouns(decimal hours)
        {
            return ((BasicSalary/30)/8)*hours;  
        }

         public override string ToString()
        {
            return $"Emplyee Id : {ID}, Name : {Name}";
        }

        
    }

}