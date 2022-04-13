
using SEDC.OOP.Class4.Generics.Enteties;

//GenericMethods genericMethods = new GenericMethods();

//genericMethods.PrintObject<string>("Zdravo");
//genericMethods.PrintObject<DateTime>(DateTime.Now);
//genericMethods.PrintObject<int>(34);
/*
NonGenericHelper Helper = new NonGenericHelper();

List<string> stringList = new List<string> { "Hello", "World", "GENERIC", "Methods" };
List<int> intList = new List<int>() { 1, 2, 3, 4, 5 };


Helper.GetInfoForList(stringList);
Helper.GoThroughStringLIst(stringList);

Helper.GetInfoForIntegerList(intList);
Helper.GoThroughIntegerLIst(intList);

Console.WriteLine("==========================================");

GenericHelper GenericHelper = new GenericHelper();
GenericHelper.GetInfoForList(stringList);
GenericHelper.GoThroughList(stringList);

GenericHelper.GetInfoForList(intList);
GenericHelper.GoThroughList(intList);
*/
GenericClass<double> genericClass = new GenericClass<double>(3.5);
genericClass.PrintPropertyTypeAndValue();

GenericClass<bool> genericBool = new GenericClass<bool>(true);
genericBool.PrintPropertyTypeAndValue();

GenericClass<decimal> genericDecimal = new GenericClass<decimal>(0.8m);
genericDecimal.PrintPropertyTypeAndValue();

GenericDB<Product> productDB = new GenericDB<Product>();
productDB.AddItem(new Product { Id = 1, Title = "Book", Description = "Paper Book"});
productDB.AddItem(new Product { Id = 3, Title = "Computer", Description = "PersonalComputer" });

GenericDB<Order> orderDB = new GenericDB<Order>();
orderDB.AddItem(new Order { Id = 4, Address = "Blablabla", Product = new Product { Id = 10, Title = "Book", Description = "Paper Book" } });
orderDB.AddItem(new Order { Id = 5, Address = "Blablabla", Product = new Product { Id = 20, Title = "Computer", Description = "PersonalComputer" } });

//productDB.PrintInfo();
//orderDB.PrintInfo();

Product productForDeleting = new Product() { Id = 120, Title = "Book3", Description = "3TATA KNIGA" };
productDB.AddItem(productForDeleting);
productDB.PrintInfo();

productDB.DeleteItem(productForDeleting);
productDB.PrintInfo();

