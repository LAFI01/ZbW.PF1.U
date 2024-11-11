using MB03.A8_2;

namespace MB03
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
            
            //Application.Run(new A8_2_1());
            Application.Run(new MyStopwatch());


        }
    }
}