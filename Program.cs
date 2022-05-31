namespace CliffordAttractor
{
    internal static class Program
    {
        // the main entry point for the application
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}