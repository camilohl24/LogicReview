using Shared;
using System;
var answer = string.Empty;
do
{
    Console.WriteLine("__________Calculate discount________________________");
    const double price = 650000;
    var amount = ConsoleExtension.GetInt("Number of desktops purchased........................:");
    var total= price * amount;
    double discount = 0;
    if (amount < 5)
    {
        discount = 0.10;
        total -= (total * discount);
    }
    else if (amount >= 5 && amount <= 9)
    {
        discount = 0.20;
        total -= (total * discount);
    }
    else
    {
        discount = 0.40;
        total -= (total * discount);
    }
    Console.WriteLine($"Number of desks....................................: {amount}");
    Console.WriteLine($"total amount to be paid............................: {total}");


    answer = ConsoleExtension.GetValidOptions("Do yoy want to check another discount [Y] yes [N] not: ", ["Y", "N"]);

}
while (answer == "y");
Console.WriteLine("Game over");
