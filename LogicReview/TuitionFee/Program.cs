using Shared;
using System;
using System.Security.Cryptography.X509Certificates;
var answer = string.Empty;
do
{
    Console.WriteLine("________________Tuition Fee __________________");
   
    var creditsNumber = ConsoleExtension.GetInt("Number of credits to see.........: ");
    var creditValue = ConsoleExtension.GetDecimal("Credit value.....................: ");
    var stratum = ConsoleExtension.GetInt("Stratum......................:");
    var tuitionFee = CalculateTuition(creditsNumber,creditValue,stratum);
    var subsidyAmount = CalculateSubsidy(stratum);
    Console.WriteLine($"Tuition fee.................: {tuitionFee:C2}");
    Console.WriteLine($"Subsidy  amount.............: {subsidyAmount:C2}");




    answer = ConsoleExtension.GetValidOptions("Do yoy want to check another discount [Y] yes [N] not: ", ["Y", "N"]);

}
while (answer == "y");

 static int CalculateSubsidy(int stratum)
{ 

    if (stratum == 1)
    {
       return 200000;
    }
    else if (stratum == 2)
    {
        return 100000;
    }
    else
    {
        return 0;
    }
}

static decimal extraCredits(int creditsNumber,decimal creditValue )
{
    if (creditsNumber > 20)
    {
        int extra = creditsNumber - 20;
        return extra * (creditValue * 2m);
    }
    else
    {
        return 0;
    }
}

static decimal NormalCredits(int creditsNumber, decimal creditValue)
{
    if (creditsNumber <= 20)
    {
        return creditsNumber * creditValue;
    }
    else
    {
        return  20m * creditValue;
    }
}
static decimal CalculateTuition(int creditsNumber, decimal creditValue,int stratum)
{
    var extra = extraCredits(creditsNumber,creditValue);
    var normal = NormalCredits(creditsNumber,creditValue);
    var valueToPay  = normal + extra;
    


    if (stratum == 1)
    {
        valueToPay -= valueToPay * 0.80m;
    }
    else if (stratum == 2)
    {
        valueToPay -= valueToPay * 0.50m;
    }
    if(stratum == 3) 
    {
        valueToPay -= valueToPay * 0.30m;
    }
    else
    {
        return valueToPay;
    }

    return valueToPay;

}


Console.WriteLine("Game over");
