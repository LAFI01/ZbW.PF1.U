using MB07.HandtaschenBeispiel;
using MB07.TiermarktBeispiel;
using MB07.ReferenzBeispiel;
using MB07.RezeptbuchBeispiel;

namespace MB07
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

            // Application.Run(new Tiermarkt());
            Application.Run(new RecipeBook());

            // Application.Run(new ReferenceExampleView());
            //Application.Run(new Handtaschenverwaltung());

        }
    }
}