string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Výpis pořadí pi **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Pavel Bulíř ******************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte přesnost pi (př.: 0,001): ");
    double pres;
    while (!double.TryParse(Console.ReadLine(), out pres)) //i = přesnost
    {
        Console.Write("Nezadali jste celé číslo. Zadejte první číslo řady znovu: ");
    }

double i = 1;
double piCtvrt = 1;
double znamenko = 1;

while((1/i)>=pres)
    {
        i = i+2;
        znamenko = -znamenko;
        piCtvrt = piCtvrt + znamenko*1/i;

        Console.WriteLine("Zlomek: {0}/{1}; aktuální hodnota PI = {2}", znamenko, i, 4*piCtvrt);
    }

    double pi = 4 * piCtvrt;

    Console.WriteLine("Přesnost PI: {0}", pi); 












    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();

}
