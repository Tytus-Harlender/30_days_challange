# 30_days_challange
a 30 days challenge 

DISCRIPTION TO DAY 1

3 following programming concepts and the comparison between them will be discussed – a class, abstract class and interface. The folder consists of two files ‘Program.cs’ and ’Day1.cs’. ‘Program.cs’ is where method for executing the classes instances and printing it’s properties is placed. ’Day1.cs’ is where all the examples of classes, abstract classes and instances are placed and these will be further explained. The names of each was picked up to fit the abstraction level lurking behind. ‘PolonezTempleate’ indicate is ready-to-use (to create objects) template (class). ‘CarPrototype’ shows that is not yet ready prototype that needs some of its features to be defined (abstract class). ‘IConceptCar’ shows that its just a concept and needs all its features to be defined (interface) [note that interface name usually starts with ‘I’ – it is a ‘rule of thumb’ in the programming art]
 
To begin with, the idea of a ‘Class’ in OOP (C#) will be presented. ‘Class’ is (metaphorically speaking) a ‘template or a matrix’ used to create copies called ‘objects’ based on that template. ‘Classes’ have sets of different features that all objects created with the class share. 


In our file ’Day1.cs’ we may see a class ‘PolonezTemplate’ which has 4 features. By creating an instances of class in ‘Program.cs’ we may latter print in the console all it’s parameters.
To easily distinguish class between abstract class and interface the idea of abstraction in programming will be presented. ‘Abstraction’ is an idea of creating classes that present only essential information to the user. Therefore, both ‘abstract classes’ and ‘interfaces’ are concepts that an object cannot be directly created from. That is the main difference from regular classes. However, they differ as well between each other in the level of abstraction. ‘Abstract class’ may consist of both abstract methods and regular ones, while ‘interface’ is all abstract. Moreover, interface can contain properties and methods, but not fields.
The examples in ‘Day1.cs’ file present the difference. While ‘abstract class CarPrototype’ has both abstract method ‘SwitchTheLights()’ and defined non-abstract method ‘Go()’, ‘IConceptCar’ interface has only abstract methods – CarFunction() and CarFunctionTwo(). All the abstract methods need to be defined before creating an object. That is why we need to create a subclass to do so.
Both PolonezType and VolkswagenType inherit (‘:’) from abstract class CarPrototype, defining (we use a term ‘override’ in the program) the ‘SwitchTheLight()’ method (NOTE: each of the them do it differently!. Hence, the latter object creation in Program.cs is possible. So does the ‘CarImplementation’ class with interface ‘IConceptCar’. The difference is that there is no need for override

NOTE: There is a difference in how the subclasses derivate from abstract classes and interfaces. ‘abstract classes’ are inherited, while ‘interfaces’ are implemented. Apart from terminology aspect it has strong developing consequances. In C# we do not have multi-inheritance (we may inherit only from one class) however we may have multi-implementation (a class may implement several interfaces and they are separated by commas). Such example is presented in the PlaneCarCross class. It implements two interfaces.

When to use abstract classes and interfaces? First of all, for security of data and information that should be hidden before user. Secondly, multi-implementation lets us implement several interfaces to single class


