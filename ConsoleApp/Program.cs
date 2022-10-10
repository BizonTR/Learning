using ClassLibrary1;

Employee emp1 = new Employee();

emp1.Name = "Ahmet";
emp1.LastName = "Can";
emp1.Salary = 10000;

Console.WriteLine(emp1.FullName);
Console.WriteLine(emp1.Salary);

Employee emp2 = new Employee();
emp2.FreeInfo = "Lorem Ipsum";
Console.WriteLine(emp2.FreeInfo);

