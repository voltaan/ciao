using Cosmos.System;
using ciao.Core.Processing;

namespace ciao.Core;

public class Program : Kernel
{
    public static Logger systemLogger;
    public static ProcessManager systemProcessManager;

    protected override void BeforeRun()
    {
        systemLogger = new();
        systemProcessManager = new(systemLogger);
        systemProcessManager.RegisterProcess(new Tty());
    }

    protected override void Run()
    {
        systemProcessManager.Execute();
    }
}
