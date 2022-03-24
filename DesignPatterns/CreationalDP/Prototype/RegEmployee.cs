namespace DesignPatterns.Prototype
{
    public class RegEmployee : EmployeePrototype {
        public override EmployeePrototype ShallowCopy()
        {
            // built in methode make shallow copy
            // return object so you need to cast it 
            return (RegEmployee) this.MemberwiseClone();    
            
        }
        public override EmployeePrototype DeepCopy()
        {
            // new copies of evry thing
            // new copy of Regular employee 
            // new copy of Address class
            RegEmployee emp = new RegEmployee ();
            emp = (RegEmployee) this.MemberwiseClone();
            emp.EmpAddress  = new Address {
                Building    = EmpAddress.Building,
                StreetName  = EmpAddress.StreetName,
                City        = EmpAddress.City
            };
            emp.Name = this.Name;
            return emp;
        }
    }
}