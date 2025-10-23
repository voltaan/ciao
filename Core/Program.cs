using Cosmos.System;

namespace ciao.Core;

public class Program : Kernel
{

    protected override void BeforeRun()
    {
        Init initSystem = new Init();
    }

    protected override void Run()
    {
    }
}
