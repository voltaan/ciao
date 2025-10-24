using System;

namespace ciao.Processing;

public class Demon
{
    public string name, description;
    public readonly int pid;
    Action action;

    public Demon(string name, string description, int pid, Action action = null)
    {
        this.name = name;
        this.description = description;
        this.pid = pid;
        this.action = action;
    }

    public virtual int Execute()
    {
        try
        {
            action();
            return 0;
        }
        catch
        {
            return 1;
        }
    }
}
