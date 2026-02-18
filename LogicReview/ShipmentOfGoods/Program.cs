using Shared;
using System;
using System.Security.Cryptography.X509Certificates;
var answer = string.Empty;
do
{
    Console.WriteLine("________________Envio de mercancias__________________");

    var weight = ConsoleExtension.GetInt("Peso de la mercancia........: ");
    var price = ConsoleExtension.GetDecimal("Valor de la mercancia............: ");
    var day = ConsoleExtension.GetValidOptions("es lunes [S]i;[N]o ..:", ["S", "N"]).ToUpper();
    var paymentType = ConsoleExtension.GetValidOptions("Tipo de pago [E]fectivo, [T]arjeta...:", ["E", "T"]).ToUpper();
    var rate = CalculateRate(weight);
    var discounts = CalculateDiscount(price, rate);
    var promotion = CalculatePromotion(day, paymentType, rate, price);
    bool hasPromotion = (day == "S" && paymentType == "T" || paymentType == "E" && price > 1000000);
    decimal total;
    Console.WriteLine(hasPromotion);
   if (hasPromotion)
    {
        total = rate - promotion;
        Console.WriteLine($"Tarifa....................:{rate}");
        Console.WriteLine($"promocion.................:{promotion}");
        Console.WriteLine($"Total a pagar.............:{total}");
    }
    else
    {
        total = rate - discounts;
        Console.WriteLine($"Tarifa....................:{rate}");
        Console.WriteLine($"Descuento.................:{discounts}");
        Console.WriteLine($"Total a pagar.............:{total}");

    }





        answer = ConsoleExtension.GetValidOptions("Do yoy want to check another discount [Y] yes [N] not: ", ["Y", "N"]);

}
while (answer == "y");
static decimal CalculatePromotion(string day, string paymentType, decimal rate,decimal price)
{
    if (day == "S" && paymentType == "T")
    {
        return rate * 0.50m;

    }
    else if (paymentType == "E" && price > 1000000)
    {
        return rate * 0.60m;
    }
    else
    {
        return rate;
    }  
}

static decimal CalculateDiscount(decimal price, decimal rate)
{
    if (price >= 300000 && price <=600000 )
    {
       return rate * 0.10m;
    }
    else if(price > 600000 && price <= 1000000)
    {
       return rate * 0.20m;
    }
    else if (price > 1000000)
    {
        return rate * 0.30m;
    }
    else
    {
        return 0;
    }

}

static decimal CalculateRate(int weight)
{
    if (weight < 100)
    {
        return 20000m;
    }
    else if (weight >= 100 && weight <= 150)
    {
        return 25000m;
    }
    else if (weight > 150 && weight <= 200)
    {
        return 30000m;
    }
    else
    {
        var extraWeight = weight - 200;
        var block = extraWeight / 10;

        return 35000 + (block * 2000);
    }

}

Console.WriteLine("Game over");
