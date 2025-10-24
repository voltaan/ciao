using System.Collections.Generic;

namespace ciao.Processing;

public class DemonManager
{
    List<Demon> demons;

    public DemonManager()
    {
        demons = new();
    }

    public void RegisterDemon(Demon demon)
    {
        demons.Add(demon);
    }
    public void KillDemon(Demon demon)
    {
        demons.Remove(demon);
    }
    public void ExecuteAllDemons()
    {
        foreach (Demon demon in demons)
        {
            demon.Execute();
        }
    }
}
