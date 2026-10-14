using PrestamosBiblioteca.Aplicacion;
using PrestamosBiblioteca.Persistencia;

namespace PrestamosBiblioteca;

internal class Program
{
    private static void Main(string[] args)
    {
        // Define el nombre del archivo de la base de datos SQLite
        string cadenaConexion = "Data Source=biblioteca.db";

        try
        {
            // 1. Crea la base de datos y las tablas automáticamente
            InicializadorBaseDatos.Inicializar(cadenaConexion);

            // 2. Instancia la capa de datos y la capa de menú
            var repositorio = new RepositorioBiblioteca(cadenaConexion);
            var menu = new MenuBiblioteca(repositorio);

            // 3. Ejecuta la interfaz de consola
            menu.Ejecutar();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error critico al iniciar la aplicacion: {ex.Message}");
        }
    }
}