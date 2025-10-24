using System.Collections.Generic;

namespace ciao.Core.Processing;

public class ProcessManager
{
    Logger logger;
    public List<Process> processes;
    int nextProcessId;

    public ProcessManager(Logger logger)
    {
        this.logger = logger;
        processes = new();
        nextProcessId = 0;
    }
    public void RegisterProcess(Process process)
    {
        process.pid = nextProcessId++;
        processes.Add(process);
    }
    public void UnregisterProcess(Process process)
    {
        processes.Remove(process);
    }
    public void Execute()
    {
        foreach (Process process in processes)
        {
            string code = process.Execute();
            if (code != "")
            {
                logger.LogError(code, process);
            }
        }
    }
}
