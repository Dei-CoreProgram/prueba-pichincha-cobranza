namespace CobranzaApi.Models;

public class ClienteResumenDto
{
    public int CodigoCliente { get; set; }
    public string NombreCompleto { get; set; } = string.Empty;
    public string IdentificacionCliente { get; set; } = string.Empty;
    public string TipoIdentificacion { get; set; } = string.Empty;
    public int TotalOperaciones { get; set; }
    public int MayorMora { get; set; }
    public int OperacionMayorMora { get; set; }
}