using Cosmos.System;

namespace ciao.Core
{
    public class Program : Kernel
    {

        protected override void BeforeRun()
        {
            System.Console.WriteLine("Welcome to ciao!");
        }

        protected override void Run()
        {
        }
    }
}
