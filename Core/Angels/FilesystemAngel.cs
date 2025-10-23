using System;
using Cosmos.System.FileSystem;
using Cosmos.System.FileSystem.VFS;

namespace ciao.Core.Angels;

public class FilesystemAngel : Angel
{
    public CosmosVFS cosmosVFS;
    public bool filesystemInitialized;
    public FilesystemAngel() : base("filesystem", "initialization of VFS (Virtual File System")
    {

    }

    public override int Start()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[ ");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("WARN");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write(" ]");
            Console.Write(" Do you want to initialize Cosmos Virtual File System? If unsure, press enter (y/n): ");
            switch (Console.ReadLine())
            {
                default:
                    filesystemInitialized = false;
                    return 1;
                case "y":
                    InitializeFilesystem();
                    return 0;
            }
        }
        catch
        {
            filesystemInitialized = false;
            return 1;
        }
    }
    void InitializeFilesystem()
    {
        cosmosVFS = new();
        VFSManager.RegisterVFS(cosmosVFS);
    }
}
