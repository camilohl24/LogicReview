using Shared;
using System;
var answer = string.Empty;
do
{
    Console.WriteLine("Payroll calculator");
    var name = ConsoleExtension.GetString("Enter name.............: ");
    var numberOfHours = ConsoleExtension.GetFloat("Enter hours worked.....: ");
    var hourlyRate = ConsoleExtension.GetDecimal("Enter hourly rate......: ");
    var minimumWage = ConsoleExtension.GetInt   ("Enter minimum wage.....: ");
    var salary = (decimal)numberOfHours * hourlyRate;
    if (salary < minimumWage)
    {
        Console.WriteLine($"Name of employee......: {name}");
        Console.WriteLine($"Minimun wage..........: {minimumWage:C2}");
    }
    else
    {
        Console.WriteLine($"Name of employee........: {name}");
        Console.WriteLine($"Salary Month............: {salary:C2}");
    }

    answer = ConsoleExtension.GetValidOptions("Do yoy want to chaeck another employee: ", new List<string> { "S", "N" });

}
while (answer == "s");
Console.WriteLine("Game over");
