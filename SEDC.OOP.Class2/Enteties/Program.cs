using Enteties;
using Enteties.Interfaces;
//Employee employee = new Employee(1, "Trajko", "Trajkov", 40);
//Person admin = new Admin(2, "Petko", "Petkov", "HR");

//Console.WriteLine(employee.GetInfo());
//Console.WriteLine(admin.GetInfo());

//Figure square = new Square(4);
//Console.WriteLine(square.Area());

//Console.WriteLine();

//Figure circle = new Circle(5);
//Console.WriteLine(circle.Area());

IDeveloper developer = new Developer();
Tester tester = new Tester();

developer.Code();
tester.Code();
tester.TestCode();