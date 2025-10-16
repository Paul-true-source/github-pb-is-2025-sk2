using System.Runtime.ExceptionServices;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("******************************************");
    Console.WriteLine("*************Vypiš číselné řady***********");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine("****************Pavel Bulíř***************");
    Console.WriteLine("*****************2. 10. 2025**************");
    Console.WriteLine("******************************************");
    Console.WriteLine("******************************************");
    Console.WriteLine();

    // Vstup hodnoty do programu, ale špatné řešení;
    Console.Write("První číslo řady: ");
    //int first = int.Parse(Console.ReadLine);

    // Vstup hodnoty do programu, ale špatné řešení
    Console.Write("hdf hdsfh jh");
    int first;
    while ((int.TryParse(Console.ReadLine(), out first)))

        Console.WriteLine();
    Console.WriteLine("Pro aplikování programu stiskni a");
    again = Console.ReadLine();

}
Console.Write("Zadejte poslední číslo řady (celé číslo):");
intstep;
while (!int.TryParse (Console.ReadLine(),out step))
{
    Console.Write("Nezadali jste celé číslo. Zadejte diferenci znovu:");
}

int suma = 0;
int numberBackup = number;
int digit;

//Pokud je vstup záprný, tak ho změníme na kladný
if (number < 0)
{
    numberBackup = -number;
}

while (numberBackup >= 10)
{
    digit = number % 10; //určí se nám zbytek
    number = (number - digit) / 10;
    Console.WriteLine("Hodnota zbytku: {0}", digit);
    suma = suma + digit;
}

//musíme poslední cifru vypsat
Console.WriteLine("Poslední zbytek ={0}", number);

//musíme poslední cifru přičíst
suma = suma + number;

Console.WriteLine();
Console.WriteLine("Součet cifer čísla {0} je {1}",numberBackup, suma);

Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu a");
again = Console.ReadLine();