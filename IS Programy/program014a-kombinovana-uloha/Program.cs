string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Kombinovaná úloha **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Pavel Bulíř ******************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet náhodných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n)) //n = počet náhodných čísel
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dolnimez;
    while (!int.TryParse(Console.ReadLine(), out dolnimez)) //n = počet náhodných čísel
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hornimez;
    while (!int.TryParse(Console.ReadLine(), out hornimez)) //n = počet náhodných čísel
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }
//===============================================Co jsme zadali===============================================//
Console.WriteLine();
Console.WriteLine("=================Zadali jste===================");
Console.WriteLine($"Počet čísel: {n}");
Console.WriteLine($"Dolní mez: {dolnimez}");
Console.WriteLine($"Horní mez: {hornimez}");
Console.WriteLine("===============================================");


//=================================Vytvoření náhodných čísel a jejich vypsání=================================//
//vytvoření pole
int [] RandNumbs = new int [n];

//připravení pro generování náhodných čísel
Random RandNumb = new Random ();

//vypsání náhodných čísel

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("================Náhodná čísla==================");
for (int i = 0; i < n ; i++)
    {
        RandNumbs[i] = RandNumb.Next (dolnimez, hornimez + 1);
        Console.Write("{0};", RandNumbs[i]);
    }
Console.WriteLine();
Console.WriteLine("===============================================");

//=================================Zjištění maxima minima a jejich pozic=================================//

//nejdřív musíme projít všechna čísla v poli a zjistit jaké je největší

int max = RandNumbs[0];
int min = RandNumbs[0];
int posMax = 0;
int posMin = 0;

for (int i = 1; i < n ; i++)
    { 
        if (RandNumbs[i] > max) // pokud bude hodnota větší na xtém pořadí než hodnota na nultém pořadí, která se bere jako max, tak xtá hodnota bude max
        {
            max = RandNumbs[i];
            
        }

        if (RandNumbs[i] < min)
        {
            min = RandNumbs[i];
            
        }
    }




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("==========Max, Min a jejich pozice=============");
Console.WriteLine($"MAX: {max} ");
Console.Write("Pozice MAX: ");
for(int i = 0; i < n ;i++)
    {
        if(RandNumbs[i] == max)
        {
        Console.Write("{0};", i);
        }
    }
Console.WriteLine();
Console.WriteLine($"MIN: {min}");
Console.Write("Pozice MIN: ");
for(int i = 0; i < n ;i++)
    {
        if(RandNumbs[i] == min)
        {
        Console.Write("{0};", i);
        }
    }
Console.WriteLine();
Console.WriteLine("===============================================");
//=================================Sorting system (shaker sort)=================================//

for(int i = 0;i <n ; i++)
    {
        
    }





    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
