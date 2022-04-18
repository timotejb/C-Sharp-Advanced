List<int> intList = new List<int> { 12, 32, 3, 4, 15, 16, 7, 8, 49, 10 };
var LargerThan = intList.Where(IsLargerThan10).ToList();

//LargerThan.ForEach(number => Console.WriteLine(number));

static bool IsLargerThan10(int number)
{
    return number > 10;
}

List<string> stringList = new List<string> { "12", "6", "23", "5", "44", "8", "15", "timotej" };
List<int> convertedStringList = stringList.Select ((stringNumber) =>
{
    int number = 0;
    int.TryParse(stringNumber, out number);
    return number;
}).ToList();
convertedStringList.ForEach(number => Console.WriteLine(number));