// Console Games , David Almkvist 22 - sep
    
// The game list                                        // add new games here 
string[] gameName_nr1 = new string[2];
gameName_nr1[0] = "Snake";
gameName_nr1[1] = " - ";





DisplayTitle();

DisplayMenu();







void DisplayTitle()
{
    Console.WriteLine("  ______                                      __                ______                                          \r" +
        "\n /      \\                                    |  \\              /      \\                                         \r" +
        "\n|  ▓▓▓▓▓▓\\ ______  _______   _______  ______ | ▓▓ ______      |  ▓▓▓▓▓▓\\ ______  ______ ____   ______   _______ \r" +
        "\n| ▓▓   \\▓▓/      \\|       \\ /       \\/      \\| ▓▓/      \\     | ▓▓ __\\▓▓|      \\|      \\    \\ /      \\ /       \\\r" +
        "\n| ▓▓     |  ▓▓▓▓▓▓\\ ▓▓▓▓▓▓▓\\  ▓▓▓▓▓▓▓  ▓▓▓▓▓▓\\ ▓▓  ▓▓▓▓▓▓\\    | ▓▓|    \\ \\▓▓▓▓▓▓\\ ▓▓▓▓▓▓\\▓▓▓▓\\  ▓▓▓▓▓▓\\  ▓▓▓▓▓▓▓\r" +
        "\n| ▓▓   __| ▓▓  | ▓▓ ▓▓  | ▓▓\\▓▓    \\| ▓▓  | ▓▓ ▓▓ ▓▓    ▓▓    | ▓▓ \\▓▓▓▓/      ▓▓ ▓▓ | ▓▓ | ▓▓ ▓▓    ▓▓\\▓▓    \\ \r" +
        "\n| ▓▓__/  \\ ▓▓__/ ▓▓ ▓▓  | ▓▓_\\▓▓▓▓▓▓\\ ▓▓__/ ▓▓ ▓▓ ▓▓▓▓▓▓▓▓    | ▓▓__| ▓▓  ▓▓▓▓▓▓▓ ▓▓ | ▓▓ | ▓▓ ▓▓▓▓▓▓▓▓_\\▓▓▓▓▓▓\\\r" +
        "\n \\▓▓    ▓▓\\▓▓    ▓▓ ▓▓  | ▓▓       ▓▓\\▓▓    ▓▓ ▓▓\\▓▓     \\     \\▓▓    ▓▓\\▓▓    ▓▓ ▓▓ | ▓▓ | ▓▓\\▓▓     \\       ▓▓\r" +
        "\n  \\▓▓▓▓▓▓  \\▓▓▓▓▓▓ \\▓▓   \\▓▓\\▓▓▓▓▓▓▓  \\▓▓▓▓▓▓ \\▓▓ \\▓▓▓▓▓▓▓      \\▓▓▓▓▓▓  \\▓▓▓▓▓▓▓\\▓▓  \\▓▓  \\▓▓ \\▓▓▓▓▓▓▓\\▓▓▓▓▓▓▓ \r" +
        "\n                                                                                                                \r" +
        "\n                                                                                      Made by: David Almkvist");
}

void DisplayMenu()
{
    Console.WriteLine("Choose a game to play:");
    Console.WriteLine();

    PrintGamesNames();

}

void PrintGamesNames()
{
    for (int i = 0; i < gameName_nr1.Length; i++)
    {
        Console.WriteLine($"{i + 1}. {gameName_nr1[i]} ");

    }
}