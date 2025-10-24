using System.Collections.Generic;
using ciao.Core.Processing;

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
    public void LogError(string error, Process relatedProcess)
    {
        errorList.Add("Error in process " + relatedProcess.pid + " (" + relatedProcess.name + "): " + error);
    }
    public void LogWarning(string warning, Process relatedProcess)
    {
        warningList.Add("Warning in process " + relatedProcess.pid + " (" + relatedProcess.name + "): " + warning);
    }
    public void LogInfo(string info, Process relatedProcess)
    {
        infoList.Add("Information in process " + relatedProcess.pid + " (" + relatedProcess.name + "): " + info);

    }
}
