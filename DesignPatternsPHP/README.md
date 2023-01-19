# Basics
## Design Patterns
### Creational patterns
provide object creation mechanisms that increase flexibility and reuse of existing code.
#### Factory Method
Factory Method is a creational design pattern that provides an interface for creating objects in a superclass, but allows subclasses to alter the type of objects that will be created.

* problem:
Imagine that you’re creating a logistics management application. The first version of your app can only handle transportation by trucks, so the bulk of your code lives inside the Truck class.Adding Ships into the app would require making changes to the entire codebase.
<table> 
<tr>
    <td><b style="font-size:30px">Title</b></td>
    <td><b style="font-size:30px">Pseudocode</b></td>
 </tr>
 <tr>
 <td> 

 ![image desc](https://refactoring.guru/images/patterns/diagrams/factory-method/example.png)
 
</td>
    <td>
    
![image desc](./factoryMethodStructure.png) 
Factory Method can be used for creating cross-platform UI elements without coupling the client code to concrete UI classes
    </td>
 </tr>
 </table>