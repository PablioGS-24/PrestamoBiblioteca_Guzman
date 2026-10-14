namespace PrestamosBiblioteca.Dominio;

internal class Lector : Persona
{
    public string Codigo { get; set; }

    public Lector(string codigo, string nombre, string correo, string telefono)
        : base(nombre, correo, telefono)
    {
        Codigo = codigo;
    }

    public override string ObtenerInformacion()
    {
        return $"[Lector] Código: {Codigo} | Nombre: {Nombre} | Correo: {Correo} | Telefono: {Telefono}";
    }
}