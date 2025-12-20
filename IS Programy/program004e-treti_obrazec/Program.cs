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
            
            if((radek-1)/2 % 2 == 0) // bere v potaz 1-2, 5-6, 9-11,..... řádek => uděláme pruhovaný
            {
                if ((sloupec + 1)/2%2 ==0) // z toho co máme vybraný uděláme pruhovaný => rozdělíme jakoby na čtverečky
                {
                    Console.Write(" "); //hlavní znak
                }
                else
                {
                    Console.Write("*"); // výplň
                }
            }
            else if ((sloupec + 1)/2%2 ==0) // nemám nejmenší tušení ale asi něco s pruhováním, asi jako že se to bude křížit s tím prvním a nebude se to navzájem rušit ¯\_(ツ)_/¯
            {
                Console.Write("*"); //hlavní znak
            }
            else
            {
                Console.Write(" "); // výplň
            }

            
            

            
        }

    }


    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}