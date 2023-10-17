Log log = new();
// * Single call delegate
//LogDelegate logDelegate = new(log.LogTextToConsole);
//logDelegate("Log number one");

// Multi call delegate
LogDelegate logTextToConsoleDel, logTextToFileDel;
logTextToConsoleDel = log.LogTextToConsole;
logTextToFileDel = log.LogTextToFile;
LogDelegate multiCallDel = logTextToConsoleDel + logTextToFileDel;
multiCallDel($"A log with a ranom number. {Random.Shared.Next(1, 70)}");


Console.ReadKey();

// Static methods
// void LogTextToConsole(string message)
// {
//     Console.WriteLine($"{DateTime.Now.ToShortDateString()} : {message}");
// }

// void LogTextToFile(string message)
// {
//     using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
//     {
//         sw.WriteLine($"{DateTime.Now.ToShortDateString()} : {message}");
//     }
// }


// this delegate can reference methods that return nothing (void)
// that also has a single string parameter
// * A delegate can reference both instance and static methods
delegate void LogDelegate(string text);

class Log
{
    // Instance methods
    public void LogTextToConsole(string message)
    {
        Console.WriteLine($"{DateTime.Now.ToShortDateString()} : {message}");
    }

    public void LogTextToFile(string message)
    {
        using (StreamWriter sw = new StreamWriter(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Log.txt"), true))
        {
            sw.WriteLine($"{DateTime.Now.ToShortDateString()} : {message}");
        }
    }
}