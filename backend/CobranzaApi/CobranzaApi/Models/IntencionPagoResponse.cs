namespace CobranzaApi.Models;

public class IntencionPagoResponse
{
    public bool Ok { get; set; }
    public string Mensaje { get; set; } = string.Empty;
    public string NumeroGestion { get; set; } = string.Empty;
}