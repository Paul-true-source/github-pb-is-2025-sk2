string again = "a";
        
        while(again == "a") {
            Console.Clear();
            Console.WriteLine("*******************************************");
            Console.WriteLine("**************** Intervaly ****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine("************* Pavel Bulíř *****************");
            Console.WriteLine("*******************************************");
            Console.WriteLine();

            Console.Write("Zadejte počet generovaných čísel (celé číslo): ");
            int n;
            while(!int.TryParse(Console.ReadLine(), out n)) {
                Console.Write("Nezadali jste celé číslo. Zadejte počet generovaných čísel znovu: ");
            }

            Console.Write("Zadejte dolní mez (celé číslo): ");
            int dm;
            while(!int.TryParse(Console.ReadLine(), out dm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte dolní mez znovu: ");
            }

            Console.Write("Zadejte horní mez (celé číslo): ");
            int hm;
            while(!int.TryParse(Console.ReadLine(), out hm)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }

            Console.WriteLine();
            Console.WriteLine("==========================================");
            Console.WriteLine("Zadané hodnoty:");
            Console.WriteLine("Počet čísel: {0}; dolní mez: {1}; horní mez: {2}", n, dm, hm);
            Console.WriteLine("==========================================");
            Console.WriteLine();

            Console.Write("Zadejte počet intervalů (celé číslo): ");
            int pocInt;
            while(!int.TryParse(Console.ReadLine(), out pocInt)) {
                Console.Write("Nezadali jste celé číslo. Zadejte horní mez znovu: ");
            }



            //deklarace pole    
            int[] myArray = new int[n];

            Random randomNumber = new Random();

//=================================================Tvoření intervalů=================================================

            //vytvoření správného počtu intervalů do kterých spadají určité hodnoty
            int[] hodInt = new int [pocInt]; //hodnoty intervalů se budou zvětšovat o jedno jako počítadlo

            for(int i = 0; i < pocInt ;i++) //naplní všechny hodnoty intervalů nulou, aby se potom mohli přiřazovat pod určité intervaly pomocí ++
                {
                 hodInt[i] = 0;
                }
            
            //šířka intervalu
            double sirka = (double)(hm - dm + 1) / pocInt; // horní mez 20 dolní mez 0; 4 intervaly = 20 - 0 = 20/4 = každý interval bude mít rozpěží 5 čísel = > např.: <0;4> 

            
//=====================vypisování náhodných čísel=====================
            Console.WriteLine("\n\nNáhodná čísla:");
            
            for(int i=0; i<n; i++) 
            {
                
                myArray[i] = randomNumber.Next(dm, hm+1);
                Console.Write("{0}; ", myArray[i]);

            }
//=====================řešení intervalové otázky=====================
            
            for (int i = 0; i < n; i++)
            {
                int index = (int)((myArray[i] - dm) / sirka); // myArray[0] = 3 => (3 - 0)/5 = 0 => spadá do 1. intervalu od 0 do 4

                // poslední číslo může spadnout mimo rozsah kvůli zaokrouhlení
                if (index == pocInt)
                {
                      index--;
                }
                    hodInt[index]++; //pokud sedí číslo do toho intervalu, tak se přičte, a jakoby se tam zapíše
            }

           

//=================================================Vypisování intervalů=================================================
Console.WriteLine();
Console.WriteLine("==============================================================");
Console.WriteLine();


for (int j = 0; j < pocInt; j++)
{
    int dolni = (int)(dm + j * sirka); // dolní interval
    int horni = (int)(dm + (j + 1) * sirka - 1); // horní interval

    Console.WriteLine($"Hodnota intervalu <{dolni};{horni}> je {hodInt[j]} ");
}




Console.WriteLine("==============================================================");

            
            
            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu A");
            again = Console.ReadLine();

        }