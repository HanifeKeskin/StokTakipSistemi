using System;
using System.Windows.Forms;
using DevExpress.Skins;
using DevExpress.LookAndFeel;
using System.Reflection;
using System.ComponentModel;
using DevExpress.XtraEditors;
using StokTakip1.Views;
using StokTakip1.Views.UserLogins;
using StokTakip1.Views.Personel;

namespace StokTakip1
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Assembly asm = typeof(DevExpress.UserSkins.OfficeSkins).Assembly;
            DevExpress.Skins.SkinManager.Default.RegisterAssembly(asm);

            SkinManager.EnableFormSkins();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmLogin());
        }
    }
}
