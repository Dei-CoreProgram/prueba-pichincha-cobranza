namespace CobranzaApi.Models;

public class Operacion
{
    public int OperacionId { get; set; }
    public int CodigoCliente { get; set; }
    public int Mora { get; set; }
    public string Estado { get; set; } = string.Empty;
}