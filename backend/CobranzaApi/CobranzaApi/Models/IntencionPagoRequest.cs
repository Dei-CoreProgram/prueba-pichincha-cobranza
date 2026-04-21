namespace CobranzaApi.Models;

public class IntencionPagoRequest
{
    public int CodigoCliente { get; set; }
    public int OperacionId { get; set; }
    public decimal MontoPropuesto { get; set; }
    public int PlazoMeses { get; set; }
    public string Telefono { get; set; } = string.Empty;
    public string Correo { get; set; } = string.Empty;
    public string Observacion { get; set; } = string.Empty;
}