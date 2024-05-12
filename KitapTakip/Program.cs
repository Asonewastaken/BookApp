namespace KitapTakip
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
            
            frmGiris giris = new frmGiris();

            if(giris.ShowDialog() == DialogResult.OK)
            {
                Application.Run(new frmAna());

            }
            else
            {
                Application.Exit();
            }
        }
    }
}