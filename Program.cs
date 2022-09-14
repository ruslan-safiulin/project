Console.Clear();
var arr = new string[] { ":)", "Hello", "Kazan", "Rus", "Tommy", "12" };
 
string[] group = Array.FindAll(arr, str => str.Length <= 3);
foreach (var str in group) Console.Write($"{str} ");
Console.WriteLine();