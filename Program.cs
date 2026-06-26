using SpotifyWindowsForm.Models;

namespace SpotifyWindowsForm
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            Client client = new Client();
            client.Start();

            Application.Run(new MainMenuForm());
        }
    }
}