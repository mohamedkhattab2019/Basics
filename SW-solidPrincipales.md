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
* one of the way to apply LSP is Virtual methode ij=n the parent class and override it on childrens.

## Interface Segregation Principles (ISP)
* Interface here mean is what client see and use.
* "Clients shouldn't be forced to debend on methodes they do not use." **it's some loke like SRP
* Avoid Fat interface 
* client mustn't implement unneces sary methods.
* Example : 
* let say we have interface has thre methods for order payment one for cash payment ,online payment ,and credit payment 
* when you proceed to create class implement one of the iterface methodes you must implement the three methods 
* so in the three classes you will repeate the thre implementation of interface methods .
* and if you add new methode to the interface e.g for installment payment 
* the old classes will have error as you have to implement the forth added method 
* so you will repeate the test process to the old classes and deploy it again
* **solution**:
* segregate the interface into more than one interface its methos is strongly related
* create three classes implement its related inerface 
* each class will only implement one methode in its extended interface 
* when you add new class you will not edit and testeing and deploy the old class
* also when you edit in the specifice interface (add nnew method) you will need only to implement on one class (clients)which extended it . 
* **if you need to implement case that you can use all payment method once**
*  

## Dependency Inversion Principle (DIP)
* Hiegh Levels modules should not deppend on low level modules.Both should depend upon abstractions.
* bad DIP show heigh coupling of heigh level 
* ***Solid principles and design patterns are both work to avoid coupling with code modules increase (cohision)***
*  invertion mean inverted dependency insteed of the hiegh level module  was depend on concrete class and verify 2 objects for two types of mail and two methods implement two object and that also **vaiolate OCP** as this hiegh class is open to modify if we add new mail type
* **solution** is to add abstraction class and the hiegh level depends on it and implement this class Imessage and the low levlel depends on the abstraction class to implement it methods.  
* after aply DIP low level becomes losely coupled with hiegh level moduels that means that the hiegh level will not affected by the modification on low level modules .

* Methodes of Dependency Injection Implementation :
  * Constructor injection : 
     * Create constructor on the Hiegh Levle module that get Imessage service as argument
     * in the calling of the hiegh level module on the main programe pass the low level class(Which impelement the middele layer) you want to implement
  * Methode injection : 
     * Make The Methode on the Hiegh Levle module get Imessage service as argument
     * in the calling of the hiegh level module on the main programe pass the low level class(Which impelement the middele layer)  you want to implement        To HL Methode
  * Prop. injection : 
     * create Property type IMessage (abstraction layer Interface) The Methode on the Hiegh Levle module implement (abstraction layer Interface) Method   
     * in the calling of the hiegh level module on the main programe inject yhe peoperty by the low level class(Which impelement the middele layer)  you        want to implement        To HL Methode
   
