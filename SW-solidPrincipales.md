# software **solid** principales
The SOLID Principles are five principles of Object-Oriented class design. They are a set of rules and best practices to follow while designing a class structure.
**They all serve the same purpose:
"To create understandable, readable, and testable code that many developers can collaboratively work on."**

* The Single Responsibility Principle
* The Open-Closed Principle
* The Liskov Substitution Principle
* The Interface Segregation Principle
* The Dependency Inversion Principle
* 
## single responsibality principal (SRP)
* "Do one thing and do it well" class , module or any code.  
* Uncle Bob, "There should never be more than one reason for class change".
* A class should have one and only one reason to change, meaning thay a slass should have only one job. 
* Following the Single Responsibility Principle is important. 
  1. First of all, because many different teams can work on the same project and edit the same class for different reasons, this could lead to **incompatible modules**
  2. it makes version control easier. For example, say we have a persistence class that handles database operations, and we see a change in that file in the GitHub commits.
     By following the SRP, we will know that it is related to storage or database-related stuff.
  3. Merge conflicts.They appear when different teams change the same file.
     But if the SRP is followed, fewer conflicts will appear – files will have a single reason to change, and conflicts that do exist will be 
  
## Open-Closed Principle (OCP)
 * **software entities (classes,modules,functions,etc.) should be open for extension, but closed for modification.**
 * Any new functionality should be done by adding new class instead of changeing existing one.
 * How to apply :
    1. using abstract class **Abstract classes and methods are when the parent class has a named method, but need its child class(es) to fill out the tasks.**
    2. using interface      **When one or more classes use the same interface, it is referred to as "polymorphism"**.

## Liskov Substitution Principle (LSP)
* The Liskov Substitution Principle states that subclasses should be substitutable for their base classes
* if you have class ***B*** inherits from class ***A***   then class ***A*** should be 
  replaceable by class ***B*** with out anychanges"
  A obiectA = new B();
   
