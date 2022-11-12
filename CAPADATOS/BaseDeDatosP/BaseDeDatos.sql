Create database BDPROYECTODIARS
use BDPROYECTODIARS
--Tabla con todos los campos de Trabajador
create table Trabajadores
(
IdTrabajador int not null primary key identity(1,1),
Dni int,
Nombres varchar(50),
ApPaterno varchar(20),
ApMaterno varchar(20),
FechaNac date,
Sexo varchar(10),
EstCivil varchar(10),
Ubigeo int,
Direccion varchar(20),
Distrito varchar(20),
Provincia varchar(20),
Departamento Varchar(20),
FechaContrato date,
Usuario varchar(20),
Password varchar(20),
Cargo varchar(20), 
EstadoTrabajador bit,
PerfilTrabajador image
)


select *from Trabajadores
delete  Trabajadores where Dni=46810491;
--update Trabajadores set Cargo='Gerente' where Dni=71002172 

--procedimiento almacenado para insertar un nuevo trabajador
create procedure spInsertarTrabajador(
@Dni int,
@Nombres varchar(50),
@ApPaterno varchar(20),
@ApMaterno varchar(20),
@FechaNac date,
@Sexo varchar(10),
@EstCivil varchar(10),
@Ubigeo int,
@Direccion varchar(20),
@Distrito varchar(20),
@Provincia varchar(20),
@Departamento Varchar(20),
@FechaContrato date,
@Usuario varchar(20),
@Password varchar(20),
@Cargo varchar(20), 
@EstadoTrabajador bit,
@PerfilTrabajador image)
as begin
insert into Trabajadores(Dni,Nombres,ApPaterno,ApMaterno,FechaNac,Sexo,EstCivil,Ubigeo,Direccion, Distrito, Provincia, Departamento, FechaContrato, Usuario,Password,Cargo,EstadoTrabajador,PerfilTrabajador ) values 
(@Dni,@Nombres,@ApPaterno,@ApMaterno,@FechaNac,@Sexo,@EstCivil,@Ubigeo,@Direccion, @Distrito,@Provincia, @Departamento, @FechaContrato, @Usuario,@Password,@Cargo,@EstadoTrabajador,@PerfilTrabajador)
end 
go

--Procedimiento para listar el trabajador falta algo creo
create procedure spListarTrabajador
as
select IdTrabajador, Dni,Nombres,ApPaterno,ApMaterno,FechaNac,Sexo,EstCivil,Ubigeo,Direccion, Distrito, Provincia, Departamento, FechaContrato, Usuario,Password,Cargo,EstadoTrabajador,PerfilTrabajador 
	from Trabajadores where EstadoTrabajador='1'
	go

--Procedimiento para modificar trabajador
create procedure spModificarTrabajador(
@IdTrabajador int,
@Dni int,
@Nombres varchar(50),
@ApPaterno varchar(20),
@ApMaterno varchar(20),
@FechaNac date,
@Sexo varchar(10),
@EstCivil varchar(10),
@Ubigeo int,
@Direccion varchar(20),
@Distrito varchar(20),
@Provincia varchar(20),
@Departamento Varchar(20),
@FechaContrato date,
@Usuario varchar(20),
@Password varchar(20),
@Cargo varchar(20), 
@EstadoTrabajador bit,
@PerfilTrabajador image
)as begin update Trabajadores set
 Dni=@Dni,
 Nombres=@Nombres,
 ApPaterno=@ApPaterno,
 ApMaterno=@ApMaterno,
 FechaNac=@FechaNac,
 Sexo=@Sexo,
 EstCivil=@EstCivil,
 Ubigeo=@Ubigeo,
 Direccion=@Direccion,
 Distrito=@Distrito,
 Provincia=@Provincia, 
 Departamento=@Departamento, 
 FechaContrato=@FechaContrato, 
 Usuario=@Usuario,
 Password=@Password,
 Cargo=@Cargo,
 EstadoTrabajador=@EstadoTrabajador,
 PerfilTrabajador=@PerfilTrabajador
 where IdTrabajador=@IdTrabajador
 end
 go

 -- para Buscar Trabajador por dni
 create procedure spBuscarTrabajador
 @Dni int
 as  begin
 select *from Trabajadores where Dni like @Dni and EstadoTrabajador=1;
 end 
 go

 --Para deshabilitar Trabajador
 create procedure spDeshabilitarTrabajador
 @Dni int,
 @EstadoTrabajador bit
 as 
 begin
 update Trabajadores set EstadoTrabajador=0 where Dni=@Dni
 end 
 go
 -----------------------------------------------------------------------------------------------------------------
