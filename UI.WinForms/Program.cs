using Application.Equip.Services;
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

            IDataLayer dataLayer = new DataLayerInMemory();

            IEquipService equipService = new EquipService(dataLayer);

            WinFormsApp.Run(new Main(equipService));
        }
    }
}