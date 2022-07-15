namespace PF_Citamedica
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
            //Application.Run(new AForm1());
            //Application.Run(new Wan_Cita());
            //Application.Run(new Wan_Consulta());
            //Application.Run(new Wan_Paciente());
            //Application.Run(new LOGUIN ());
            //Application.Run(new Form4());
            //Application.Run(new M_Secretaria());
            Application.Run(new WG_secre());
        }
    }
}