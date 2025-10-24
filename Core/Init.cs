using System;
using ciao.Core.Angels;
using ciao.Processing;

namespace ciao.Core;

public class Init : Demon
{
    public AngelManager angelManager;
    Demon initDemon;
    Logger initLogger;

    public Init(Logger logger) : base("init", "Initialization system")
    {
        angelManager = new AngelManager();
        Console.WriteLine();
        Console.Write("Welcome to ");
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.Write("ciao");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write("!");
        Console.WriteLine();
        //angelManager.RegisterAngel(new FilesystemAngel());
        foreach (Angel angel in angelManager.angels)
        {
            int exitCode = angel.Start();
            if (exitCode == 0)
            {
                AngelStarted(angel);
                initLogger.LogInfo(angel.name + " angel started.");
            }
            else if (exitCode == 1)
            {
                AngelFailed(angel);
                initLogger.LogError(angel.name + " failed to start.");
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
