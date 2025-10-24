using System.Collections.Generic;

namespace ciao.Core;

public class Logger
{
    List<string> errorList;
    List<string> warningList;
    List<string> infoList;
    public Logger()
    {
        errorList = new();
        warningList = new();
        infoList = new();
    }
    public void LogError(string error)
    {
        errorList.Add("Error: " + error);
    }
    public void LogWarning(string warning)
    {
        warningList.Add("Warning: " + warning);
    }
    public void LogInfo(string info)
    {
        infoList.Add("Information: " + info);
    }
}
