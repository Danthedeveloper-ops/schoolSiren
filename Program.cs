// See https://aka.ms/new-console-template for more information


Random numberGen = new Random();


int roll = 0;
int attempts = 0;

while (roll != 0)
{
    roll = numberGen.Next(1, 2);
}



Console.Read();
