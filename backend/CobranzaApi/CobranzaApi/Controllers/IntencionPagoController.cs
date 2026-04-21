using CobranzaApi.Data;
using CobranzaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CobranzaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class IntencionPagoController : ControllerBase
{
    private readonly FakeDataStore _store;

    public IntencionPagoController(FakeDataStore store)
    {
        _store = store;
    }

    [HttpPost]
    public ActionResult<IntencionPagoResponse> Registrar(IntencionPagoRequest request)
    {
        var cliente = _store.Clientes.FirstOrDefault(c => c.CodigoCliente == request.CodigoCliente);
        if (cliente is null)
        {
            return NotFound(new IntencionPagoResponse
            {
                Ok = false,
                Mensaje = "Cliente no encontrado"
            });
        }

        var operacion = _store.Operaciones.FirstOrDefault(o =>
            o.CodigoCliente == request.CodigoCliente &&
            o.OperacionId == request.OperacionId);

        if (operacion is null)
        {
            return NotFound(new IntencionPagoResponse
            {
                Ok = false,
                Mensaje = "Operación no encontrada"
            });
        }

        return Ok(new IntencionPagoResponse
        {
            Ok = true,
            Mensaje = $"Intención de pago registrada correctamente para {cliente.NombreCompleto}",
            NumeroGestion = $"GES-{DateTime.Now:yyyyMMddHHmmss}"
        });
    }
}