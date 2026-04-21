import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { ClienteResumen } from '../models/cliente.model';
import { Operacion } from '../models/operacion.model';
import { IntencionPagoRequest } from '../models/intencion-pago.model';

@Injectable({
  providedIn: 'root'
})
export class CobranzaService {
  private apiUrl = 'https://localhost:7167/api';

  constructor(private http: HttpClient) {}

  getClientes(): Observable<ClienteResumen[]> {
    return this.http.get<ClienteResumen[]>(`${this.apiUrl}/clientes`);
  }

  getOperaciones(codigoCliente: number): Observable<Operacion[]> {
    return this.http.get<Operacion[]>(`${this.apiUrl}/clientes/${codigoCliente}/operaciones`);
  }

  registrarIntencion(payload: IntencionPagoRequest): Observable<{ ok: boolean; mensaje: string; numeroGestion: string }> {
    return this.http.post<{ ok: boolean; mensaje: string; numeroGestion: string }>(
      `${this.apiUrl}/intencionpago`,
      payload
    );
  }
}