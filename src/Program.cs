using System.Diagnostics;

internal class Program
{
    private static void Main(string[] args)
    {
        string QueueName = args[1];
        string QueueCapacity = args[3];
        Console.WriteLine("----------------------------------------------------------------------------------------------------");
        Console.WriteLine("Source code found at: https://github.com/0xFLOATINGPOINT/Renderite.Proxy");
        Console.WriteLine("Licensed : MIT");
        Console.WriteLine(string.Empty);
        Console.WriteLine($"QueueName: {QueueName}");
        Console.WriteLine($"QueueCapacity: {QueueCapacity}");
        //Process process = new Process();
        //process.StartInfo.UseShellExecute = false;
        //process.StartInfo.RedirectStandardInput = true;
        //process.StartInfo.FileName = "C:\\Windows\\System32\\clip.exe";
        //process.Start();
        //process.StandardInput.Write(QueueName);
        //process.StandardInput.Close();
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}