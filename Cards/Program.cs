// See https://aka.ms/new-console-template for more information
var cards = new List<string>{ "R1", "R2", "R3", "R4", "R5", "R6", "R7", "R8", "R9", "R10", "G1", "G2", "G3", "G4", "G5", "G6", "G7", "G8", "G9", "G10", "B1", "B2", "B3", "B4", "B5", "B6", "B7", "B8", "B9", "B10", "W1", "W2", "W3", "W4", "W5", "W6", "W7", "W8", "W9", "W10" };

string[] command = Console.ReadLine().Split();

if (command[0] == "start" && command[1] != null && command[2] != null)
{
    int N = Int32.Parse(command[1]);
    int C = Int32.Parse(command[2]);
    if (N <= 40)
    {
        if (C <= 40)
        {
            for(int i = 1; i <= C; i++)
            {
                Console.Write($"Игрок: {i}, получил карты: ");
                var random = new Random();
                for(int j = 0; j < N; j++)
                {
                    int index = random.Next(cards.Count);
                    Console.Write($"{cards[index]} ");
                }
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("Error: Игроков слишком много! Карт не хватит игрокам!");
        }

    }
    else
    {
        Console.WriteLine("Error: Столько карт нет в колоде!");
    }
}
else if(command[0] == "get-cards" && command[1] != null)
{
    int C = Int32.Parse(command[1]);
    int N = 3;
    if (C <= 40)
    {
        Console.Write($"Игрок: {C}, получил карты: ");
        var random = new Random();
        for (int j = 0; j < N; j++)
        {
            int index = random.Next(cards.Count);
            Console.Write($"{cards[index]} ");
        }
    }
    else
    {
        Console.WriteLine("Error: Игроков слишком много! Карт не хватит игрокам!");
    }
}
else
{
    Console.WriteLine("Error: Данной команды не существует, либо допущены ошибки!");
}
