namespace MB06
{
    using MB06.A13_1_1;
    using MB06.Haustierverwaltung_1;
    using MB06.Haustierverwaltung_2;
    using MB06.Person_static;

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

            //Application.Run(new MathView());
            Application.Run(new Haustierverwaltung1());
           //Application.Run(new Haustierverwaltung2());
           //Application.Run(new CreatePerson());
        }
    }
}