using Projet_4_etoiles.Business.Services;

namespace Projet_4_etoiles
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

            MainService.GetInstance().StartApplication();
            
        }
    }
}