using System.Xml;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************** První obrazec ***************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("*************** Pavel Bulíř ****************");
    Console.WriteLine("**************** 13.10.2025 ****************");
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
        int sikmaCara = 0;
        int i = 0;

        if (radek == 0 || radek == velikost - 1)
        {
            star = velikost;
        }
        else
        {
        
        space = 1*radek;

        star = 1;
          
        }


        for(int sp = 0; sp < space; sp++)
        {
            Console.Write(" ");
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
