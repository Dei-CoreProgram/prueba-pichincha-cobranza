export interface IntencionPagoRequest {
  codigoCliente: number;
  operacionId: number;
  montoPropuesto: number;
  plazoMeses: number;
  telefono: string;
  correo: string;
  observacion: string;
}