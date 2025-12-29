using System.Net.Mime;

string again = "a";
while (again == "a")
{
    Console.Clear();
    Console.WriteLine("********************************************");
    Console.WriteLine("*********** Kombinovaná úloha **************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine("************* Pavel Bulíř ******************");
    Console.WriteLine("************** 13.10.2025 ******************");
    Console.WriteLine("********************************************");
    Console.WriteLine("********************************************");
    Console.WriteLine();

    Console.Write("Zadejte počet náhodných čísel (celé číslo): ");
    int n;
    while (!int.TryParse(Console.ReadLine(), out n)) //n = počet náhodných čísel
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    Console.Write("Zadejte dolní mez (celé číslo): ");
    int dolnimez;
    while (!int.TryParse(Console.ReadLine(), out dolnimez)) //n = počet náhodných čísel
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }

    Console.Write("Zadejte horní mez (celé číslo): ");
    int hornimez;
    while (!int.TryParse(Console.ReadLine(), out hornimez)) //n = počet náhodných čísel
    {
        Console.Write("Nezadali jste celé číslo. Zadejte číslo znovu: ");
    }
//===============================================Co jsme zadali===============================================//
Console.WriteLine();
Console.WriteLine("=================Zadali jste===================");
Console.WriteLine($"Počet čísel: {n}");
Console.WriteLine($"Dolní mez: {dolnimez}");
Console.WriteLine($"Horní mez: {hornimez}");
Console.WriteLine("===============================================");

//=================================Vytvoření náhodných čísel a jejich vypsání=================================//
//vytvoření pole
int [] RandNumbs = new int [n];

//připravení pro generování náhodných čísel
Random RandNumb = new Random ();

//vypsání náhodných čísel

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("================Náhodná čísla==================");
for (int i = 0; i < n ; i++)
    {
        RandNumbs[i] = RandNumb.Next (dolnimez, hornimez + 1);
        Console.Write("{0};", RandNumbs[i]);
    }
Console.WriteLine();
Console.WriteLine("===============================================");

//=================================Zjištění maxima minima a jejich pozic=================================//

//nejdřív musíme projít všechna čísla v poli a zjistit jaké je největší

int max = RandNumbs[0];
int min = RandNumbs[0];
int posMax = 0;
int posMin = 0;

for (int i = 1; i < n ; i++)
    { 
        if (RandNumbs[i] > max) // pokud bude hodnota větší na xtém pořadí než hodnota na nultém pořadí, která se bere jako max, tak xtá hodnota bude max
        {
            max = RandNumbs[i];
            
        }

        if (RandNumbs[i] < min)
        {
            min = RandNumbs[i];
            
        }
    }




Console.WriteLine();
Console.WriteLine();
Console.WriteLine("==========Max, Min a jejich pozice=============");
Console.WriteLine($"MAX: {max} ");
Console.Write("Pozice MAX: ");
for(int i = 0; i < n ;i++)
    {
        if(RandNumbs[i] == max)
        {
        Console.Write("{0};", i);
        }
    }
Console.WriteLine();
Console.WriteLine($"MIN: {min}");
Console.Write("Pozice MIN: ");
for(int i = 0; i < n ;i++)
    {
        if(RandNumbs[i] == min)
        {
        Console.Write("{0};", i);
        }
    }
Console.WriteLine();
Console.WriteLine("===============================================");
//=================================Sorting system (shaker sort)=================================//

for(int j = 0; j < n - 1 ; j++) //budeme procházet celé pole
    {
        for(int i = 0;i < n -1 - j ; i++) //musíme dát -1 aby jsme pořád nemuseli řešit celé pole a zároven dát -1 aby jsme nepřesáhli pole kvůli RandNumbs[i+1]
        {
            if(RandNumbs[i] < RandNumbs[i + 1]) // pokud je číslo na pozici 1 větší než číslo na pozici 0
            {
                int tmp = RandNumbs[i];
                RandNumbs[i] = RandNumbs[i+1]; // číslo na pozici 0 = číslo na pozici 1
                RandNumbs[i+1] = tmp; // číslo na pozici 1 = číslo na pozici 0
            }
        }

        for(int l = n - 2; l <= 0 ;l--)
        {
            if (RandNumbs[l] < RandNumbs[l+1])
            {
                int temp = RandNumbs[l];
                RandNumbs[l] = RandNumbs[l+1];
                RandNumbs[l+1] = temp;
            }
        }
    }
//=================================Vypsání seřazených náhodných čísel=================================//

Console.WriteLine();
Console.WriteLine();
Console.WriteLine("===============Seřazená čísla==================");
for(int i = 0; i < n ; i++)
    {
        Console.Write("{0};", RandNumbs[i]);
    }
Console.WriteLine();
Console.WriteLine("===============================================");

//=================================Nalezení 2. 3. 4. největší hodnoty=================================//

//nalezení 2. největšího čísla
int actualRank2 = 1;
bool found2 = false;
int currentValue2 = RandNumbs[0];
int druheNej = 0;
int druheHled = 2;

for (int i = 1; i < n ; i++) //víme kde je max takže nepotřebujeme začínat na RandNumbs[0];
    {
        if (currentValue2 > RandNumbs[i]) //narazily jsme na 2. největší hodnotu
        {
            currentValue2 = RandNumbs[i];
            actualRank2++;
        }


        if (actualRank2 == druheHled && found2 == false)
        {
            druheNej = currentValue2;
            found2 = true;
        }

    }


//nalezení 3. největšího čísla
int currentValue3 = RandNumbs[0];
int tretiNej = 0;
int actualRank3 = 1;
bool found3 = false;
int tretiHled = 3;

for (int i = 1; i < n ; i++) //víme kde je max takže nepotřebujeme začínat na RandNumbs[0];
    {
        if (currentValue3 > RandNumbs[i]) //narazily jsme na 2. největší hodnotu
        {
            currentValue3 = RandNumbs[i];
            actualRank3++;
        }



        if (actualRank3 == tretiHled && found3 == false)
        {
            tretiNej = currentValue3;
            found3 = true;
        }

    }


//nalezení 4. největšího čísla
int currentValue4 = RandNumbs[0];
int ctvrteNej = 0;
int actualRank4 = 1;
bool found4 = false;
int ctvrteHled = 4;

for (int i = 1; i < n ; i++) //víme kde je max takže nepotřebujeme začínat na RandNumbs[0];
    {
        if (currentValue4 > RandNumbs[i]) //narazily jsme na 2. největší hodnotu
        {
            currentValue4 = RandNumbs[i];
            actualRank4++;
        }



        if (actualRank4 == ctvrteHled && found4 == false)
        {
            ctvrteNej = currentValue4;
            found4 = true;
        }

    }
Console.WriteLine();
Console.WriteLine();    
Console.WriteLine("================Největší čísla=================");
Console.WriteLine("Druhé největší číslo je: {0}", druheNej); 
Console.WriteLine("Třetí největší číslo je: {0}", tretiNej);   
Console.WriteLine("Čtvrté největší číslo je: {0}", ctvrteNej);
int median;
if (n%2 == 0)
 {
     median = (RandNumbs[n/2 -1] + RandNumbs[n/2])/2;
 }
 else
 {
      median = RandNumbs[n/2];
 }
Console.WriteLine($"Medián je: {median}");
Console.WriteLine("===============================================");
Console.WriteLine();
Console.WriteLine();

//=================================Převedení 4. nějvětšího čísla do binární soustavy=================================//
Console.WriteLine("===============================================");

uint[] BinCis = new uint[32];
uint celeCislo = (uint)ctvrteNej;
uint zbytek;

uint k;
for (k = 0; celeCislo > 0; k++)
{
    zbytek = celeCislo % 2;
    Console.WriteLine("Celá část: {0}/2 = {1} Zbytek: {2}", celeCislo, celeCislo/2 ,zbytek);

    celeCislo /= 2;
    BinCis[k] = zbytek;
}

Console.WriteLine($"Číslo {ctvrteNej} je v binární soustavě: ");
for (int j = (int)k - 1; j >= 0; j--)
{
    Console.Write("{0}", BinCis[j]);
}
Console.WriteLine();
Console.WriteLine();
//==========================================Obrazec==========================================//
Console.WriteLine("===============================================");
Console.WriteLine($"Obrazec se skládá z mediánu : {median} jako výšky a 3. největšího čísla: {tretiNej} jako šířky.");
Console.WriteLine();



int height = median;
int width = tretiNej;

int midH1 = (height - 1) / 2; //pokud to bude stejné číslo jako midH2, tak je to lichý => (11-1)/2 = 5
int midH2 = height / 2; // 11/2 = 5

int midW1 = (width - 1) / 2;
int midW2 = width / 2;

bool liH = height%2 == 1; //je true pokud je číslo liché
bool liW = width%2 == 1;

for (int i = 0; i < height; i++)
{
    for (int j = 0; j < width; j++)
    {

        bool horizontal;
        bool vertical;
        //zvětšení šířky čáry, pokud bude číslo liché místo * => ***
       if (liH)
            horizontal = Math.Abs(i - midH1) <= 1; //Math.Abs = absolutní hodnota z (i - midH1) 
        else
            horizontal = (i == midH1 || i == midH2);

        if (liW)
            vertical = Math.Abs(j - midW1) <= 1;
        else
            vertical = (j == midW1 || j == midW2);

        if (horizontal || vertical)
            Console.Write("*");
        else
            Console.Write(" ");
    }
    Console.WriteLine();

}

    Console.WriteLine();
    Console.WriteLine("Pro opakování programu stiskněte klávesu a");
    again = Console.ReadLine();
}
