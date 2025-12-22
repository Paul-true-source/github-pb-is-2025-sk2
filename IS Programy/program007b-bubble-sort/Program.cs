using System.Diagnostics;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("****************** Bubble sort program ******************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("********************** Pavel Bulíř **********************");
    Console.WriteLine("********************** 13.10.2025 ***********************");
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
    for (int i = 0; i < n ; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound+1);
        Console.Write("{0};", myRandNumbs[i]);
    }

    Stopwatch myStopwatch = new Stopwatch();

    int compare = 0; //počet porovnání
    int change = 0; //počet výměň


myStopwatch.Start();
    for(int i =0; i < n - 1 ;i++){
        //tento cyklus musí zajistit porovnávání hodnot
        //musí dále zajistit, aby se zmenšoval počet porovnávaných hodnot

        for(int j = 0; j < n - 1 - i ; j++) {
            
            if(myRandNumbs[j] < myRandNumbs[j+1])
            {
            int tmp = myRandNumbs[j+1];
            myRandNumbs[j+1] = myRandNumbs[j];
            myRandNumbs[j] = tmp;
            change++;
            }
            compare ++;

        }




    }
myStopwatch.Stop();

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("*******************************************");
Console.WriteLine("Seřazené čísla: ");
for(int i = 0; i < n; i++)
    {
        Console.Write("{0}; ", myRandNumbs[i]); //od nejmenšího po největší
    }

     Console.WriteLine();
     Console.WriteLine();
     Console.WriteLine();
     Console.WriteLine($"Počet porovnání: {compare}");
     Console.WriteLine($"Počet výměn: {change}");
     Console.WriteLine();
     Console.WriteLine("Čas seřazení čísel pomocí BS: {0}", myStopwatch.Elapsed);


    //nalezení 2. největšího čísla a použití n

    int max = myRandNumbs[0];
    int secondMax = int.MinValue;
    Console.WriteLine($"Druhé největší číslo : {secondMax}");

    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] < max && secondMax == int.MinValue)
        {
            secondMax = myRandNumbs[i];
        }
    }

    Console.WriteLine();
    Console.WriteLine("*******************************************");
    Console.WriteLine();
    Console.WriteLine($"Druhé největší číslo: {secondMax}");

    //implementace nalezení i-tého největšího čísla
/*int iValue = 3;  // třeba třetí největší

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
    Console.WriteLine($"i-tá největší hodnota ({iValue}): {ithLargest}\n\n");*/


    //vykreselení obrázku
    Console.WriteLine();
    for (int radek = 0; radek < secondMax; radek++) //vykreslení řádků
    {
        for(int sloupec = 0; sloupec < secondMax; sloupec++)
        {
            if(radek < 2 || radek > secondMax -3 || sloupec == 0|| sloupec == secondMax -1)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }
        }

        Console.WriteLine();
    }





    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
