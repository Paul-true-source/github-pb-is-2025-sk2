using System.Runtime.InteropServices.Marshalling;

string again = "a";
while (again == "a")

    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Seřazení dvou čísel *************");
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
    Console.Write("Nezadali jste celé číslo. Zadejte celé číslo A: ");
}
    

Console.Write("Zadejte celé číslo B:");
    int b;
while (!int.TryParse(Console.ReadLine(), out b))
{
    Console.Write("Nezadali jste celé číslo. Zadejte celé číslo B: ");
}

Console.WriteLine();

int pom;
//Chceme seřadit čísla vzestupně
if (a > b)
{
    pom = a;
    a = b;
    b = pom;
}

Console.WriteLine("==============================");
Console.WriteLine($"Seřazemá čísla: {a}, {b}");
Console.WriteLine("==============================");
Console.WriteLine("Pro opakování programu stiskněte klávesu a");

again = Console.ReadLine();
    
