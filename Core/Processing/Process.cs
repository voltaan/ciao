using System;

namespace ciao.Core.Processing;

public class Process
{
    public string name, description;
    public int pid;
    Action action;

    public Process(string name, string description, Action action = null)
    {
        this.name = name;
        this.description = description;
    }
    public virtual string Execute()
    {
        try
        {
            action();
            return "";
        }
        catch (Exception e)
        {
            return "Exception while running process " + pid + " (" + name + "): " + e.Message;
        }
    }
}
