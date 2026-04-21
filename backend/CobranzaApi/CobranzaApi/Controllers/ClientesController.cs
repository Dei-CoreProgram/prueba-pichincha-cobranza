using CobranzaApi.Data;
using CobranzaApi.Models;
using Microsoft.AspNetCore.Mvc;

namespace CobranzaApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ClientesController : ControllerBase
{
    private readonly FakeDataStore _store;

    public ClientesController(FakeDataStore store)
    {
        _store = store;
    }

    [HttpGet]
    public ActionResult<IEnumerable<ClienteResumenDto>> Get()
    {
        var resultado = _store.Clientes
            .Select(c =>
            {
                var operacionesCliente = _store.Operaciones
                    .Where(o => o.CodigoCliente == c.CodigoCliente)
                    .ToList();

                var mayorMoraOp = operacionesCliente
                    .OrderByDescending(o => o.Mora)
                    .FirstOrDefault();

                return new ClienteResumenDto
                {
                    CodigoCliente = c.CodigoCliente,
                    NombreCompleto = c.NombreCompleto,
                    IdentificacionCliente = c.IdentificacionCliente,
                    TipoIdentificacion = c.TipoIdentificacion,
                    TotalOperaciones = operacionesCliente.Count,
                    MayorMora = mayorMoraOp?.Mora ?? 0,
                    OperacionMayorMora = mayorMoraOp?.OperacionId ?? 0
                };
            })
            .ToList();

        return Ok(resultado);
    }

    [HttpGet("{codigoCliente}/operaciones")]
    public ActionResult<IEnumerable<Operacion>> GetOperaciones(int codigoCliente)
    {
        var operaciones = _store.Operaciones
            .Where(x => x.CodigoCliente == codigoCliente)
            .ToList();

        return Ok(operaciones);
    }
}