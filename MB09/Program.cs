namespace MB09
{
    using MB09.Einstieg;
    using MB09.Haustierverwaltung_1;
    using MB09.MathBeispiel;
    using MB09.VererbungBeispiel;

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

            //Application.Run(new CalculatorForm());
            //Application.Run(new StaticExample());
            Application.Run(new Mediathek());

            //Application.Run(new Haustierverwaltung1());
            //Application.Run(new Haustierverwaltung2());
        }
    }
}