string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("**Převod z desítkové soustavy do jakékoli***");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Pavel Bulíř ******************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte desítkové číslo (přirozené): ");
    uint number10;
    while (!uint.TryParse(Console.ReadLine(), out number10))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte desítkové číslo (přirozené) znovu: ");
    }

    Console.Write("Zadejte číslo soustavy, do které chcete číslo přepsat (musí být přirozené a menší než 10): ");
    uint soustava;
    while (!uint.TryParse(Console.ReadLine(), out soustava))
    {
        Console.Write("Nezadali jste přirozené číslo. Zadejte číslo soustavy (přirozené) znovu: ");
    }

    if(soustava < 10)
    {
    uint[] myArray = new uint[32];
    uint backupNumber10 = number10;
    uint zbytek;

    
    uint i;
    for(i = 0;number10 > 0 ; i++)
    {
        zbytek = number10 % soustava;
        number10 = (number10 - zbytek) / soustava;
        myArray[i] = zbytek;

        Console.WriteLine("Celá část: {0}; Zbytek: {1}", number10, zbytek);
    }

    Console.Write("Desítkové číslo {0} ve dvojkové soustavě = ", backupNumber10);
    for(int j = (int)i - 1; j>= 0 ; j--)
    {
        Console.Write("{0}", myArray[j]);
    }
    }
    else
    {
        Console.WriteLine();
        Console.WriteLine("Soustava musí být menší než 10");
    }

    System.Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();



}
