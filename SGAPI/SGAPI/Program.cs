namespace SGAPI
{
    internal static class Program
    {
        // inicio del programa
        [STAThread]
        static void Main()
        {
            // iniciar configuraciones de windows forms
            ApplicationConfiguration.Initialize();

            // crear base de datos sqlite
            BaseDatosSQLite.Inicializar();

            // iniciar backups automáticos
            BackupHelper.IniciarSistemaBackups();

            // cargar pines sqlite
            BaseDatos.Pines = BaseDatosSQLite.CargarPines();

            // abrir login
            Application.Run(new FormLogin());

          
        }
    }
}