using Cosmos.System;
using ciao.Processing;

namespace ciao.Core;

public class Program : Kernel
{
    public static DemonManager demonManager;
    public static Logger systemLogger;

    protected override void BeforeRun()
    {
        systemLogger = new();
        Init initSystem = new Init(systemLogger);
    }

    protected override void Run()
    {
    }
}
