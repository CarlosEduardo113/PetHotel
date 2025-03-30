        // PetHotel - Exercício 4 da Lista 2
      
      
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("+=========================================================+");
        Console.WriteLine("|                 Pet Hotel \"Nem um pio\"                  |");
        Console.WriteLine("+=========================================================+");
        Console.ResetColor();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("| Espécie: ");
        Console.ResetColor();
        string especie = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("| Raça: ");
        Console.ResetColor();
        string raca = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("| Atende pela alcunha de: ");
        Console.ResetColor();
        string alcunha = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("| Idade: ");
        Console.ResetColor();
        string idade = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("| Pelagem/cor: ");
        Console.ResetColor();
        string pelagem = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("+=========================================================+");
        Console.WriteLine("| Espécie: ............{0,-5} | Raça: ............{1,-10} |", especie.ToUpper(), raca.ToUpper());
        Console.WriteLine("+=========================================================+");
        Console.WriteLine("| Atende pela alcunha de: {0,-25} |", alcunha.ToUpper());
        Console.WriteLine("| Idade: {0,-3} ano(s) | Pelagem/cor: {1,-15} |", idade, pelagem.ToUpper());
        Console.WriteLine("+=========================================================+");

        Console.ResetColor();