-- Para Mantenedor Vehiculo
------------------------------------------------------------------------------------------------------------------
--Tabla Vehiculo
create table Vehiculo(
IdVehiculo int not null primary key identity(1,1), 
Categoria varchar(10),
Modelo varchar (15),
Color varchar (15),
Motor varchar (20),
Combustible varchar (10),
FormRodante varchar (10),
AñoFabricacion varchar(10),
AñoModelo varchar(10),
Version varchar (15),
Ejes int,
Asientos int,
Pasajeros int,
Ruedas int,
Carroceria varchar (10),
Potencia Varchar (10),
Cilindros int,
Cilindrada float,
PesoBruto float,
PesoNeto float,
CargaUtil float,
Longitud float,
Altura float,
Ancho float,
ZonaRegistro varchar(30),
DuaDuam int,
Titulo int,
FechaTitulo date,
Condicion varchar(15),
Placa varchar(10),
PlacaAnterior varchar(10),
FotoVehiculo image
)

select *from Vehiculo
delete Vehiculo
-- update Vehiculo set Condicion='Activo' where Placa='rggggggt'

--procedimiento almacenado para insertar un nuevo Vehiculo
create procedure spInsertarVehiculo(
@Categoria varchar(10),
@Modelo varchar (15),
@Color varchar (15),
@Motor varchar (20),
@Combustible varchar (10),
@FormRodante varchar (10),
@AñoFabricacion varchar(10),
@AñoModelo varchar(10),
@Version varchar (15),
@Ejes int,
@Asientos int,
@Pasajeros int,
@Ruedas int,
@Carroceria varchar (10),
@Potencia Varchar (10),
@Cilindros int,
@Cilindrada float,
@PesoBruto float,
@PesoNeto float,
@CargaUtil float,
@Longitud float,
@Altura float,
@Ancho float,
@ZonaRegistro varchar(30),
@DuaDuam int,
@Titulo int,
@FechaTitulo date,
@Condicion varchar(15),
@Placa varchar(10),
@PlacaAnterior varchar(10),
@FotoVehiculo image
)as 
begin insert into Vehiculo(Categoria, Modelo, Color, Motor, Combustible, FormRodante, AñoFabricacion, AñoModelo, Version, Ejes,
Asientos, Pasajeros, Ruedas, Carroceria, Potencia, Cilindros, Cilindrada, PesoBruto, PesoNeto, CargaUtil, Longitud,
Altura, Ancho, ZonaRegistro, DuaDuam, Titulo, FechaTitulo, Condicion, Placa, PlacaAnterior, FotoVehiculo )values(
@Categoria, @Modelo, @Color, @Motor, @Combustible, @FormRodante, @AñoFabricacion, @AñoModelo, @Version, @Ejes,
@Asientos, @Pasajeros, @Ruedas, @Carroceria, @Potencia, @Cilindros, @Cilindrada, @PesoBruto, @PesoNeto, @CargaUtil, @Longitud,
@Altura, @Ancho, @ZonaRegistro, @DuaDuam, @Titulo, @FechaTitulo, @Condicion, @Placa, @PlacaAnterior, @FotoVehiculo)
end
go

--Procedimiento para listar el Vehiculo falta algo creo
create procedure spListarVehiculo
as
select IdVehiculo, Categoria, Modelo, Color, Motor, Combustible, FormRodante, AñoFabricacion, AñoModelo, Version, Ejes,
Asientos, Pasajeros, Ruedas, Carroceria, Potencia, Cilindros, Cilindrada, PesoBruto, PesoNeto, CargaUtil, Longitud,
Altura, Ancho, ZonaRegistro, DuaDuam, Titulo, FechaTitulo, Condicion, Placa, PlacaAnterior, FotoVehiculo
	from Vehiculo 
	go

