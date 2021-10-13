# co.SaludTotal

Se Crearon las siguientes Entidades/tablas:
-Aplicativo
-Desarrollador
- Requerimiento

Se utilizo Ado.net con .Net 5 (core) 

Solucion N-Layered
1. co.Saludtotal.Infrastructure.Data
2. co.Saludtotal.Domain.Entities
3. co.Saludtotal.Domain.Core
4. co.Saludtotal.Aplication
5. co.Saludtotal.UI.Mvc

Esta ultima se utilizo Razor Pages para agilizar el desarrollo de la prueba


Para la conexion no se tuvo encuenta la instancia de SQL Server “SRVBDDEV002\POS”  y para cambiar a este servidor se usó "(localdb)\\MSSQLLocalDB"
se provee de los scripts tanto de creación Tablas como los StoredPRocedures del CRUD
