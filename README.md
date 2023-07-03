<h1>ZOO</h1>
<h4>This is a program divided into classes that is used to show a simple zoo UML diagram and show the inhertance and the diffrent kinds of classes and the polymorphism and also including the overriding for abstract and virtual classes so as you will see below the animal is the base class and also the abstract class for 7 classes that are also abstract classes:
  <h5>
  <ul>    
    
  1. Animal.
    
  2. Vertebrates.
     
  3. Inertebrates.
     
  4. Mammals.
     
  5. Reptiles.
     
  6. Birds.
      
  7. Arthopods.
  </ul></h5>
  Then this classes have classes under them as children for example Mammals is the parent for the Dolphin class (the Dolphin class is a concret class) other one Birds and Arthopods .</h4>

  <hr>
 <h2>UML DIAGREAM</h2> 
 
 ![Screenshot 2023-07-01 204634](https://github.com/bashar-27/lab06/assets/83985765/f1daf678-c3c3-4362-b2e6-dd3c9c398a2c)

 <hr>
 <h2>The 4 Concepts of OOP </h2>
 1. Encapsulation bundles data and methods into objects, enabling the object to control its own data while hiding implementation details from
      other parts of the program, promoting information hiding and data integrity.
 
 2. Inheritance allows subclasses to inherit properties and behaviors from a superclass, promoting code reuse and establishing hierarchical relationships. Subclasses can extend or modify inherited attributes and       
    methods as necessary. 

 3. Polymorphism enables objects of different classes to be treated as objects of a common superclass, allowing for flexible usage of a single interface or method. It can be achieved through method overriding and method overloading.

 4. Abstraction represents essential features without implementation details, enabling the creation of abstract classes or interfaces that define common behaviors. It helps manage complexity and promotes modular, scalable systems.

<hr>

<h2>This are some examples of usage of OOP principle in the code:</h2>

<h3>1. Inhertance With Dolphin Class:</h3> Inheritance: The Dolphin class inherits from the Mammals class. This implies that the Dolphin class inherits properties and behaviors from the Mammals class, establishing an inheritance relationship. The Dolphin class can access and modify the inherited properties and behaviors from the Mammals class.

<h3>2. Encapsoulation With Spider Class:</h3> Encapsulation: The Spider class encapsulates the data related to the spider's name, number of legs, venomous status, and nostril type. The properties Name, HasLegs, Venomous, and Nostrils are encapsulated within the class and can be accessed through public getter and setter methods.

<h3>3.Polymorphism with the Bird class:</h3>

* Birds is a superclass that defines common properties and behaviors of birds.

* Bird is a subclass of Bird and inherits its properties and behaviors.
 
* The object Falcon is created as an instance of Bird but is declared as Bird.
 
* Similarly to the Mammals example, even though b1 is declared as Bird, it can still access the overridden methods specific to Falcon
  <code> (Sleep() and Fly())</code>.
 
* This allows different types of birds to be treated uniformly as Bird while invoking their specific behaviors.

  <hr>
  <h1>New Update Lab07</h1>
  <h2>Interface :</h2>
  <p>In simplest terms, An Interface is like a Contract, where every member or component included in the body has to follow the contract, it defines what must be done.
    Always defined by the use of the keyword “interface”.
</p>

<h4>I provided  three interfaces: <code>Scales</code> ,<code>Attack</code> , and <code>Edible</code>. 

  1. Scales interface:
IsThereScale() method: This method returns a boolean value (bool) and indicates whether there are scales present. The exact implementation of this method will depend on the class that implements this interface. It is expected to provide logic to determine if there are scales or not.

  2. Attack interface:
IAttack() method: This method returns a string (string) and represents an attack action. The method is intended to define the behavior of an attack action. The implementation of this method will vary depending on the class that implements this interface. It could return a specific attack name, perform an attack calculation, or trigger any other desired action related to attacking.

  3. IsEdible() method: This method returns a string (string) and is used to determine if something is edible. The implementation of this method will depend on the class that implements this interface.
</h4>

<hr>

 <h2>NEW UML DIAGREAM</h2> 
 
![Screenshot 2023-07-03 185432](https://github.com/bashar-27/lab06/assets/83985765/16ceb4dc-94ca-423e-bdfb-feaa37a42a2f)

