using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("**************** Selection Sort Obdélník ****************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("********************** Pavel Bulíř **********************");
    Console.WriteLine("********************** 22.12.2025 ***********************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    
    int lowerBound; //dolní mez
    while (!int.TryParse(Console.ReadLine(), out lowerBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
    }

Console.Write("Zadejte horní mez (celé číslo): ");
    
    int upperBound; //horní mez
    while (!int.TryParse(Console.ReadLine(), out upperBound))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
    }
    Console.WriteLine();
    Console.WriteLine("*******************************************");
    Console.WriteLine("Zadané hodnoty:");
    Console.WriteLine("Počet čísel: {0}, Dolní mez: {1}, Horní mez: {2}", n, lowerBound, upperBound);
    Console.WriteLine("*******************************************");
    Console.WriteLine();

    //deklarace pole array
    int[] myRandNumbs = new int[n];

    //příprava pro využití třídy Random
    Random myRandNumb = new Random();
    // Random myRandNumb = new Random(15);


    Console.WriteLine();
    Console.WriteLine("Náhodná čísla: ");
    for (int i = 0; i < n ; i++) //vypisuje vygenerovaná čísla
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0};", myRandNumbs[i]);
    }

Stopwatch myStopwatch = new Stopwatch();
int change = 0;
int compare = 0;
myStopwatch.Start();

//================================================Sorting system (Selection sort)========================================================

for(int i = 0; i< n-1 ; i++)
    {
        int mincis = i; //bude řadit od nejnižšího čísla a to začne v myRandNumbs[0]
        for(int j = i + 1; j < n ;j++ ) //Kouká se na všechna čísla
        {
            compare++;
            if(myRandNumbs[j] < myRandNumbs[mincis]) // pokud je další číslo, j = i+1, menší než nejmenší číslo na pozici 0, pak se prohodí pozice
            {
                mincis = j;
                
            }
        }    
        int temp = myRandNumbs[i];
        myRandNumbs[i] = myRandNumbs[mincis];
        myRandNumbs[mincis] = temp;
        change++;
        

    }

//===========================================================Vypisování čísel============================================================

myStopwatch.Stop();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("*******************************************");
Console.WriteLine("Seřazené čísla: ");
for(int i = n -1 ; i >=0; i--)
    {
        Console.Write("{0}; ", myRandNumbs[i]); //od největšího po nejmenší
    }
 Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Počet porovnání: {compare}");
Console.WriteLine($"Počet výměn: {change}");
Console.WriteLine();
Console.WriteLine("Čas seřazení čísel pomocí SS: {0}", myStopwatch.Elapsed);

//=================================================Vybírání čísel pro obrazec============================================================

//=======1. Hodnota (vybírání z pořadí)=======
Console.WriteLine("Vyberte, kolikáté číslo chcete určit jako výšku: ");
int iValue;
    while (!int.TryParse(Console.ReadLine(), out iValue))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte počet čísel znovu: ");
    }



int rank = 1;
    int ithLargest = myRandNumbs[n - 1];

    for (int i = n - 2; i >= 0; i--)
    {
        if (myRandNumbs[i] < myRandNumbs[i + 1])
            rank++;

        if (rank == iValue)
        {
            ithLargest = myRandNumbs[i];
            break;
        }
    }

    Console.WriteLine($"Vybrali jste: {ithLargest} jako výšku");



//=======2. Hodnota (Medián)=======


int medián;


    if(n%2 == 0)
    {
    medián = (myRandNumbs[n/2 - 1] + myRandNumbs[n/2]) / 2;

    }
    else
    {
    medián = myRandNumbs[n/2+1];
        
    }

    Console.Write($"Medián je {medián} = šířka");  
    Console.WriteLine();




//=================================================Generování obrazce============================================================
int height = ithLargest;
int width = medián;


for (int i = 0; i < height; i++) // řádky
{
    for (int j = 0; j < width; j++) //sloupce
    {
        bool top = i < height / 2; //řádky do půlky
        bool left = j < width / 2; // sloupce do půlky

        if ((top && left) || (!top && !left))
            Console.Write("*");
        else
            Console.Write("-");
    }
    Console.WriteLine();
}











Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu a");
again = Console.ReadLine();
}