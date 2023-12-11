// See https://aka.ms/new-console-template for more information
using System.Diagnostics;

WorkingWithDataTypes();
ConversionOfTypes();
WorkingWithArrays();
WorkingWithCollections();
void WorkingWithDataTypes()
{
    Console.WriteLine("Hello, World!");
    //Working with datatypes
    int num1 = 100;
    int num2 = 100;
    Console.WriteLine("Sum = " + (num1 + num2));

    //Declaration - alternte way
    var num3 = 200;
    var formattedFloat = 200f;
    var formattedDouble = 200d;
    var formattedDecimal = 200m;
    Console.WriteLine(num3.GetType().Name);
    Console.WriteLine(formattedFloat.GetType().Name);
    Console.WriteLine(formattedDouble.GetType().Name);
    Console.WriteLine(formattedDecimal.GetType().Name);

    //Concatenation using String Interpolation: $
    Console.WriteLine($"The datatype of num3 is {num3.GetType().Name}");

    //other types
    bool isEverythingOk = true;
    string greetMessage = "Hello welcome to C# training session";
    char iamSingle = 'S';

    Console.WriteLine($"Value of {nameof(isEverythingOk)}is{isEverythingOk}");
}

void ConversionOfTypes()
{
    int num1 = 100;
    double num2 = 100;
    bool isEverythingOk = true;
    string str = "Hello";
    string strNum = "100";

    var result1 = (double)num1;
    var result2 = (int)num2;
    //var result3 = ()isEverythingOk; //string on heap & bool on stack. Hence error is casting

    var convert1 = Convert.ToString(num1);
    var convert2 = Convert.ToInt32(strNum);
}

void WorkingWithArrays()
{
    int[] arr = new int[3];
    arr[0] = 10;
    arr[1] = 20;
    arr[2] = 30;
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Value of item: {arr[i]}");
    }

    string[] greetings = { "Namaste", "Hello", "Hola" };

    int counter = 0;
    while (counter < greetings.Length)
    { 
        Console.WriteLine($"A new way to Greet: {greetings[counter]}");
        counter++;
    }
    int[] evens = { 2, 4, 6, 8, 10 };
    counter = 0;
    do
    {
        Console.WriteLine($"The next even number : {evens[counter]}");
        counter++;
    } while (counter == evens.Length);
    object[] objArray = { 100, "Ok", new int[] { 1, 2, 3 } };

    foreach (var item in (Int32[])objArray[2])
    {
        Console.WriteLine(item);
    }
}

void WorkingWithCollections()
{
    List<string> shoppingList = new List<string>();
    Console.WriteLine($"Total items in shopping bag: {shoppingList.Count()}");
    shoppingList.Add("bags");
    Log(new object[] { "Item added: ", shoppingList[0] });
    shoppingList.Add("Dresses");
    Log(new object[] { "Item added: ", shoppingList[1] });
    shoppingList.Add("Accessories");
    Log(new object[] { "Item added: ", shoppingList[2] });
    shoppingList.Add("Shoes");
    Log(new object[] { "Item added: ", shoppingList[3] });
    PrintValues(shoppingList);
    Console.WriteLine($"Total items in shopping bag: {shoppingList.Count()}");
    shoppingList.Remove("Shoes");
    Log(new object[] { "Item removed: ", "shoes" });
    PrintValues(shoppingList);
    Console.WriteLine($"Total items in shopping bag: {shoppingList.Count()}");
    Print(new object[] { "Comma-separated values of the shopping list", 
                          shoppingList[0], 
                          shoppingList[1], 
                          "\n The total count of items is: ", 
                          shoppingList.Count() });
}

void Log<T>(T[] pValues)
{
    string result = "";
    foreach (var item in pValues)
    {
        result = $"{result} {item}";
    }

    var finalResult = $"[ {DateTime.Now.ToString()} ] : {result}";
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("----------");
    Console.WriteLine(finalResult);

    Debug.WriteLine("----LOG----");
    Debug.WriteLine(finalResult);
}
    

void PrintValues<T>(List<T> pCollection)
{
    foreach (var item in pCollection)
    {
        Console.WriteLine(item);
    }
}

void Print(object[] pValues)
{
    string result = "";
    foreach (var item in pValues)
    {
        result = $"{result},{item}";
    }
    result = result.TrimStart(',');
    Console.WriteLine(result);

}

class utils
{

}