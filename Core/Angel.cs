namespace ciao.Core;

public class Angel
{
    public int pid;
    public string name, desc;

    public Angel(int pid, string name, string desc = "")
    {
        this.pid = pid;
        this.name = name;
        this.desc = desc;
    }
}
