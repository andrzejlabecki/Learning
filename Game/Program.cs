// See https://aka.ms/new-console-template for more information
Console.WriteLine("The dice is cast!");
Console.WriteLine("Guess the number from 2 to 12.");

Random random = new Random();

int diceNumber = random.Next(2, 13);
string? input = null;
int attempt = 0;
int inputNum = 0;
bool result = false;

while (true)
{
    Console.WriteLine("Attempt " + (++attempt).ToString());
    input = Console.ReadLine();

    result = int.TryParse(input, out inputNum);

    if (result)
    {
        if (inputNum < 2 || inputNum > 12)
            Console.WriteLine("Your input '" + input + "' is not 2...12 Integer!");
        else if (diceNumber != inputNum)
            Console.WriteLine("Your input '" + input + "' is not correct dice number!");
        else
            break;
    }
    else
        Console.WriteLine("Your input '" + input + "' is not Integer!");
}

Console.WriteLine("Congratulations! Your number '" + diceNumber.ToString() + "' is correct.");