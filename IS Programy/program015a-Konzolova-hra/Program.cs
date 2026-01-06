

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

Console.CursorVisible = false;
int score = 0;
int playerX = 20; // začínající pozice X hráče
int playerY = 10; // začínající pozice Y hráče
int cas = 0; // čas bude přibývat, možná to udělám že bude časový limit

int sirka = 40; // no... šířka mapy
int vyska = 20; // výška mapy, abych nemusel pořád psát 40 a 20

List<(int x, int y)> prekazky = new List<(int x, int y)>(); // je podobný Random podtím nebo jako pole když se vytváří, napíše se co se vytvoří, co bude v něm pak název, a pak znovu ale s závorkami nakonci. Když v prekazky budou dvě hodnoty, jakože jsou tak je můžeme vypsat jako prekazky.x a prekazky.y. Funguje to podobně jako pole ale má to dvě čísla v sobě => x+y = bod
List<(int x, int y, int life)> coin = new List<(int x, int y, int life)>(); //mince, které budou určovat body
Random rnd = new Random(); //vytvoří datový typ Radnom, který se bude jmenovat rnd = a uloží to do něj nového člověka, kterého naučí házet kostkou



bool hraBezi = true;

while (hraBezi)
{
    Console.Clear();
    // časovač
    cas = cas + 100;
//====================vygenerování překážek====================
int nahoda = rnd.Next(0,10); //tohle udělá číslo, které se může objevit jako 0 - 10 => samozřejmě náhodně
if (nahoda < 6) //60% šance na vygenerování překážky
    {
        int y = rnd.Next(1, vyska -1); //vvygeneruje překážku na pozici 1 až 18 řádku, jelikož 0 a 19 jsou hrany
        prekazky.Add((sirka -2, y)); //vygeneruje se překážka, = prekazka.Count() = 1 i think, prekážka se vygeneruje úplně vpravo před hranicí proto -2 a to je x a y je už určen předtím pomocí random
    }

//====================vygenerování coinů====================
int random = rnd.Next(0,10);
if(random == 0)
    {
        int zivotnost = 4000; //definuje, jak dlouho bude coin žít

        int y = rnd.Next(1, vyska -1); // z nějakýho záhadnýho důvodu je 1 včetně ale vyska -1 se tam nepočítá, takže reálně vyska -1 je vyska -2
        int x = rnd.Next(1, sirka -1);
        coin.Add((x,y,cas+zivotnost));
    }

//====================pohyb překážek====================
    for(int i = 0; i < prekazky.Count; i++) // vygenerování pohybů pro překážky
    {
        var p = prekazky[i]; //překážka číslo 1 , 2 , 3 ,...
        p.x = p.x -1;//u každé překážky se posune x o jedno doleva, jde vidět, když se najede na datový typ var
        prekazky[i] = p; //aby se prekazky mohli pohybovat, tak se jejich základ od kterého se bude posouvat doleva, jako hodit lano a pak se k němu přitáhnout ne přitáhnout si lano ale přitáhnout se k lanu
    }

//====================mazání překážek, co jsou na konci mapy====================

for (int i = prekazky.Count -1; i >= 0; i--) // i začíná od poslední 
    {
        if(prekazky[i].x <= 0) // pokud se xová hodnota dotkne/vnikne do 0 => hranice, tak se smaže
        {
            prekazky.RemoveAt(i); //smazání překážky
        }
    }

    foreach (var p in prekazky)
    {
        if(p.x == playerX && p.y == playerY)
        {
            hraBezi = false;
        }
    }

//====================Mazání coinů po době======================
for(int i = coin.Count -1; i >=0; i--)
    {
        if(cas >= coin[i].life)
        {
            coin.RemoveAt(i);
            continue;
        }

        if(coin[i].x == playerX && coin[i].y == playerY)
        {
            coin.RemoveAt(i);
            score++;
            continue;
        }
            
    }




    // vstup hráče
    if (Console.KeyAvailable)
    {
        ConsoleKey key = Console.ReadKey(true).Key; // místo ConsoleKey lze napsat key a ono si to ten datový typ přiřadí samo (var), ale radši jsem to napsal takhle že něco takovýho taky existuje

        if (key == ConsoleKey.Escape)
        hraBezi = false;  //zastaví cyklus hry while

        if (key == ConsoleKey.UpArrow) playerY--;
        if (key == ConsoleKey.DownArrow) playerY++;
        if (key == ConsoleKey.LeftArrow) playerX--;
        if (key == ConsoleKey.RightArrow) playerX++;
    }

if (playerY < 1) playerY = 1;        // horní okraj - kolize
if (playerY > 18) playerY = 18;      // dolní okraj - kolize
if (playerX < 1) playerX = 1;        // levý okraj - kolize
if (playerX > 38) playerX = 38;      // pravý okraj - kolize

    // vykreslení
    Console.WriteLine("Čas: " + cas + " ms");

    for (int radek = 0; radek < vyska; radek++)
    {
        for (int sloupec = 0; sloupec < sirka; sloupec++)
        {
            bool vykresleno = false;

            if (radek == 0 || radek == vyska -1 || sloupec == 0 || sloupec == sirka -1) // mapa
            {
                Console.Write("*");
                vykresleno = true;
            }
            else if (sloupec == playerX && radek == playerY) // hráč
            { 
            Console.Write("o");
            vykresleno = true;
            }
            else // překážky
            {
                foreach(var c in coin)
                {
                    if(c.x == sloupec && c.y == radek)
                    {
                        Console.Write("@");
                        vykresleno = true;
                    }
                }
            }
            
            if(!vykresleno) //překážky
            {
                foreach (var p in prekazky)
                {
                    if (p.x == sloupec && p.y == radek)
                    {
                        Console.Write("<");
                        vykresleno = true;
                        break;
                    }
                }
            }



            if(!vykresleno) // to co nic není - prázdno
            Console.Write(".");
            
        }
        Console.WriteLine();
    }

Console.WriteLine("Stiskni ESC pro ukončení");
    Thread.Sleep(100);

    Console.WriteLine();
    Console.WriteLine("Tvoje skóre je: {0}", score);
}

Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine("        Ukončili jste hru");
Console.WriteLine("===================================");
