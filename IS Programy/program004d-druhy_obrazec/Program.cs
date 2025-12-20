using System.Xml;
using Microsoft.VisualBasic;

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
    
    for (int radek = 0; radek < velikost; radek++)
    {
        Console.WriteLine();
        for(int sloupec = 0; sloupec < velikost; sloupec++)
        {
            if (radek == 0 || //horní okraj
            radek == velikost -1 || // dolní okraj
            sloupec == 0 || // levý okraj
            sloupec == velikost -1 || //pravý okraj
            radek == sloupec|| //šíkmá čára zleva nahoře dolů doprava
            sloupec == (velikost - radek - 1)) //šikmá čára zprava nahoře dolů doleva
            {
                Console.Write("*"); // pokud to tak je tak vypsat *
            }
            else
            {
                Console.Write(" "); //tímhle se vyplní zbytek
            }
        }
        
    }

    

        

      




    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
