namespace CobranzaApi.Models;

public class Cliente
{
    public string CodigoEmpresaCedente { get; set; } = string.Empty;
    public string IdentificacionCliente { get; set; } = string.Empty;
    public string TipoIdentificacion { get; set; } = string.Empty;
    public string NombreCompleto { get; set; } = string.Empty;
    public int CodigoCliente { get; set; }
}