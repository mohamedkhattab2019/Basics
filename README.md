# Basics

## OOP Basics 
## 1. What is OOP ?
* OOP standard for object oriented programing.
* procedural programing is about writing procedures or functios that perform operations on data , while OOP programing is about creating object conain both data and functions
* advantages :
   * OOP is faster and easier to execute 
   * OOP keep code dry **"Dont repeat your self"** 
   * code easier to maintain ,modify and debug 
## 2. What are Classes and Objects?
Classes and objects are the two main aspects of object-oriented programming.
![picture alt](https://cdn.shouts.dev/wp-content/uploads/2020/02/11223205/class-object-oop.png)

**So, a class is a template for objects, and an object is an instance of a class.
When the individual objects are created, they inherit all the properties and behaviors from the class, but each object will have different values for the properties.**

## 3.Define a Class:
Below we declare a class named Fruit consisting of two properties ($name and $color) and two methods set_name() and get_name() for setting and getting the $name property:


```PHP
<?php
class Fruit {
  // Properties
  public $name;
  public $color;

  // Methods
  function set_name($name) {
    $this->name = $name;
  }
  function get_name() {
    return $this->name;
  }
}


?>
 ```
 ## 4.Define Objects
 In the example below, $apple and $banana are instances of the class Fruit:
 ```PHP
<!DOCTYPE html>
<html>
<body>

 <?php
class Fruit {
 // Properties
 public $name;
 pulic $color;

 // Methods
 function set_name($name) {
   $this->name = $name;
 }
 function get_name() {
   return $this->name;
 }
 function set_color($color){
 $this->color=$color;
 }
 function get_color()
 {
   return $this->color;
 }
 }
// objects 
$apple = new Fruit();
$mozaa = new Fruit();
$apple->set_name('Apple');
$mozaa->set_name('mozaa');
$apple->set_color('red');
$mozaa->set_color('yellow');




echo "fruit name is ".$apple->get_name()." its color is ". $apple-> get_color();
echo "<br>";
echo "fruit name is ".$mozaa->get_name()." its color is ". $mozaa-> get_color();
?> 
 
</body>
</html>

 ```
 #### The $this Keyword
 * The $this keyword refers to the current object, and is only available inside methods.
  * So, where can we change the value of the $name property? There are two ways:

  1. Inside the class (by adding a set_name() method and use $this):
```PHP
<?php
class Fruit {
  public $name;
  function set_name($name) {
    $this->name = $name;  // **set the  object property name to the value passed to methode set_name()**
  }
}
$apple = new Fruit();
$apple->set_name("Apple");

echo $apple->name;
?> 
```
  2. Outside the class (by directly changing the property value):
```PHP
 <?php
class Fruit {
  public $name;
}
$apple = new Fruit();
$apple->name = "Apple";

echo $apple->name;
?> 
```

#### PHP - instanceof

You can use the instanceof keyword to check if an object belongs to a specific class:

```PHP
<?php
class Fruit {
  // Properties
  public $name;
  public $color;

  // Methods
  function set_name($name) {
    $this->name = $name;
  }
  function get_name() {
    return $this->name;
  }
}

$apple = new Fruit();
var_dump($apple instanceof Fruit);  // must return true if appleis instance of exist class called fruit
?>
 
```

## 5.PHP OOP - Constructor
* PHP - The __construct Function

* A constructor allows you to initialize an object's properties upon creation of the object.

* If you create a __construct() function, PHP will automatically call this function when you create an object from a class.
* **that using a constructor saves us from calling the set_name() method which reduces the amount of code:**
```PHP
 <?php
class Fruit {
  public $name;
  public $color;

  function __construct($name, $color) {
    $this->name = $name;
    $this->color = $color;
  }
  function get_name() {
    return $this->name;
  }
  function get_color() {
    return $this->color;
  }
}

$apple = new Fruit("Apple", "red");
echo $apple->get_name();
echo "<br>";
echo $apple->get_color();
?> 
```

## 6.PHP OOP - Destructor
* PHP - The __destruct Function

* A destructor is called when the object is destructed or the script is stopped or exited.* 

* If you create a __destruct() function, PHP will automatically call this function at the end of the script.

```PHP
 <?php
class Fruit {
  public $name;
  public $color;

  function __construct($name, $color) {
    $this->name = $name;
    $this->color = $color;
  }
  function __destruct() {
    echo "The fruit is {$this->name} and the color is {$this->color}.";
  }
}

$apple = new Fruit("Apple", "red");
?> 
```
## 7.PHP OOP - Access Modifiers
* PHP - Access Modifiers

* Properties and methods can have access modifiers which control where they can be accessed.

* There are three access modifiers:

   * public - the property or method can be accessed from everywhere. This is default
   * protected - the property or method can be accessed within the class and by classes derived from that class
   * private - the property or method can ONLY be accessed within the class

* **In the following example we have added three different access modifiers to three properties (name, color, and weight).**
```PHP
 <?php
class Fruit {
  public $name;
  protected $color;
  private $weight;
}

$mango = new Fruit();
$mango->name = 'Mango'; // OK
$mango->color = 'Yellow'; // ERROR
$mango->weight = '300'; // ERROR
?> 
```
* **In the next example we have added access modifiers to two functions.**
 
```PHP
 <?php
class Fruit {
  public $name;
  public $color;
  public $weight;

  function set_name($n) {  // a public function (default)
    $this->name = $n;
  }
  protected function set_color($n) { // a protected function
    $this->color = $n;
  }
  private function set_weight($n) { // a private function
    $this->weight = $n;
  }
}

$mango = new Fruit();
$mango->set_name('Mango'); // OK
$mango->set_color('Yellow'); // ERROR
$mango->set_weight('300'); // ERROR
?> 
```

## 8.PHP - What is Inheritance?
* **when class derives from another class**
* The child class will inherit all the public and protected properties and mrthods from parent class. In addition it can have its own properties and methodes 
*  An inherited class is defined by using the **extends** keyword.
**Example :
  
```PHP
<?php
class Fruit {
  public $name;
  public $color;
  public function __construct($name, $color) {
    $this->name = $name;
    $this->color = $color; 
  }
  public function intro() {
    echo "The fruit is {$this->name} and the color is {$this->color}."; 
  }
}

// Strawberry is inherited from Fruit
class Strawberry extends Fruit {
  public function message() {
    echo "Am I a fruit or a berry? "; 
  }
}

$strawberry = new Strawberry("Strawberry", "red");
$strawberry->message();
$strawberry->intro();
?>
```
**Explanation :
This means that the Strawberry class can use the public $name and $color properties as well as the public __construct() and intro() methods from the Fruit  class because of inheritance. The Strawberry class also has its own method: message().


### PHP - Inheritance and the Protected Access Modifier
* **Protected** prop or methods can accessed only by the class it self and by classes drived from that class
```PHP
<?php
class Fruit {
  public $name;
  public $color;
  public function __construct($name, $color) {
    $this->name = $name;
    $this->color = $color; 
  }
  protected function intro() {
    echo "The fruit is {$this->name} and the color is {$this->color}."; 
  }
}

class Strawberry extends Fruit {
  //public function message() {
  //  echo "Am I a fruit or a berry? ";
    // Call protected function from within derived class - OK 
  //  $this -> intro();
  //}
  function __destruct(){
    echo "Am I a fruit or a berry? ";
    // Call protected function from within derived class - OK 
    $this -> intro();
  }
}
$strawberry = new Strawberry("Strawberry", "red");  // OK. __construct() is public
//$strawberry->message(); // **OK**. message() is public and it calls intro() (which is protected) from within the derived class
//$strawberry->intro(); //  ERROR . intro() is protected  can't be used oytsude clase or drived class from it 
?>
```

```diff
- $strawberry->intro(); //  ERROR . intro() is protected  can't be used oytsude clase or drived class from it
+ $this -> intro();   // Call protected function from within derived class - OK 
```

### PHP - Overriding Inherited Methods

* Inherited methods can be overridden by redefining the methods (use the same name) in the child class.
* **The __construct() and intro() methods in the child class (Strawberry) will override the __construct() and intro() methods in the parent class (Fruit):**
```PHP
<?php
class Fruit {
  public $name;
  public $color;
  public function __construct($name, $color) {
    $this->name = $name;
    $this->color = $color; 
  }
  public function intro() {
    echo "The fruit is {$this->name} and the color is {$this->color}."; 
  }
}

class Strawberry extends Fruit {
  public $weight;
  public function __construct($name, $color, $weight) {
    $this->name = $name;
    $this->color = $color;
    $this->weight = $weight; 
  }
  public function intro() {
    echo "The fruit is {$this->name}, the color is {$this->color}, and the weight is {$this->weight} gram."; 
  }
}

$strawberry = new Strawberry("Strawberry", "red", 50);
$strawberry->intro();
?>
```


### PHP - The final Keyword
* The ***final*** keyword can be used to prevent class inheritance or to prevent method overriding.
*   The following example shows how to prevent class inheritance:
```PHP
 <?php
final class Fruit {
  // some code
}

// will result in error
class Strawberry extends Fruit {
  // some code
}
?> 
```
this code Run result :
```diff
- PHP Fatal error: Class Strawberry may not inherit from final class (Fruit) in /home/o6MTL0/prog.php on line 10 
```
* The following example shows how to prevent method overriding:
```PHP
 <?php
class Fruit {
  final public function intro() {
    // some code
  }
}

class Strawberry extends Fruit {
  // will result in error
  public function intro() {
    // some code
  }
}
?> 
```

## 9.PHP OOP - Class Constants
* constatnt canot be changed once it's declared
* Class constants are case-sensitive. However, it is recommended to name the constants in all uppercase letters.
* We can access a constant from outside the class by using the class name followed by the scope resolution operator (::) followed by the constant name, like here:
```PHP
<?php
class Goodbye{
  const LEAVING_MESAGE = "Thank you for visiting khattab.com!";
}
 // access Constant variable
echo Goodbye::LEAVING_MESAGE;
?>
```
* Or, we can access a constant from inside the class by using the self keyword followed by the scope resolution operator (::) followed by the constant name, like here:

```PHP
 <?php
class Goodbye {
  const LEAVING_MESSAGE = "Thank you for visiting W3Schools.com!";
  public function byebye() {
    echo self::LEAVING_MESSAGE;
  }
}

$goodbye = new Goodbye();
$goodbye->byebye();
?> 
```
## 10.PHP OOP - Abstract Classes
* Abstract classes and methods are when the parent class has a named method, but need its child class(es) to fill out the tasks.
* An abstract class is a class that contains at least one abstract method. An abstract method is a method that is declared, but not implemented in the code.
**Syntax**
 ```PHP
  <?php
 abstract class ParentClass {
  abstract public function someMethod1();
  abstract public function someMethod2($name, $color);
  abstract public function someMethod3() : string;
}
?> 
```
* When inherting from abstract class, 
  * the child class method must be defined with the same name.
  * the same or less restricted access modifier    abstract method (protected)  -> Child class (protected or public not private).
  * The number of required arguments must be the same. However, the child class may have optional arguments in addition.
**Example1**
```PHP
<?php
// Parent class
abstract class Car {
  public $name;
  public function __construct($name) {
    $this->name = $name;
  }
  abstract public function intro() : string; 
}

// Child classes
class Audi extends Car {
  public function intro() : string {
    return "Choose German quality! I'm an $this->name!"; 
  }
}

class Volvo extends Car {
  public function intro() : string {
    return "Proud to be Swedish! I'm a $this->name!"; 
  }
}

class Citroen extends Car {
  public function intro() : string {
    return "French extravagance! I'm a $this->name!"; 
  }
}

// Create objects from the child classes
$audi = new audi("Audi");
echo $audi->intro();
echo "<br>";

$volvo = new volvo("Volvo");
echo $volvo->intro();
echo "<br>";

$citroen = new citroen("Citroen");
echo $citroen->intro();
?>
```

**Example2**


```PHP 
<?php
abstract class ParentClass {
  // Abstract method with an argument
  abstract protected function prefixName($name);
}

class ChildClass extends ParentClass {
// public prefixName func less restricted 
  public function prefixName ($name)
  {
    if ($name == "John Doe")
    {
      $prefix = "Mr.";
    }
    else if ($name == "Jane Doe")
    {
      $prefix = "Mrs.";
    }
    else
    {
      $prefix = ""; 
    }
    return "{$prefix} {$name}";
  }
}

$object = new ChildClass();
echo $object ->prefixName("John Doe");
echo "<br>" ;
echo $object ->prefixName("Jane Doe");

?>
```
**Example3**

* ***Let's look at another example where the abstract method has an argument, and the child class has two optional arguments that are not defined in the parent's abstract method:***

```PHP
<?php
abstract class ParentClass {
  // Abstract method with an argument
  abstract protected function prefixName($name);
}

class ChildClass extends ParentClass {
  // The child class may define optional arguments that is not in the parent's abstract method
  public function prefixName($name, $separator = ".", $greet = "Dear") {
    if ($name == "John Doe") {
      $prefix = "Mr";
    } elseif ($name == "Jane Doe") {
      $prefix = "Mrs";
    } else {
      $prefix = "";
    }
    return "{$greet} {$prefix}{$separator} {$name}";
  }
}

$class = new ChildClass;
echo $class->prefixName("John Doe");
echo "<br>";  
echo $class->prefixName("Jane Doe");
echo "<br>";
// arguments optional can be assigned or not
echo $class->prefixName("John Doe","/","Sir");
echo "<br>";  
echo $class->prefixName("Jane Doe","*","Sonson");
?>
 
```
## PHP - What are Interfaces?

* Interfaces allow you to specify what methods a class should implement.
* Interfaces make it easy to use a variety of different classes in the same way. When one or more classes use the same interface, it is referred to as "polymorphism".
* ***Syntax***
```PHP
 <?php
interface InterfaceName {
  public function someMethod1();
  public function someMethod2($name, $color);
  public function someMethod3() : string;
}
?> 
```
***comparison***
|Interfaces|Abstract classes|
|--------- |----------------|
|cannot have properties|can have properties|
|All interface methods must be public|abstract class methods is public or protected|
|All methods in an interface are abstract, so they cannot be implemented in code and the abstract keyword is not necessary||
|Classes can implement an interface while inheriting from another class at the same time||

**Example1**
```PHP
 <?php
// Interface definition
interface Animal {
  public function makeSound();
}

// Class definitions
class Cat implements Animal {
  public function makeSound() {
    echo " Meow ";
  }
}

class Dog implements Animal {
  public function makeSound() {
    echo " Bark ";
  }
}

class Mouse implements Animal {
  public function makeSound() {
    echo " Squeak ";
  }
}

// Create a list of animals
$cat = new Cat();
$dog = new Dog();
$mouse = new Mouse();
$animals = array($cat, $dog, $mouse);

// Tell the animals to make a sound
foreach($animals as $animal) {
  $animal->makeSound();
}
?> 
```
>>From the example above, let's say that we would like to write software which manages a group of animals. There are actions that all of the animals can do, but each animal does it in its own way.

