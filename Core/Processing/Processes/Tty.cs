using System;
using Kernel = ciao.Core.Program;

namespace ciao.Core.Processing;

public class Tty : Process
{
    public Tty() : base("tty", "TeleTypeWriter")
    {

    }
    public override string Execute()
    {
        try
        {
            Console.Write(">");
            switch (Console.ReadLine())
            {
                default:
                    Console.WriteLine("Command not found.");
                    break;
                case "top":
                    foreach (Process process in Kernel.systemProcessManager.processes)
                    {
                        Console.WriteLine(process.pid + " " + process.name + " " + process.description);
                    }
                    break;
            }
            return "";
        }
        catch (Exception e)
        {
            return e.Message;
        }
    }
}
