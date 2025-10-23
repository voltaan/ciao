using System;

namespace ciao.Core;

public class Init
{
    Angel angel;
    public AngelManager angelManager;

    public Init(Angel angel)
    {
        angelManager = new AngelManager();
        Console.WriteLine();
        Console.Write("Welcome to ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ciao");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("!");
        Console.WriteLine();
        Angel example = new Angel(2, "example", "test");
    }
    public void PreBoot()
    {
    }

    static void UnitStarted(Angel angel)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("[   ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("OK");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("   ] ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Started ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(angel.name);
        Console.ResetColor();
    }
}
