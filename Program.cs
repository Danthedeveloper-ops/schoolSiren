// See https://aka.ms/new-console-template for more information


Random numberGen = new Random();


int rollOne = 0;
int rollTwo = 1;
int attempts = 0;
Console.WriteLine("press enter to roll a die");

while (rollOne != rollTwo )
{Console.ReadKey();

    rollOne = numberGen.Next(1, 7);
    rollTwo = numberGen.Next(1, 7);
    Console.WriteLine("you rolled: " + rollOne);
        Console.WriteLine("Roll 2: " + rollTwo + "\n");
    attempts++;
}

Console.WriteLine("it took you " + attempts + " attempts to roll a six");

Console.Read();
