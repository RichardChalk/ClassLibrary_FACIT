// Hej
// Jag heter project 2!
// Jag har hört att det finns ett bibliotek med fantastiska matematiska metoder!
// Jag vill gärna få tillgång till dem!

using SuperDuperClassLibrary;

var service = new MathServices();
var resultToConsole = service.Multiplication(5, 10);
Console.WriteLine($"Jag anropade en metod som heter Multiplication() i class library");
Console.WriteLine($"Jag skickade med 2 parametrar (talen 5 & 10)");
Console.WriteLine($"Reslutatet blev: {resultToConsole}");

Console.WriteLine("================================================================");

var resultToConsoleDouble = service.Division(5, 10);
Console.WriteLine($"Jag anropade en metod som heter Division() i class library");
Console.WriteLine($"Jag skickade med 2 parametrar (talen 5 & 10)");
Console.WriteLine($"Reslutatet blev: {resultToConsoleDouble}");