--Procedimiento para modificar vehiculo
create procedure spModificarVehiculo(
@IdVehiculo int,
@Categoria varchar(10),
@Modelo varchar (15),
@Color varchar (15),
@Motor varchar (20),
@Combustible varchar (10),
@FormRodante varchar (10),
@AñoFabricacion varchar(10),
@AñoModelo varchar(10),
@Version varchar (15),
@Ejes int,
@Asientos int,
@Pasajeros int,
@Ruedas int,
@Carroceria varchar (10),
@Potencia Varchar (10),
@Cilindros int,
@Cilindrada float,
@PesoBruto float,
@PesoNeto float,
@CargaUtil float,
@Longitud float,
@Altura float,
@Ancho float,
@ZonaRegistro varchar(30),
@DuaDuam int,
@Titulo int,
@FechaTitulo date,
@Condicion varchar(15),
@Placa varchar(10),
@PlacaAnterior varchar(10),
@FotoVehiculo image
)as begin update Vehiculo set
Categoria=@Categoria,
Modelo=@Modelo,
Color=@Color,
Motor=@Motor,
Combustible=@Combustible,
FormRodante=@FormRodante,
AñoFabricacion=@AñoFabricacion,
AñoModelo=@AñoModelo,
Version=@Version,
Ejes=@Ejes,
Asientos=@Asientos, 
Pasajeros=@Pasajeros, 
Ruedas=@Ruedas,
Carroceria=@Carroceria, 
Potencia=@Potencia, 
Cilindros=@Cilindros,
Cilindrada=@Cilindrada,
PesoBruto=@PesoBruto,
PesoNeto=@PesoNeto,
CargaUtil=CargaUtil,
Longitud=@Longitud,
Altura=@Altura, 
Ancho=@Ancho,
ZonaRegistro=@ZonaRegistro,
DuaDuam=@DuaDuam, 
Titulo=@Titulo,
FechaTitulo=@FechaTitulo, 
Condicion=@Condicion,
Placa=@Placa, 
PlacaAnterior=@PlacaAnterior,
FotoVehiculo=@FotoVehiculo
 where IdVehiculo=@IdVehiculo
 end
 go

 -- para Buscar vehiculo por placa
 create procedure spBuscarVehiculo
 @Placa varchar(10)
 as  begin
 select *from Vehiculo where Placa like @Placa
 end 
 go

 --Para deshabilitar Vehiculo
 create procedure spDeshabilitarVehiculo
 @Placa varchar(10),
 @Condicion varchar(15)
 as 
 begin
 update Vehiculo set Condicion='Inactivo' where Placa=@Placa
 end 
 go
 
-----------------------------------------------------------------------------------------------------------------
-- Para Estado de vehiculo
------------------------------------------------------------------------------------------------------------------
--Tabla ficha Estado de vehiculo
create table FichaEstadoVehiculo(
IdEstadoVehiculo int not null primary key Identity(1,1),
IdConductor int,
IdRecepcionista int,
Fecha date,
SistemaElectrico varchar(150),
SistemaMecanico varchar(150),
LatoneriaYPintura varchar(150),
Otros varchar(150),
constraint Fk_IdConductor foreign key (IdConductor) references Trabajadores(IdTrabajador),
constraint Fk_IdRecepcionista foreign key (IdRecepcionista) references Trabajadores(IdTrabajador)
)

 -----------------------------------------------------------------------------------------------------------------
-- Para Mantenedor PEDIDO
------------------------------------------------------------------------------------------------------------------
--Tabla PEDIDO
CREATE TABLE PEDIDO(
IDPEDIDO int not null primary key identity(1,1), 
DNIR INT NOT NULL,
CORREOR VARCHAR (30),
TELEFONOR INT,
DIRECCIONR VARCHAR(60),
NOMBRER VARCHAR(100),
OBSERVACIONESR VARCHAR(200),
CONTACTOR INT,
DISTRITOR VARCHAR(50),
PROVINCIAR VARCHAR(50),
DEPARTAMENTOR VARCHAR(50),

DNID INT NOT NULL,
CORREOD VARCHAR (30),
TELEFONOD INT,
DIRECCIOND VARCHAR(60),
NOMBRED VARCHAR(100),
OBSERVACIONESD VARCHAR(200),
CONTACTOD INT,
DISTRITOD VARCHAR(50),
PROVINCIAD VARCHAR(50),
DEPARTAMENTOD VARCHAR(50)
);
          --procedimiento almacenado para insertar un nuevo PAQUETE/PEDIDO
