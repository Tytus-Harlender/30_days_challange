#Day6

#region – partial keyword – single responsibility class – SOLID

1.	#region
Regions are a way to organize the development side of your project to make it more easy to navigate in the code. Regions make it more readable for foreign user or even another developer that has not seen your code before. The basic idea behind it is to devide the lines in different functional parts with various names depending what the aim of a part is. The example of #region usage is shown in RegionExample class. As we create region by ’# region Fields’ phrase, the ‘Fields’ is the name of a section. Then goes all the code within the region. At the end we put #endregion word to close the region. After that we may see that a toggle button on the left has appeared giving us the possibility to fold and unfold the region.

Source:
https://www.c-sharpcorner.com/article/using-regions-to-improve-code-readability/
https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/preprocessor-directives/preprocessor-region

2.	Partial keyword

Partial keyword is used to define only a part of a class/struct/interface/method. As a result if we discuss ‘partial class’ for example, we may have several classes (each partial) that all together define the whole functionality of a class. Each ‘part’ needs to be defined with partial keyword directly before ‘class’ word. The PartialExample class shows the usage described above

When to use?

-in large projects to organize the work and let the programmers work on a specific part of functionality
-when we want to modify a source-generated code without changing anything directly in the file. Instead we may create separate file that will add a new functionality

Source:
https://www.dotnetperls.com/partial
https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/partial-classes-and-methods

3.	Single responsibility class


