using Shared;
using System;
using System.Data;
var answer = string.Empty;
do
{
    Console.WriteLine("__________Calculate discount________________________");
    var amount = ConsoleExtension.GetInt("Number of desktops purchased........................:");
    var total = CalculateValue(amount);
    double discount = 0;
    
    Console.WriteLine($"Number of desks....................................: {amount}");
    Console.WriteLine($"total amount to be paid............................: {total}");


    answer = ConsoleExtension.GetValidOptions("Do yoy want to check another discount [Y] yes [N] not: ", ["Y", "N"]);

}
while (answer == "y");

int CalculateValue(int amount )
{
    double discount = 0;
    if (amount < 5)
    {
        discount = 0.10;
    }
    else if (amount >= 5 && amount <= 9)
    {
        discount = 0.20;
    }
    else
    {
        discount = 0.40;
    }

    return (int)(amount * 650000 * (1 - discount));
}

Console.WriteLine("Game over");
