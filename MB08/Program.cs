using MB08.A12_1;
using MB08.A12_2;
using MB08.HandtaschenBeispiel;

namespace MB08
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Uhr1());
            //Application.Run(new Uhr2());
            //Application.Run(new Handtaschenverwaltung());


        }
    }
}