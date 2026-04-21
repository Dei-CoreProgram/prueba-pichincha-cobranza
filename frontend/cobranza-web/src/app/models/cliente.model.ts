export interface ClienteResumen {
  codigoCliente: number;
  nombreCompleto: string;
  identificacionCliente: string;
  tipoIdentificacion: string;
  totalOperaciones: number;
  mayorMora: number;
  operacionMayorMora: number;
}