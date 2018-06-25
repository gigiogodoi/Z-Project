using CMCVirtual.IoC;
using CMCVirtual.Mappers;
using System;
using System.Windows.Forms;

namespace CMCVirtual.App
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AutoMapperConfig.RegisterMappings();
            CastleWindsorInjector.Register();
            Application.Run(new FormCMC());
            //Application.Run(new FormSetStation());
        }
    }
}