CREATE PROCEDURE spinsertarPedido(
@DNIR INT ,
@CORREOR VARCHAR (30),
@TELEFONOR INT,
@DIRECCIONR VARCHAR(60),
@NOMBRER VARCHAR(100),
@OBSERVACIONESR VARCHAR(200),
@CONTACTOR INT,
@DISTRITOR VARCHAR(50),
@PROVINCIAR VARCHAR(50),
@DEPARTAMENTOR VARCHAR(50),
@DNID INT,
@CORREOD VARCHAR (30),
@TELEFONOD INT,
@DIRECCIOND VARCHAR(60),
@NOMBRED VARCHAR(100),
@OBSERVACIONESD VARCHAR(200),
@CONTACTOD INT,
@DISTRITOD VARCHAR(50),
@PROVINCIAD VARCHAR(50),
@DEPARTAMENTOD VARCHAR(50)
)
as 
begin
insert into PEDIDO(DNIR,CORREOR,TELEFONOR,DIRECCIONR,NOMBRER,OBSERVACIONESR,CONTACTOR,DISTRITOR,PROVINCIAR,DEPARTAMENTOR,DNID,CORREOD,TELEFONOD,DIRECCIOND,NOMBRED,OBSERVACIONESD,CONTACTOD,DISTRITOD,PROVINCIAD,DEPARTAMENTOD) 
	values(@DNIR,@CORREOR,@TELEFONOR,@DIRECCIONR,@NOMBRER,@OBSERVACIONESR,@CONTACTOR,@DISTRITOR,@PROVINCIAR,@DEPARTAMENTOR,@DNID,@CORREOD,@TELEFONOD,@DIRECCIOND,@NOMBRED,@OBSERVACIONESD,@CONTACTOD,@DISTRITOD,@PROVINCIAD,@DEPARTAMENTOD)
end
GO

-- buscar pedido
CREATE PROCEDURE  spBuscarPedido(
	@IdPedido int 
)
as begin
select * from  Pedido where IDPEDIDO =@IdPedido
end
GO

-- Listar  pedido
CREATE PROCEDURE  spListarPedido
	
as begin
select * from  Pedido 
end
GO
-- actualizar Pedido
create procedure spModificarPedido(
@DNIR INT ,
@CORREOR VARCHAR (30),
@TELEFONOR INT,
@DIRECCIONR VARCHAR(60),
@NOMBRER VARCHAR(100),
@OBSERVACIONESR VARCHAR(200),
@CONTACTOR INT,
@DISTRITOR VARCHAR(50),
@PROVINCIAR VARCHAR(50),
@DEPARTAMENTOR VARCHAR(50),
@DNID INT,
@CORREOD VARCHAR (30),
@TELEFONOD INT,
@DIRECCIOND VARCHAR(60),
@NOMBRED VARCHAR(100),
@OBSERVACIONESD VARCHAR(200),
@CONTACTOD INT,
@DISTRITOD VARCHAR(50),
@PROVINCIAD VARCHAR(50),
@DEPARTAMENTOD VARCHAR(50)

)
as 
begin
update Pedido  set 
				DNIR = @DNIR,
				CORREOR = @CORREOR,
				TELEFONOR = @TELEFONOR,
				DIRECCIONR = @DIRECCIONR,
				NOMBRER = @NOMBRER,
				OBSERVACIONESR = @OBSERVACIONESR,
				CONTACTOR = @CONTACTOR,
				DISTRITOR = @DISTRITOR,
				PROVINCIAR = @PROVINCIAR,
				DEPARTAMENTOR = DEPARTAMENTOR,

				DNID = @DNID,
				CORREOD = @CORREOD,
				TELEFONOD = @TELEFONOD,
				DIRECCIOND = @DIRECCIOND,
				NOMBRED = @NOMBRED,
				OBSERVACIONESD = @OBSERVACIONESD,
				CONTACTOD = @CONTACTOD,
				DISTRITOD = @DISTRITOD,
				PROVINCIAD = @PROVINCIAD,
				DEPARTAMENTOD = DEPARTAMENTOD
				where IDPEDIDO =IDPEDIDO
