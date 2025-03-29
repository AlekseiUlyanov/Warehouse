using Application.Equips.Services;
using Data;
using Data.InMemory;
using UI.WinForms.Forms;
using WinFormsApp = System.Windows.Forms.Application;

namespace UI.WinForms
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

            IEquipRepository equipRepository = new EquipRepository();

            IEquipService equipService = new EquipService(equipRepository);

            WinFormsApp.Run(new Main(equipService));
        }
    }
}