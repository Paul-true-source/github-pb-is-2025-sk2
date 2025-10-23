string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("********* největší ze tri cisel ************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Pavel Bulíř ******************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();


    Console.Write("Zadejte celé číslo A:");
    int a;
    while (!int.TryParse(Console.ReadLine(), out a))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A znovu: ");
    }


    Console.Write("Zadejte celé číslo B:");
    int b;
    while (!int.TryParse(Console.ReadLine(), out b))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B znovu: ");
    }

    Console.Write("Zadejte celé číslo C:");
    int c;
    while (!int.TryParse(Console.ReadLine(), out c))
    {
        Console.Write("Nezadali jste celé číslo. Zadejte celé číslo C znovu: ");
    }
    Console.WriteLine();

    if (a > b)
    {
        if (a > c)
            Console.WriteLine($"Největší číslo je A = {a}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }
    else
    {
        if (b > c)
            Console.WriteLine($"Největší číslo je B = {b}");
        else
            Console.WriteLine($"Největší číslo je C = {c}");
    }

    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}