using CobranzaApi.Models;

namespace CobranzaApi.Data;

public class FakeDataStore
{
    public List<Cliente> Clientes { get; } =
    [
        new Cliente
        {
            CodigoEmpresaCedente = "BCE001",
            IdentificacionCliente = "1719531483",
            TipoIdentificacion = "CI",
            NombreCompleto = "DAVID ANIBAL CONDOR PAUCAR",
            CodigoCliente = 1
        },
        new Cliente
        {
            CodigoEmpresaCedente = "BCE001",
            IdentificacionCliente = "1712345678",
            TipoIdentificacion = "PA",
            NombreCompleto = "MARIA FERNANDA LOPEZ MOREIRA",
            CodigoCliente = 2
        },
        new Cliente
        {
            CodigoEmpresaCedente = "PCH002",
            IdentificacionCliente = "1723456789",
            TipoIdentificacion = "CI",
            NombreCompleto = "JORGE LUIS CHANGO QUISHPE",
            CodigoCliente = 3
        },
        new Cliente
        {
            CodigoEmpresaCedente = "PCH002",
            IdentificacionCliente = "0923456781",
            TipoIdentificacion = "PA",
            NombreCompleto = "ANDREA ESTEFANIA VERA CEDEÑO",
            CodigoCliente = 4
        },
        new Cliente
        {
            CodigoEmpresaCedente = "COB003",
            IdentificacionCliente = "1104567892",
            TipoIdentificacion = "CI",
            NombreCompleto = "CARLOS EDUARDO SANTOS JARAMILLO",
            CodigoCliente = 5
        },
        new Cliente
        {
            CodigoEmpresaCedente = "COB003",
            IdentificacionCliente = "1205678912",
            TipoIdentificacion = "PA",
            NombreCompleto = "LUISA ALEJANDRA PILATAXI GUAMBO",
            CodigoCliente = 6
        }
    ];

    public List<Operacion> Operaciones { get; } =
    [
        new Operacion { OperacionId = 1001, CodigoCliente = 1, Mora = 145, Estado = "Mora" },
        new Operacion { OperacionId = 1002, CodigoCliente = 1, Mora = 35, Estado = "Mora" },

        new Operacion { OperacionId = 2001, CodigoCliente = 2, Mora = 180, Estado = "Mora" },
        new Operacion { OperacionId = 2002, CodigoCliente = 2, Mora = 10, Estado = "Al día" },

        new Operacion { OperacionId = 3001, CodigoCliente = 3, Mora = 90, Estado = "Castigada" },
        new Operacion { OperacionId = 3002, CodigoCliente = 3, Mora = 20, Estado = "Mora" },

        new Operacion { OperacionId = 4001, CodigoCliente = 4, Mora = 16, Estado = "Mora" },
        new Operacion { OperacionId = 4002, CodigoCliente = 4, Mora = 0, Estado = "Al día" },

        new Operacion { OperacionId = 5001, CodigoCliente = 5, Mora = 60, Estado = "Mora" },
        new Operacion { OperacionId = 5002, CodigoCliente = 5, Mora = 5, Estado = "Al día" },

        new Operacion { OperacionId = 6001, CodigoCliente = 6, Mora = 121, Estado = "Mora" },
        new Operacion { OperacionId = 6002, CodigoCliente = 6, Mora = 18, Estado = "Mora" }
    ];
}