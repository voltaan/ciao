using System;

namespace ciao.Core;

public class Init
{
    public void PreBoot()
    {
        Console.WriteLine();
        Console.Write("Welcome to ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ciao");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("!");
        Console.WriteLine();
    }

    static void UnitStarted(Angel angel)
    {

    }
}
