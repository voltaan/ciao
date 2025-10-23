using System;
using ciao.Core.Angels;

namespace ciao.Core;

public class Init
{
    public AngelManager angelManager;

    public Init()
    {
        angelManager = new AngelManager();
        Console.WriteLine();
        Console.Write("Welcome to ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ciao");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("!");
        Console.WriteLine();
        FilesystemAngel filesystemAngel = new();
        angelManager.RegisterAngel(filesystemAngel);
        foreach (Angel angel in angelManager.angels)
        {
            if (angel.Start() == 0)
            {
                AngelStarted(angel);
            }
            else if (angel.Start() == 1)
            {
                AngelFailed(angel);
            }
        }
    }

    static void AngelStarted(Angel angel)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("[  ");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write("OK");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("  ] ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Started ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(angel.name);
        Console.ResetColor();
    }
    static void AngelFailed(Angel angel)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("[ ");
        Console.ForegroundColor = ConsoleColor.Red;
        Console.Write("FAIL");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" ] ");
        Console.ForegroundColor = ConsoleColor.Gray;
        Console.Write("Failed to start ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(angel.name);
        Console.ResetColor();
    }
}
