namespace PrestamosBiblioteca.Dominio;

internal class Prestamo
{
    public int LectorId { get; set; }
    public int LibroId { get; set; }
    public DateTime FechaPrestamo { get; set; }
    public DateTime FechaLimite { get; set; }
    public DateTime? FechaDevolucion { get; set; }

    public bool EstaActivo => FechaDevolucion == null;

    public Prestamo(int lectorId, int libroId, DateTime fechaPrestamo, DateTime fechaLimite, DateTime? fechaDevolucion = null)
    {
        LectorId = lectorId;
        LibroId = libroId;
        FechaPrestamo = fechaPrestamo;
        FechaLimite = fechaLimite;
        FechaDevolucion = fechaDevolucion;
    }
}