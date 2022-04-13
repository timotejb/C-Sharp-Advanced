using SEDC.OOP.Class4.Extensions.Extensions;

string textToShorten = "Some string value";
Console.WriteLine(textToShorten.DeleteLastCharacter());

string textToQuote = "Text text text";
Console.WriteLine(textToQuote.AddQuotations());

List<string> list = new List<string>() { "First", "Second", "Third", "Fourth", "Fifth" };
list.PrintElements();