end
GO
--eliminar Pedido
create procedure spEliminarPedido(
@IdPedido int

)
as 
begin
delete PEDIDO where IDPEDIDO =@IdPedido
end
GO

-----------------------------------------------------------------------------------------------------------------
-- Para Mantenedor Diagnostico
------------------------------------------------------------------------------------------------------------------
--Tabla diagnostigo
CREATE TABLE DIAGNOSTICO(
IDdIAGNOSTICO INT PRIMARY key identity(1,1), 
NombreCliente VARCHAR(50),
OBSERVACIONES VARCHAR(250),
FALLAS VARCHAR(300),
MARCA VARCHAR(30),
MODELO VARCHAR(30),
PLACA VARCHAR (8),
FECHA DATE
);

--PROCEDIMIENTO PARA INSERTAR
CREATE PROCEDURE spinsertarDiagnostico(
@NombreCliente VARCHAR(50),
@OBSERVACIONES VARCHAR(250),
@FALLAS VARCHAR(300),
@MARCA VARCHAR(30),
@MODELO VARCHAR(30),
@PLACA VARCHAR (8),
@FECHA DATE
)
as
BEGIN
INSERT INTO DIAGNOSTICO ( NombreCliente,OBSERVACIONES , FALLAS, MARCA, MODELO, PLACA, FECHA)
VALUES(@NombreCliente, @OBSERVACIONES, @FALLAS, @MARCA, @MODELO, @PLACA, @FECHA)
END
GO
--PROCEDIMIENTO PARA ACTUALIZAR
CREATE PROCEDURE spModificarDiagnostico(
@IdDiagnostico INT,
@NombreCliente VARCHAR(50),
@OBSERVACIONES VARCHAR(250),
@FALLAS VARCHAR(300),
@MARCA VARCHAR(30),
@MODELO VARCHAR(30),
@PLACA VARCHAR (8),
@FECHA DATE
)
as
BEGIN
UPDATE DIAGNOSTICO SET  NombreCliente=@NombreCliente,
						OBSERVACIONES=@OBSERVACIONES ,
						FALLAS=@FALLAS,
						MARCA=@MARCA,
						MODELO=@MODELO,
						PLACA=@PLACA,
						FECHA=@FECHA
					WHERE IdDiagnostico=@IdDiagnostico
	END
GO

--PROCEDIMIENTO PARA lISTAR
CREATE PROCEDURE spListarDiagnostico 


AS
BEGIN
SELECT * FROM DIAGNOSTICO
END
GO
--PROCEDIMIENTO PARA BUSCAR
CREATE PROCEDURE spBuscarDiagnostico (
@IdDiagnostico INT
)
AS
BEGIN
SELECT * FROM DIAGNOSTICO
				WHERE IDdIAGNOSTICO =@IdDiagnostico
END
GO
--PROCEDIMIENTO PARA ELIMINAR
CREATE PROCEDURE spEliminarDiagnostico (
@IdDiagnostico INT
)
AS
BEGIN
delete DIAGNOSTICO
				WHERE IDdIAGNOSTICO =@IdDiagnostico
END
GO

----------------------------------------------------------------
--						Para Ruta								
----------------------------------------------------------------
--Tabla Ruta
create table Ruta(
IdRuta int not null primary key identity(1,1),
PuntoPartida varchar(30),
PuntoLlegada varchar(30),
Observaciones varchar(100),
EstadoRuta bit
)

select *from Ruta
delete Ruta where IdRuta='1'--solo prueba xd
--Procedimiento Para Registrar Ruta
create procedure spInsertarRuta(
@PuntoPartida varchar(30),
@PuntoLlegada varchar(30),
@Observaciones varchar(100),
@EstadoRuta bit
)as begin
insert into Ruta(PuntoPartida, PuntoLlegada, Observaciones, EstadoRuta)values 
(@PuntoPartida, @PuntoLlegada, @Observaciones, @EstadoRuta)end 
go

--Procedimiento para modificar ruta
create procedure spModificarRuta(
@IdRuta int,
@PuntoPartida varchar(30),
@PuntoLlegada varchar(30),
@Observaciones varchar(100),
@EstadoRuta bit
)as begin
update Ruta set 
PuntoPartida=@PuntoPartida,
PuntoLlegada=@PuntoLlegada,
Observaciones=@Observaciones,
EstadoRuta=@EstadoRuta
where IdRuta=@IdRuta
end
go

