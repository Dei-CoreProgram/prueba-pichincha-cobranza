# Prueba Técnica - Sistema de Cobranza

Se desarrolló una aplicación fullstack utilizando Angular y .NET 8 Web API para el registro de intención de pago de clientes.

## Descripción

La aplicación permite:

- Consultar un listado de clientes con información resumida
- Visualizar las operaciones asociadas a cada cliente
- Registrar una intención de pago mediante un formulario validado
- Generar un número de gestión como respuesta del backend
- Visualizar un resumen de clientes en pantalla

## Arquitectura

La solución sigue una arquitectura cliente-servidor:

- Frontend desarrollado en Angular utilizando componentes standalone y Reactive Forms
- Backend desarrollado en .NET 8 Web API
- Comunicación mediante servicios REST
- Datos simulados en memoria según el requerimiento de la prueba

## Tecnologías utilizadas

- Angular
- TypeScript
- .NET 8
- C#
- HTML y CSS
- REST API

## Ejecución del proyecto

### Backend

1. Abrir el proyecto en Visual Studio
2. Ejecutar la aplicación (F5)
3. Se habilita Swagger en:
   https://localhost:7167/swagger

### Frontend

Ejecutar los siguientes comandos:
cd frontend/cobranza-web
ng serve


Luego abrir en el navegador:


http://localhost:4200


## Endpoints principales

- GET /api/clientes  
  Retorna el listado de clientes

- GET /api/clientes/{id}/operaciones  
  Retorna las operaciones asociadas a un cliente

- POST /api/intencionpago  
  Registra una intención de pago

## Validación y pruebas

El funcionamiento fue validado mediante:

- Pruebas desde la interfaz de usuario en Angular
- Pruebas directas desde Swagger
- Verificación de request y response desde la consola del navegador

## Consideraciones

La información no se persiste en una base de datos, ya que la prueba requería trabajar con datos simulados en memoria. Sin embargo, la solución está estructurada de forma que puede integrarse fácilmente con un motor de base de datos como SQL Server.

## Autor

Msc. ING .David Aníbal Cóndor Paucar 
