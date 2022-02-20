// See https://aka.ms/new-console-template for more information
Console.WriteLine("The die has been cast!");
Console.WriteLine("Guess the number from 1 to 6.");

Random random = new Random();

int diceNumber = random.Next(1, 7);
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
        if (inputNum < 1 || inputNum > 7)
            Console.WriteLine("Your input '" + input + "' is not 1...2 Integer!");
        else if (diceNumber != inputNum)
            Console.WriteLine("Your input '" + input + "' is not correct dice number!");
        else
            break;
    }
    else
        Console.WriteLine("Your input '" + input + "' is not Integer!");
}

Console.WriteLine("Congratulations! Your number '" + diceNumber.ToString() + "' is correct.");