--Procedimiento para buscar Ruta
 create procedure spBuscarRuta
 @IdRuta int
 as  begin
 select *from Ruta where IdRuta like @IdRuta;
 end 
 go

 --Procedimiento para deshabilitar Ruta 
create procedure spDeshabilitarRuta
 @IdRuta int,
 @EstadoRuta bit
 as 
 begin
 update Ruta set EstadoRuta=0 where IdRuta=@IdRuta
 end 
 go

 --Procedimiento para listar Ruta
 create procedure spListarRuta as
select  IdRuta, PuntoPartida, PuntoLlegada, Observaciones, EstadoRuta
	from Ruta where EstadoRuta='1'
	go

----------------------------------------------------------------
--						Para Programacion de salida								
----------------------------------------------------------------
--Tabla Programacion de Salida
create table ProgramacionSalida(
IdProgramacionSalida int not null primary key identity (1,1),
FechaInicio date,
FechaFin date,
IdRuta int,
IdConductor int,
IdVehiculo int,
constraint Fk_IdRuta foreign key(IdRuta) references Ruta(IdRuta),
constraint Fk_IdConductorP foreign key(IdConductor) references Trabajadores(IdTrabajador),
constraint Fk_Vehiculo foreign key(IdVehiculo) references Vehiculo(IdVehiculo)
)


----------------------------------------------------------------
--						Para Programacion de Planilla							
----------------------------------------------------------------

create table planilla(
IdPlanilla int primary key identity(1,1),
Ruc numeric,
RazSocial varchar(100),
Rubro varchar(50),
Direccion varchar(100),

IdTr int,
DniTr numeric,
nomTr varchar(100),
AppTr varchar(100),
Hijos int,
FechNacTr date,
DirTr varchar(100),

Cargo varchar(100),
Categoria varchar(100),
PerPago varchar(100),
Onp varchar(2),
Afp varchar(2),
Cuspp varchar(20),
ImportOtro numeric,

FechIngreso date,
FechCese date,
InitVac date,
FindVac date,
DiasVac int,
DiasLAb int,
HrTrab int,
HrExtr int,
DiasNoLAb int,

);

select * from planilla;
drop table planilla;
----------------------------------
--- listar planilla
----------------------------------
create procedure spListarPlanilla
as
begin
select  IdPlanilla,Ruc,RazSocial,Rubro,Direccion,
		IdTr,DniTr,nomTr,AppTr,Hijos,FechNacTr,DirTr
		,Cargo,Categoria,PerPago,Onp,Afp,Cuspp,ImportOtro
		,FechIngreso,FechCese,InitVac,FindVac,DiasVac,DiasLAb,HrTrab,HrExtr,DiasNoLAb
		
 from planilla
end;
go
------------------------------------------
---registar datos planilla
------------------------------------------
create procedure spIngresarPlanilla (
@Ruc numeric, @RazSocial varchar(100), @Rubro varchar(50), @Direccion varchar(100),
@IdTr int, @DniTr numeric, @nomTr varchar(100), @AppTr varchar(100), @Hijos int, @FechNacTr date, @DirTr varchar(100),
@Cargo varchar(100), @Categoria varchar(100), @PerPago varchar(100), @Onp varchar(2), @Afp varchar(2), @Cuspp varchar(20), @ImportOtro numeric,
@FechIngreso date, @FechCese date, @InitVac date, @FindVac date, @DiasVac int, @DiasLAb int, @HrTrab int, @HrExtr int, @DiasNoLAb int
)
as
begin
insert into Planilla ( Ruc,RazSocial,Rubro,Direccion,
		IdTr,DniTr,nomTr,AppTr,Hijos,FechNacTr,DirTr
		,Cargo,Categoria,PerPago,Onp,Afp,Cuspp,ImportOtro
		,FechIngreso,FechCese,InitVac,FindVac,DiasVac,DiasLAb,HrTrab,HrExtr,DiasNoLAb
		) 
		values(@Ruc, @RazSocial, @Rubro, @Direccion,
		@IdTr,@DniTr,@nomTr,@AppTr,@Hijos,@FechNacTr,@DirTr,
		@Cargo,@Categoria,@PerPago,@Onp,@Afp,@Cuspp,@ImportOtro,
		@FechIngreso,@FechCese,@InitVac,@FindVac,@DiasVac,@DiasLAb,@HrTrab,@HrExtr,@DiasNoLAb
		);
