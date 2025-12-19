using System.Xml;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Výpis číselné řady *************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Pavel Bulíř ******************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte velikost obrazce (celé číslo): ");
    int velikost;
    while (!int.TryParse(Console.ReadLine(), out velikost))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo znovu: ");
    }

    for(int radek = 0; radek < velikost; radek++)
    {

        int star = 0;
        int space = 0;
        

        if (radek == 0 || radek == velikost -1)
        {
            star = velikost;
        }
        else if (radek < (velikost-1)/2)
        {
            Console.Write("*");

            space = radek -1;
            for(int sp = 0; sp < space; sp++)
                {
                Console.Write("-");
                }

            Console.Write("*");

            space = velikost - radek*2 -2;
            for(int sp = 0; sp < space; sp++)
                {
                Console.Write("-");
                }

            Console.Write("*");

            space = radek -1;
            for(int sp = 0; sp < space; sp++)
                {
                Console.Write("-");
                }

            Console.Write("*");
        }
        else if (velikost%2 == 1)
            {
               for (radek = 0; radek == (velikost/2) + 1 ; radek++ )
                {
                     Console.Write("*");

                    space = velikost/2;
                     for(int sp = 0; sp < space; sp++)
                    {
                    Console.Write("-");
                    }
                }
            }
        
            
    
        else if (radek < velikost)
        {
            Console.Write("*");

            space = velikost - radek -2;
            for(int sp = 0; sp < space; sp++)
                {
                Console.Write("-");
                }

            Console.Write("*");

            space = radek*2 - velikost;
            for(int sp = 0; sp < space; sp++)
                {
                Console.Write("-");
                }

            Console.Write("*");

            space = velikost - radek -2;
            for(int sp = 0; sp < space; sp++)
                {
                Console.Write("-");
                }

            Console.Write("*");
        }
       
       



    

        

        for(int st = 0; st < star; st++)
        {
            Console.Write("*");
        }

    Console.WriteLine();
    }





    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
