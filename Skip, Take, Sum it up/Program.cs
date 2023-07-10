using System.Linq;

List<double> listOfnumbersDouble = new(){34.3, 24.13, 47.3, 5.8, 35.52, 25.71, 75.2, 24.0};

Console.WriteLine("sto stampano gli elementi della lista:");
foreach(var number in listOfnumbersDouble)
{
    Console.WriteLine(number);
}

Console.WriteLine("il numero degli elementi è: " + listOfnumbersDouble.Count);
Console.WriteLine("inserisci il numero per saltare gli elementi");
int input1 = int.Parse(Console.ReadLine());
Console.WriteLine("inserisci il numero per prendere gli elementi");
int input2 = int.Parse(Console.ReadLine());

var newList = listOfnumbersDouble.Skip(input1).Take(input2);

var sum = newList.Sum();
var avg = newList.Average();
var count = newList.Count();

Console.WriteLine("somma: " + sum + ", media: " + avg + ", numero degli elemnti: " + count);










