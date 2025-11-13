string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********** Generátor pseudonáhodných čísel *************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("*********************************************************");
    Console.WriteLine("********************* Pavel Bulíř ***********************");
    Console.WriteLine("********************* 13.10.2025 ************************");
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
    for (int i = 0; i < n; i++)
    {
        myRandNumbs[i] = myRandNumb.Next(lowerBound, upperBound + 1);
        Console.Write("{0};", myRandNumbs[i]);
    }

    //hledání maxima, pozoice maxima, minimia, pozice minimia

    int max = myRandNumbs[0];
    int min = myRandNumbs[0];
    int posMax = 0;
    int posMin = 0;

    // 7, 5, 9,
    for (int i = 1; i < n; i++)
    {
        if (myRandNumbs[i] > max) //9 > 7
        {
            max = myRandNumbs[i];
            posMax = i;
        }
        if (myRandNumbs[i] < min)
        {
            min = myRandNumbs[i];
            posMin = i;
        }

    

    }

    Console.WriteLine();
    Console.WriteLine("==========================================");
    Console.WriteLine($"Maximum: {max}");
    Console.WriteLine($"Pozice maxima: {posMax}");
    Console.WriteLine($"Minimum: {min}");
    Console.WriteLine($"Pozice minima: {posMin}");
    Console.WriteLine("==========================================");
    Console.WriteLine();



    //vykreslování přesípacích hodin
    if (max >= 3)
    {
        Console.WriteLine();
        Console.WriteLine("====================================");
        Console.WriteLine();
        Console.WriteLine($"Přesýpací hodiny o velikosti {max}");
        Console.WriteLine();


        //tento cyklus se stará o to aby se vykreslil správný počet řádků
        for (int i = 0; i < max; i++) // kdyby int i = 1 tak by i<= max
        {
            int spaces, stars;

            if (i < max / 2)
            {
                //horní polovina - počet mezer v i-tém řádku
                spaces = i;  //1. řádek = i začíná od nuly stejně jako mezery tak proto se to rovná i


                //horní polovina - s každým dalším řádkem ubývají 2 hvězdičky 
                stars = max - 2 * i; // 10 -2*0 = 10; 10 - 2*1 = 8; 10 -2*2 = 6 => funguje


            }
            else
            {
                //dolní polovina - počet mezer v i-tém řádku
                spaces = max - i - 1; //musíme od i odečíst 1 protože začíná v 0

                if (max % 2 == 1)
                {
                    stars = 2 * (i - max / 2) + 1;
                }
                else
                {
                    stars = 2 * (i - max / 2) + 2;
                }

            }

            Console.ForegroundColor = ConsoleColor.Blue;
        //vykreslení správného počtu mezer pro každý řádek
        //sp = space
        for (int sp = 0; sp < spaces; sp++)
            System.Console.Write(" ");


        //vykreslení  počtu hvězdiček pro každý řádek
         //st = star=> 1 hvězdička
        for (int st = 0; st < stars; st++)
            System.Console.Write("*");

            Console.WriteLine();
                
        }
        
        




    }
    else
        Console.WriteLine("Maximum je menší než 3 => obrazec se nebude vykreslovat!!!");







    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
