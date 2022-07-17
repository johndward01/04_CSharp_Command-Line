// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

//Console.Write("Please enter your name: ");
//var name = Console.ReadLine();
//Console.WriteLine($"Hello, {name}!");


var util = new Utility();
var cubed = util.cube.Invoke(3);
Console.WriteLine(cubed);
