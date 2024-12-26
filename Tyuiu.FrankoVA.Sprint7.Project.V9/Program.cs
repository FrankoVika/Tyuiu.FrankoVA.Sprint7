namespace Tyuiu.FrankoVA.Sprint7.Project.V9
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormGlav());
            Application.Run(new FormMain());
            FormMain fmen = new FormMain();
            fmen.Visible = false;
            

        }
    }
}