end;
go
------------------------------------------
---actualizar datos planilla
------------------------------------------
create procedure spModificarPlanilla(
@IdPlanilla int, @Ruc numeric, @RazSocial varchar(100), @Rubro varchar(50), @Direccion varchar(100),
@IdTr int, @DniTr numeric, @nomTr varchar(100), @AppTr varchar(100), @Hijos int, @FechNacTr date, @DirTr varchar(100),
@Cargo varchar(100), @Categoria varchar(100), @PerPago varchar(100), @Onp varchar(2), @Afp varchar(2), @Cuspp varchar(20), @ImportOtro numeric,
@FechIngreso date, @FechCese date, @InitVac date, @FindVac date, @DiasVac int, @DiasLAb int, @HrTrab int, @HrExtr int, @DiasNoLAb int
)
as 
begin
		
update planilla set 
		Ruc=@Ruc,RazSocial=@RazSocial,Rubro=@Rubro,Direccion=@Direccion,
		DniTr=@DniTr,nomTr=@nomTr,AppTr=@AppTr,Hijos=@Hijos,FechNacTr=@FechNacTr,DirTr=@DirTr
		,Cargo=@Cargo,Categoria=@Categoria,PerPago=@PerPago,Onp=@Onp,Afp=@Afp,Cuspp=@Cuspp,ImportOtro=@ImportOtro
		,FechIngreso=@FechIngreso,FechCese=@FechCese,InitVac=@InitVac,FindVac=@FindVac,DiasVac=@DiasVac,DiasLAb=@DiasLAb,HrTrab=@HrTrab,HrExtr=@HrExtr,DiasNoLAb=@DiasNoLAb

	where idPlanilla = @IdPlanilla 
end;
go

------------------------------------------
---inabilitar datos planilla
------------------------------------------
CREATE procedure spInabilitaRPlanilla(
@IdPlanilla int)
as 
begin
update planilla set Categoria='INACTIVO'
where idPlanilla =  @IdPlanilla
end
go

select * from Planilla
create procedure spBuscarPLanilla(
@IdPlanilla int
)
as
begin
select  IdPlanilla,Ruc,RazSocial,Rubro,Direccion,
		IdTr,DniTr,nomTr,AppTr,Hijos,FechNacTr,DirTr
		,Cargo,Categoria,PerPago,Onp,Afp,Cuspp,ImportOtro
		,FechIngreso,FechCese,InitVac,FindVac,DiasVac,DiasLAb,HrTrab,HrExtr,DiasNoLAb
 from planilla
 where idPlanilla = @IdPlanilla
end
go

--CREACION DE LA TABLA LOTE 
CREATE TABLE LOTE(
IdLote int not null primary key identity(1,1),
Nombres varchar(50),
Producto varchar(50),
Fecha date
)

--CREAR PROCEDIMIENTO LISTARLOTE
create procedure spListarLote
as
select IdLote,Nombres,Producto,Fecha
	from LOTE 
	go

--CREAR PROCEDIMIENTO INSERTAR LOTE
create procedure spInsertarLote(
@Nombres varchar(50),
@Producto varchar(50),
@Fecha date)
as begin
insert into LOTE(Nombres,Producto,Fecha) values 
(@Nombres,@Producto,@Fecha)
end 
go

--CREAR PROCEDIMIENTO MODIFICAR LOTE
create procedure spModificarLote(
@IdLote int,
@Nombres varchar(50),
@Producto varchar(50),
@Fecha date
)as begin update LOTE set 
 Nombres=@Nombres,
 Producto=@Producto,
 Fecha=@Fecha 
 where IdLote=@IdLote
 end
 go

--CREAR PROCEDIMIENTO ELIMINAR LOTE
CREATE PROCEDURE spEliminarLote(
@IdLote INT
)
AS
BEGIN
delete LOTE
	WHERE IdLote =@IdLote
END
GO

--CREAR PROCEDIMIENTO PARA BUSCAR LOTE
CREATE PROCEDURE  spBuscarLote(
	@IdLote int 
)
as begin
select * from  LOTE where IdLote = @IdLote
end
GO

