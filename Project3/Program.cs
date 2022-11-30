// Först ska vi installerar alla Nuget paket som behövs för att kunna
// koppla upp oss mot en databas...

using Microsoft.EntityFrameworkCore.Diagnostics;
using SuperDuperClassLibrary.Models;

Console.WriteLine("Project 3 FTW");

// Koppla till Northwind DbContext
Console.WriteLine("************** Northwind ***************");
var dbContext = new NorthwindContext();

var counter = 1;
foreach (var prod in dbContext.Products)
{
    Console.WriteLine($"{counter}: {prod.ProductName}");
    ++counter;
}
