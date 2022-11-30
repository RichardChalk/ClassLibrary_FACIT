// Hej
// Jag heter project 1!
// Jag har hört att det finns ett bibliotek med fantastiska matematiska metoder!
// Jag vill gärna få tillgång till dem!

using SuperDuperClassLibrary;

var service = new MathServices();
var resultToConsole = service.Addition(5,10);
Console.WriteLine($"Jag anropade en metod som heter Addition() i class library");
Console.WriteLine($"Jag skickade med 2 parametrar (talen 5 & 10)");
Console.WriteLine($"Reslutatet blev: {resultToConsole}");

Console.WriteLine("================================================================");

resultToConsole = service.Subtraction(5, 10);
Console.WriteLine($"Jag anropade en metod som heter Subtraction() i class library");
Console.WriteLine($"Jag skickade med 2 parametrar (talen 5 & 10)");
Console.WriteLine($"Reslutatet blev: {resultToConsole}");

