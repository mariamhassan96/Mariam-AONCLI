using System;
using System.Diagnostics;

class Program
{
    static void Main()
    {
        // Command to run the AON CLI
        string command = "npx";
        string args = "aon-cli";

        // Initialize the process
        ProcessStartInfo processStartInfo = new ProcessStartInfo()
        {
            FileName = command,
            Arguments = args,
            RedirectStandardOutput = true, // Redirect the output to capture it
            UseShellExecute = false,      // Do not use shell execution (needed to capture output)
            CreateNoWindow = true         // Do not show the console window
        };
        // Start the process
        Process process = new Process
        {
            StartInfo = processStartInfo
        };

        try
        {
            process.Start();

            // Capture and display the output (optional)
            string output = process.StandardOutput.ReadToEnd();
            Console.WriteLine(output);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error running AON CLI: " + ex.Message);
        }
    }
}

