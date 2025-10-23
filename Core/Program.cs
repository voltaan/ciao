using Cosmos.System;

namespace ciao.Core;

public class Program : Kernel
{

    protected override void BeforeRun()
    {
        Init initSystem = new Init(new(1, "init", "Init system"));
    }

    protected override void Run()
    {
    }
}
