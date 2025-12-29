

using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;

int playerX = 10;
int playerY = 10;
int cas = 0;

while (true)
{
    // časovač
    cas = cas + 100;

    // vstup hráče
    if (Console.KeyAvailable)
    {
        var key = Console.ReadKey(true).Key;

        if (key == ConsoleKey.Escape)
        break; 

        if (key == ConsoleKey.UpArrow) playerY--;
        if (key == ConsoleKey.DownArrow) playerY++;
        if (key == ConsoleKey.LeftArrow) playerX--;
        if (key == ConsoleKey.RightArrow) playerX++;
    }

    // vykreslení
    Console.Clear();
    Console.WriteLine("Čas: " + cas + " ms");





    for (int radek = 0; radek < 20; radek++)
    {
        for (int sloupec = 0; sloupec < 40; sloupec++)
        {
            if (radek == 0 || radek == 19 || sloupec == 0 || sloupec == 39) // mapa
            Console.Write("*");
            else if (sloupec == playerX && radek == playerY) //hřáč
            Console.Write("o");
            else
            Console.Write(".");    

            if(sloupec == playerX && radek == playerY && radek == 0) // hranice zeshora
            playerY++;        

            if(sloupec == playerX && radek == playerY && radek == 19) // hranice zezdola
            playerY--;

            if(sloupec == playerX && radek == playerY && sloupec == 0) // hranice zprava
            playerX++;

            if(sloupec == playerX && radek == playerY && sloupec == 39) // hranice zleva
            playerX--;   

            
        }
        Console.WriteLine();
    }

Console.WriteLine("Stiskni ESC pro ukončení");
    Thread.Sleep(100);
}
Console.WriteLine();
Console.WriteLine("===================================");
Console.WriteLine("        Ukončili jste hru");
Console.WriteLine("===================================");
