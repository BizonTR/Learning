using ClassLibrary1;

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

