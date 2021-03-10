# Day 1 here we go!
class, abstract class, interface 

 [note that interface name usually starts with ‘I’ – it is a ‘rule of thumb’ in the programming art]
 
1. Class, abstract class, interface

To begin with, the idea of a ‘Class’ in OOP (C#) will be presented. ‘Class’ is (metaphorically speaking) a ‘template or a matrix’ used to create copies called ‘objects’ based on that template. ‘Classes’ have sets of different features shared with the class by all objects created.In ‘PolonezTemplate’ class we have 4 features. By creating an instances of class in ‘Program.cs’ we may latter print in the console all it’s parameters. To easily distinguish class between abstract class and interface the idea of abstraction in programming will be presented. 

‘Abstraction’ is an idea of creating classes that present only essential information to the user. Therefore, both ‘abstract classes’ and ‘interfaces’ are concepts that an object cannot be directly created from. That is the main difference from regular classes. However, they differ as well between each other in the level of abstraction. ‘Abstract class’ may consist of both abstract methods and regular ones, while ‘interface’ is all abstract. Moreover, interface can contain properties and methods, but not fields.
The examples present the difference. While ‘abstract class CarPrototype’ has both abstract method ‘SwitchTheLights()’ and defined non-abstract method ‘Go()’, ‘IConceptCar’ interface has only abstract methods – CarFunction() and CarFunctionTwo(). All the abstract methods need to be defined before creating an object. That is why we need to create a subclass to do so.
Both PolonezType and VolkswagenType inherit (‘:’) from abstract class CarPrototype, defining (we use a term ‘override’ in the program) the ‘SwitchTheLight()’ method (NOTE: each of the them do it differently!. Hence, the latter object creation in Program.cs is possible. So does the ‘CarImplementation’ class with interface ‘IConceptCar’. The difference is that there is no need for using 'override' keyword (it is only used in abstract classes)

NOTE: There is a difference in how the subclasses derivate from abstract classes and interfaces. ‘abstract classes’ are inherited, while ‘interfaces’ are implemented. Apart from terminology aspect it has strong developing consequances. In C# we do not have multi-inheritance (we may inherit only from one class) however we may have multi-implementation (a class may implement several interfaces and they are separated by commas). Such example is presented in the PlaneCarCross class. It implements two interfaces.

When to use abstract classes and interfaces?

Abstract class is always used as an base class. It supports abstract or virtual features, which the inherited classes should implement. Abstract class can declare fields. It is not possible to create an object of an abstract class. Interface may declare only properties, methods and events (without access modificators). We should always implement all declared fields and methods.  

First of all, for security of data and information that should be hidden before user. Secondly, multi-implementation lets us implement several interfaces to single class at once

Q1.Is there a method we cannot 'override'?

Yes, we use 'sealed' keyword in order to prevent the abstract method from being overridden. We may see it in “ProtectionFromOverrideClass”. Sealed keyword goes before the method F() name preventing it from being overridden in a derived class. F() is overridden once and F2() is overridden twice.

Q2. How to tell the difference between two interfaces which has the same methods and are implemented?
Example class TwinsImplementation shows the answer. We implement two interfaces (IFirstTwin,ISecondTwin) which have the same methods. To distinguish between them we need to “explicit interface implementation”. So we add the names of the interfaces before the methods they come from. Then we know which method we mean in each case. By doing so the methods are not public on the class. Therefore in order to access these methods, we have to first cast the object to the interface type, or assign it to a variable declared of the interface type. Method CastTheMethods() shows this casting procedure. 
Source: https://stackoverflow.com/questions/2371178/inheritance-from-multiple-interfaces-with-the-same-method-name

Q3. What is a difference between abstract and virtual function?
Abstract method cannot have a body. It must be overridden. Virtual method has some body. It may be overridden if its needed.

Q4. Can abstract class inherit from other abstract class?
Yes, it can. We can see it in AbstractClassSecond inheriting from AbstractClassFirst

Q5. Can abstract class have private methods?
Virtual and abstract methods cannot be private

Abstract class                                             	  

-fields	                                                         
-Not all members need to be abstract	                        
-Need for using override keyword	                          
-Can inherit other abstract class	                              
-Only one class can be inherited	                               
-Can implement interface	                                        
-Are ‘inherited’	                                                
-can contain virtual members                                     

VS

interface

-No fields
-All members are abstract
-No override keyword
-Can implement other interface
-Several interfaces can be implemented
-Cannot inherit classes
-Are ‘implemented’
-Cannot contain virtual members
