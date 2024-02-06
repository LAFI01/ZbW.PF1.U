using MB01.A8_2;
using MB01.InvertWord;

namespace MB01
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

            //Application.Run(new A4_1_4());

            //Application.Run(new A8_2_1());
            Application.Run(new InvertWord.InvertWord());

        }
    }
}