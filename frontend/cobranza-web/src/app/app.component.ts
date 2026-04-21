import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { CobranzaService } from './services/cobranza.service';
import { ClienteResumen } from './models/cliente.model';
import { Operacion } from './models/operacion.model';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [CommonModule, ReactiveFormsModule],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent implements OnInit {
  clientes: ClienteResumen[] = [];
  operaciones: Operacion[] = [];
  mensaje = '';
  form!: FormGroup;

  constructor(
    private cobranzaService: CobranzaService,
    private fb: FormBuilder
  ) {}

  ngOnInit(): void {
    this.form = this.fb.group({
      codigoCliente: ['', Validators.required],
      operacionId: ['', Validators.required],
      montoPropuesto: ['', [Validators.required, Validators.min(1)]],
      plazoMeses: ['', [Validators.required, Validators.min(1)]],
      telefono: ['', Validators.required],
      correo: ['', [Validators.required, Validators.email]],
      observacion: ['', Validators.required]
    });

    this.cargarClientes();

    this.form.get('codigoCliente')?.valueChanges.subscribe((value: string) => {
      if (value) {
        this.cargarOperaciones(Number(value));
      } else {
        this.operaciones = [];
      }
    });
  }

  cargarClientes(): void {
    this.cobranzaService.getClientes().subscribe({
      next: (data: ClienteResumen[]) => {
        this.clientes = data;
      },
      error: (err: unknown) => {
        console.error('Error cargando clientes', err);
        this.mensaje = 'Error al cargar clientes';
      }
    });
  }

  cargarOperaciones(codigoCliente: number): void {
    this.cobranzaService.getOperaciones(codigoCliente).subscribe({
      next: (data: Operacion[]) => {
        this.operaciones = data;
      },
      error: (err: unknown) => {
        console.error('Error cargando operaciones', err);
        this.mensaje = 'Error al cargar operaciones';
      }
    });
  }

  enviar(): void {
    if (this.form.invalid) {
      this.form.markAllAsTouched();
      return;
    }

    const payload = {
      codigoCliente: Number(this.form.value.codigoCliente),
      operacionId: Number(this.form.value.operacionId),
      montoPropuesto: Number(this.form.value.montoPropuesto),
      plazoMeses: Number(this.form.value.plazoMeses),
      telefono: this.form.value.telefono as string,
      correo: this.form.value.correo as string,
      observacion: this.form.value.observacion as string
    };

    this.cobranzaService.registrarIntencion(payload).subscribe({
      next: (resp: { ok: boolean; mensaje: string; numeroGestion: string }) => {
        this.mensaje = `${resp.mensaje}. Número de gestión: ${resp.numeroGestion}`;
        this.form.reset();
        this.operaciones = [];
      },
      error: (err: unknown) => {
        console.error('Error registrando intención', err);
        this.mensaje = 'No se pudo registrar la intención de pago';
      }
    });
  }
}