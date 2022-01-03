// See https://aka.ms/new-console-template for more information

Console.Title = "Hello, World!";

DateTime dat = DateTime.Now;

//print current date and time and moves cursor to next line
Console.WriteLine("Current Date and time is : " + dat);

//prints text but keeps cursor in same line
Console.WriteLine("Press <Esc> to exit... ");

ConsoleKey key = ConsoleKey.Escape;
ConsoleKeyInfo keyInfo = new ConsoleKeyInfo();
char c = '\0';
int len = 0;
int firstLine = Console.CursorTop;
int lineCount = 1;
int currentLine = 0;

while (true)
{
    keyInfo = Console.ReadKey();
    key = keyInfo.Key;
    c = keyInfo.KeyChar;

    //run loop until Esc is pressed
    if (key == ConsoleKey.Escape)
        break;

    if (Terminal.Utility.IsPrintableCharacter(c))
        len++;

    //go to the next line, if Enter is pressed
    if (key == ConsoleKey.Enter)
    {
        Console.WriteLine("");
        len = 0;
        currentLine++;
        if (currentLine > lineCount)
            lineCount++;
    }

    if (key == ConsoleKey.LeftArrow && Console.CursorLeft > 0)
        Console.SetCursorPosition(Console.CursorLeft-1, Console.CursorTop);

    if (key == ConsoleKey.RightArrow && Console.CursorLeft < len)
        Console.SetCursorPosition(Console.CursorLeft + 1, Console.CursorTop);

    if (key == ConsoleKey.UpArrow && Console.CursorTop > firstLine)
        Console.SetCursorPosition(Console.CursorLeft, Console.CursorTop - 1);
}
