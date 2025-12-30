string again = "a";
        while (again == "a")
        {
            Console.Clear();
            Console.WriteLine("************************************************");
            Console.WriteLine("*********** Součet a součin cifer  *************");
            Console.WriteLine("************************************************");
            Console.WriteLine("**************** Pavel Bulíř *******************");
            Console.WriteLine("***************** 2.10.2025 ********************");
            Console.WriteLine("************************************************");
            Console.WriteLine();

            Console.Write("Zadejte celé číslo: ");
            string vstup = Console.ReadLine();

            // Ošetření, jestli je to číslo
            int number;
            while (!int.TryParse(vstup, out number))
            {
                Console.Write("Nezadali jste celé číslo. Zadejte ho znovu: ");
                vstup = Console.ReadLine();
            }

            // Odstranění záporného znaménka
            if (vstup.StartsWith("-"))
                vstup = vstup.Substring(1);

            int soucet = 0;

            //Tady je "jiný" způsob — práce s řetězcem
            foreach (char c in vstup)
            {
                soucet += (int)char.GetNumericValue(c);
            }

            Console.WriteLine();
            Console.WriteLine($"Součet cifer čísla {number} je {soucet}"); 

            Console.WriteLine();
            Console.WriteLine("Pro opakování programu stiskněte klávesu a");
            again = Console.ReadLine();
        }