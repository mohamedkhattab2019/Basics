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
*  **Example :
  
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


## 8.PHP - Inheritance and the Protected Access Modifier
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
//$strawberry->intro(); // **ERROR**. intro() is protected  can't be used oytsude clase or drived class from it 
?>
```
