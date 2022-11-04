// See https://aka.ms/new-console-template for more information


Random numberGen = new Random();


int roll = 0;
int attempts = 0;

while (roll != 6)
{
    roll = numberGen.Next(1, 7);
    Console.WriteLine("you rolled: " + roll);
    attempts++;
}

Console.WriteLine("it took you " + attempts + " attempts to roll a six");

Console.Read();
