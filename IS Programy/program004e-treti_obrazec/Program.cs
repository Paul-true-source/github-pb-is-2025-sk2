string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** Druhý obrazec ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Pavel Bulíř ******************");
    Console.WriteLine("************** 20. 12. 2025 ****************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte velikost obrazce (celé číslo): ");
    int velikost;
    while (!int.TryParse(Console.ReadLine(), out velikost))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }
    
    for (int radek = 1; radek <= velikost; radek++)
    {
        
        Console.WriteLine();
        for(int sloupec = 1; sloupec <= velikost; sloupec++)
        {
            
            if((radek-1)/2 % 2 == 0)
            {
                if ((sloupec + 1)/2%2 ==0)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.Write("*");
                }
            }
            else if ((sloupec + 1)/2%2 ==0)
            {
                Console.Write("*");
            }
            else
            {
                Console.Write(" ");
            }

            
            

            
        }

    }


Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}