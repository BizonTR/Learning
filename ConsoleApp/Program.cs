using ClassLibrary1;
using System.Drawing;

Employee emp1 = new Employee();

emp1.Name = "Ahmet";
emp1.LastName = "Can";
emp1.Salary = 10000;

Console.WriteLine(emp1.FullName);
Console.WriteLine(emp1.Salary);
Console.WriteLine(emp1.Id);

Employee emp2 = new Employee();
emp2.FreeInfo = "Lorem Ipsum";
emp2.Id = "7492835605";
Console.WriteLine(emp2.FreeInfo);
Console.WriteLine(emp2.Id);

Employee emp3 = new Employee("Batu","Sutcu");
Console.WriteLine(emp3.FullName);
Console.WriteLine(emp3.Id); //bunu vermesek "Id not assigned." yazmasını bekledik ama yazmadı çünkü emp3 constructorlardan 2.sini çalıştırır çünkü 2 parametre verdik.
Console.WriteLine(emp3); // emp3 için yazılacak bir property vermezsek o classın namespace'i yazılır. Ama Employee.cs'deki 27. satırdaki override işleminden dolayı artık FullName yazar.

////////////// BOLUM 2 //////////////
Console.WriteLine("*******BOLUM 2*******");

var shape = new Shape() { X = 3, Y = 5 };
var rectangle = new ClassLibrary1.Rectangle() { X = 6, Y = 11 };
var triangle = new Triangle() { X = 55, Y = 6 };

var list = new List<Shape>() { shape, rectangle, triangle };

foreach (var item in list)
{
    item.Drawing();
}