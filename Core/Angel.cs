using System;

namespace ciao.Core;

public class Angel
{
    public string name, desc;
    Action action;

    public Angel(string name, string desc = "", Action action = null)
    {
        this.name = name;
        this.desc = desc;
        this.action = action;
    }

    public virtual int Start()
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
