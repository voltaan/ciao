using System.Collections.Generic;

namespace ciao.Core;

public class AngelManager
{
    public List<Angel> angels;

    public AngelManager()
    {
        angels = new List<Angel>();
    }

    public void RegisterAngel(Angel angel)
    {
        angels.Add(angel);
    }
}
