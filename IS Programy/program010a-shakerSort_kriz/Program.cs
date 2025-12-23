using System.Security.Authentication.ExtendedProtection;
using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("******************* Shaker Sort Kříž ********************");
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
for(int i = 0; i < n/2;i++) // zahájí hledání a seřazování
    {
        
        for (int j = 0; j < n - 1 - i; j++) //jedna cesta a porovnávání tam
        {
            if (myRandNumbs[j] < myRandNumbs[j+1])
            {
            int tmp = myRandNumbs[j+1];   
            myRandNumbs[j+1] = myRandNumbs[j];
            myRandNumbs[j] = tmp;
            change++;
            }
            compare++;
        }
        for (int j = n-1; j >=1 + i; j--) //jedna cesta a porovnání zpátky
        {
            if (myRandNumbs[j-1] < myRandNumbs[j])
            {
                int tmp = myRandNumbs[j];
                myRandNumbs[j] = myRandNumbs[j-1];
                myRandNumbs[j-1] = tmp;
                change++;
            }
            compare++;
        }

        
    }
myStopwatch.Stop();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("*******************************************");
Console.WriteLine("Seřazené čísla: ");
for(int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]); //od největšího po nejmenší
    }
 Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"Počet porovnání: {compare}");
Console.WriteLine($"Počet výměn: {change}");
Console.WriteLine();
Console.WriteLine("Čas seřazení čísel pomocí SS: {0}", myStopwatch.Elapsed);

//1. hodnota = 3. největší hodnota
//2. hodnota =

int iValue = 3;  // třeba třetí největší

    int actualRank = 1;           // 1. největší je první prvek
    int currentValue = myRandNumbs[0];
    int ithLargest = 0;              // sem uložíme výsledek
    bool found = false;              // zatím nenalezeno

    // Procházíme čísla od druhého prvku
    for (int j = 1; j < n; j++)
    {
        // Zjišťujeme, jestli je aktuální hodnota nová a menší
        // Pokud není menší, je to duplicita => ignorujeme
        // Pokud je menší, znamená to, že jsme narazili na odlišnou hodnotu a tu si uložíme
        if (myRandNumbs[j] < currentValue) //při 1. zjistíme jestli hodnota myRandNumbs[1] je menší než current value, což je myRandNumbs[0]
        {
            currentValue = myRandNumbs[j];
            actualRank++;
        }

        // Sledujeme, jestli jsme právě narazili na i-tou hodnotu.
        // Pokud je to i-tá, nastavíme ji (provede se to pouze jednou).
        if (actualRank == iValue && found==false)
        {
            ithLargest = currentValue;
            found = true; //tohle zajistí že se to už nebude opakovat v téhlé poslední if funkci
        }
    }
    Console.WriteLine($"3. největší hodnota: {ithLargest} = výška");

    int AP = 0;
    for (int i = 0; i < n ;i++ )
    {
        
        AP = AP + myRandNumbs [i];
    }

    int ArPr = AP/n;

    Console.WriteLine($"Aritmetický průměr hodnot: {ArPr} = šířka");




//vygenerování kříže

int height = ithLargest;
int width = ArPr;

int midH1 = (height - 1) / 2; //pokud to bude stejné číslo jako midH2, tak je to lichý => (11-1)/2 = 5
int midH2 = height / 2; // 11/2 = 5

int midW1 = (width - 1) / 2;
int midW2 = width / 2;

bool liH = height%2 == 1; //je true pokud je číslo liché
bool liW = width%2 == 1;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {

        bool horizontal;
        bool vertical;
        //zvětšení šířky čáry, pokud bude číslo liché místo * => ***
       if (liH)
            horizontal = Math.Abs(i - midH1) <= 1; //Math.Abs = absolutní hodnota z (i - midH1) 
        else
            horizontal = (i == midH1 || i == midH2);

        if (liW)
            vertical = Math.Abs(j - midW1) <= 1;
        else
            vertical = (j == midW1 || j == midW2);

        if (horizontal || vertical)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();

}








Console.WriteLine();
Console.WriteLine("Pro opakování programu stiskněte klávesu a");
again = Console.ReadLine();
}