using System.Runtime.InteropServices;

namespace RockPaperScissors_
{
    internal static class Program
    {
        internal static class NativeMethods
        {
            [DllImport("kernel32.dll")]
            internal static extern Boolean AllocConsole();
        }

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            NativeMethods.AllocConsole();
            Console.WriteLine("Please select:");
            Console.WriteLine("Press 1 and Enter to Exit");
            Console.WriteLine("or any other key And Enter to Play");
            var command = Console.ReadLine();
            if (command.Trim() == "1")
            {
                System.Environment.Exit(0);
            }
            else
            {
                // To customize application configuration such as set high DPI settings or default font,
                // see https://aka.ms/applicationconfiguration.
                ApplicationConfiguration.Initialize();
                Application.Run(new FrmGame());
            }
        }
    }
}