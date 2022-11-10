create database BDPROYECTODIARS;
use BDPROYECTODIARS;

------------------------------------------------------------------
--	PARA TRABAJADORES											 -
------------------------------------------------------------------
--Tabla Trabajadores
create table Trabajadores(
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

  -- para Buscar Trabajador por Nombre
-- para Buscar Solo Conductor por Nombre
 create procedure spBuscarTrabajadorN
 @Nombres varchar(50)
 as  begin
 select *from Trabajadores where Nombres like '%'+@Nombres+'%' and EstadoTrabajador=1;
 end

 --Para deshabilitar Trabajador
 create procedure spDeshabilitarTrabajador
 @Dni int,
 @EstadoTrabajador bit
 as 
 begin
 update Trabajadores set EstadoTrabajador=0 where Dni=@Dni
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

 --Lista solo conductores
create procedure spListarTrabajadorConductores
as
select IdTrabajador, Dni,Nombres,ApPaterno,ApMaterno,FechaNac,Sexo,EstCivil,Ubigeo,Direccion, Distrito, Provincia, Departamento, FechaContrato, Usuario,Password,Cargo,EstadoTrabajador,PerfilTrabajador 
	from Trabajadores where EstadoTrabajador='1' and Cargo='Conductor';
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

  -- para Buscar vehiculo por placa dinamico
 create procedure spBuscarVehiculoD
 @Placa varchar(10)
 as  begin
 select *from Vehiculo where Placa like  '%'+@Placa+'%'
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
);

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

 --Procedimiento para listar Ruta
 create procedure spListarRuta as
 select  IdRuta, PuntoPartida, PuntoLlegada, Observaciones, EstadoRuta
	from Ruta where EstadoRuta='1'
	go

--Procedimiento para buscar Ruta
 create procedure spBuscarRuta
 @IdRuta int
 as  begin
 select *from Ruta where IdRuta like @IdRuta;
 end 
 go

 --Procedimiento para buscar ruta de reporte por el punto de partida
  create procedure spBuscarRutaPunPar
 @PuntoPartida varchar(30)
 as  begin
 select *from Ruta where PuntoPartida like '%'+@PuntoPartida+'%'
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



----------------------------------------------------------------
--						Para Programacion de salida								
----------------------------------------------------------------
--Tabla Programacion de salida
create table ProgramacionSalida(
IdProgramacionSalida int not null primary key identity(1,1),
FechaInicio date,
FechaFin date,
IdRuta int,
IdConductor int,
IdVehiculo int,
constraint Fk_IdRutaPS foreign key(IdRuta)references Ruta(IdRuta),
constraint Fk_IdConductorPS foreign key(IdConductor)references Trabajadores(IdTrabajador),
constraint Fk_IdVehiculoPS foreign key(IdVehiculo)references Vehiculo(IdVehiculo)
);

select *from ProgramacionSalida
--Procedimiento para Insertar programacion de salida
create procedure spInsertarProgramacionSalida(
@FechaInicio date,
@FechaFin date,
@IdRuta int,
@IdConductor int,
@IdVehiculo int
)as begin
insert into ProgramacionSalida(FechaInicio,FechaFin,IdRuta,IdConductor,IdVehiculo)values
(@FechaInicio, @FechaFin, @IdRuta, @IdConductor, @IdVehiculo)
end 
go

--Procedimiento para Modificar Programacion de salida
create procedure spModificarProgramacionSalida(
@IdProgramacionSalida int,
@FechaInicio date,
@FechaFin date,
@IdRuta int,
@IdConductor int,
@IdVehiculo int
)as begin
update ProgramacionSalida set
FechaInicio=@FechaInicio,
FechaFin=@FechaFin,
IdRuta=@IdRuta,
IdConductor=@IdConductor,
IdVehiculo=@IdVehiculo
where IdProgramacionSalida=@IdProgramacionSalida
end 
go

--Procedimiento para buscsar Programacion de salida 
 create procedure spBuscarProgramacionSalida
 @IdProgramacionSalida int
 as  begin
 select *from ProgramacionSalida where IdProgramacionSalida like @IdProgramacionSalida;
 end

 --procedimiento para buscar coductor en programacion de salida
 create procedure spBuscarConductorPro
 @IdProgramacionSalida int
 as begin
 select tra.IdTrabajador, tra.Nombres from ProgramacionSalida as pro inner join 
 Trabajadores as tra on(pro.IdConductor=tra.IdTrabajador)where pro.IdProgramacionSalida=@IdProgramacionSalida
 end 
 go

 --procedimiento para buscar vehiuclo en programacion de salida
 create procedure spBuscarVehiculoPro
  @IdProgramacionSalida int
  as begin
  select veh.IdVehiculo, veh.Placa from ProgramacionSalida as pro inner join
  Vehiculo as veh on(pro.IdVehiculo=veh.IdVehiculo) where pro.IdProgramacionSalida=@IdProgramacionSalida
  end
  go

 --Procedimiento   para Listar programacion de salida
create procedure spListarProgramacionSalida
as
select IdProgramacionSalida,FechaInicio,FechaFin,IdRuta,IdConductor,IdVehiculo 
from ProgramacionSalida 
go
--Procedimiento para eliminar una programacion de salida 
create procedure spEliminarProgramacionSalida
@IdProgramacionSalida int
as
delete ProgramacionSalida where IdProgramacionSalida=@IdProgramacionSalida
go


--Tabla Diagnostico

CREATE TABLE DIAGNOSTICO(
IDdIAGNOSTICO INT PRIMARY key identity(1,1), 
OBSERVACIONES VARCHAR(250),
FALLAS VARCHAR(300),
FECHA DATE,
IdVehiculo int not null,
IdConductor int not null 
constraint Fk_Conductor foreign key (IdConductor) references Trabajadores(IdTrabajador),
constraint Fk_idVehiculo foreign key (IdVehiculo) references Vehiculo(IdVehiculo)
);

--procedimiento almacenado para inseetar Diagnostico
create procedure spInsertarDiagnostico(
@OBSERVACIONES VARCHAR(50),
@FALLAS VARCHAR(50),
@FECHA DATE,
@IdVehiculo int,
@IdConductor int 
)
as begin
insert into DIAGNOSTICO(OBSERVACIONES,FALLAS,FECHA,IdVehiculo,IdConductor) values 
(@OBSERVACIONES,@FALLAS,@FECHA,@IdVehiculo,@IdConductor)
end 
go

--Listar Diagnostico
create procedure spListarDiagnostico
as
select IDdIAGNOSTICO,OBSERVACIONES,FALLAS,FECHA,IdVehiculo,IdConductor 
	from DIAGNOSTICO 
	go

--Prcedimiento Modificar Diagnostico
create procedure spModificarDiagnostico(
@IDdIAGNOSTICO INT, 
@OBSERVACIONES VARCHAR(50),
@FALLAS VARCHAR(50),
@FECHA DATE,
@IdVehiculo int,
@IdConductor int 
)
as begin update DIAGNOSTICO set
OBSERVACIONES=@OBSERVACIONES ,
FALLAS=@FALLAS,
FECHA=@FECHA ,
IdVehiculo=@IdVehiculo ,
IdConductor=@IdConductor 
where IDdIAGNOSTICO=@IDdIAGNOSTICO
end 
go


--Buscar Diagnostico
 create procedure spBuscarDiagnostico
 @id int
 as  begin
 select *from DIAGNOSTICO where IDdIAGNOSTICO like @id;
 end;
 go


 --Eliminar 
create procedure spEliminarDiagnostico 
@Id int
as
delete from Diagnostico where IDdIAGNOSTICO=@Id
go

--TABLA CHECK LIST
-------------------
CREATE TABLE CheckList(
IdCheck INT PRIMARY key identity(1,1), 
FechaCheck DATE,
Combustible VARCHAR(20),
Horometro VARCHAR(20),
Inspeccion VARCHAR(250),
Kilometraje VARCHAR(20),
IdVehiculo int not null,
IdConductor int not null 
constraint Fk_Conductor_Check foreign key (IdConductor) references Trabajadores(IdTrabajador),
constraint Fk_idVehiculo_Check foreign key (IdVehiculo) references Vehiculo(IdVehiculo)
);

--INSERTAR CHECL LIST

create procedure spInsertarCheckList(
@FechaCheck DATE,
@Combustible VARCHAR(20),
@Horometro VARCHAR(20),
@Inspeccion VARCHAR(250),
@Kilometraje VARCHAR(20),
@IdVehiculo int,
@IdConductor int
)
as begin
insert into CheckList(FechaCheck,Combustible,Horometro,Inspeccion,Kilometraje,IdVehiculo,IdConductor) values 
(@FechaCheck,@Combustible,@Horometro,@Inspeccion,@Kilometraje,@IdVehiculo,@IdConductor)
end 
go
--LISTAR CHECK LIST

create procedure spListarCheckList
as
select IdCheck, FechaCheck,Combustible,Horometro,Inspeccion,Kilometraje,IdVehiculo,IdConductor 
	from CheckList
	go

--MODIFICAR CHECLIST
create procedure spModificarCheclLis(
@IdCheck int,
@FechaCheck DATE,
@Combustible VARCHAR(20),
@Horometro VARCHAR(20),
@Inspeccion VARCHAR(250),
@Kilometraje VARCHAR(20),
@IdVehiculo int,
@IdConductor int
)
as begin update CheckList set
FechaCheck=@FechaCheck,
Combustible=@Combustible,
Horometro=@Horometro,
Inspeccion=@Inspeccion, 
Kilometraje=@Kilometraje, 
IdVehiculo=@IdVehiculo,
IdConductor=@IdConductor
where IdCheck=@IdCheck
end 
go

--BUSCAR CHECK LIST
 create procedure spBuscarCheckList
 @id int
 as  begin
 select *from CheckList where IdCheck like @id;
 end

 --ELIMAR CHECK LIST
 create procedure spEliminarCheckList 
@Id int
as
delete from CheckList where IdCheck=@Id
go


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
ImportOtro int,

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
@Cargo varchar(100), @Categoria varchar(100), @PerPago varchar(100), @Onp varchar(2), @Afp varchar(2), @Cuspp varchar(20), @ImportOtro int,
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
@Cargo varchar(100), @Categoria varchar(100), @PerPago varchar(100), @Onp varchar(2), @Afp varchar(2), @Cuspp varchar(20), @ImportOtro int,
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


--para buscar planilla
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
 

----------------------------------------------------------------
--						Para Proceso de Pago de utilidades 						
----------------------------------------------------------------

--Tabla pago de utilidades 
create table PagoDeUtilidades(
IdPagoUtilidades int not null primary key identity(1,1),
IdPlanilla int,
IdTrabajador int,
TotalRemuneraciones float,
TotalDescuentos float,
TotalAportes float,
CtaAhorros int,
FechaPago date,
NetoAPagar float,
constraint Fk_IdPlanillaPU foreign key (IdPlanilla) references planilla(IdPlanilla),
constraint Fk_IdTrabajdorPU foreign key(IdTrabajador) references Trabajadores(IdTrabajador)
) 

select *from PagoDeUtilidades

--procedimiento para Insertar Pago de utilidades 
create procedure spInsertarPagoDeUtilidades(
@IdPlanilla int,
@IdTrabajador int,
@TotalRemuneraciones float,
@TotalDescuentos float,
@TotalAportes float,
@CtaAhorros int,
@FechaPago date,
@NetoAPagar float
)as begin
insert into PagoDeUtilidades(IdPlanilla,IdTrabajador,TotalRemuneraciones,TotalDescuentos, TotalAportes, CtaAhorros,FechaPago, NetoAPagar) values 
(@IdPlanilla,@IdTrabajador,@TotalRemuneraciones,@TotalDescuentos,@TotalAportes,@CtaAhorros,@FechaPago,@NetoAPagar)
end ;
go 

--procedimiento para actualizar pago de utilidades
create procedure spEditarPagoUtilidades(
@IdPagoUtilidades int,
@IdPlanilla int,
@IdTrabajador int,
@TotalRemuneraciones float,
@TotalDescuentos float,
@TotalAportes float,
@CtaAhorros int,
@FechaPago date,
@NetoAPagar float
)as begin update PagoDeUtilidades set
IdPlanilla =@IdPlanilla,
IdTrabajador=@IdTrabajador,
TotalRemuneraciones =@TotalRemuneraciones,
TotalDescuentos =@TotalDescuentos,
TotalAportes =@TotalAportes,
CtaAhorros =@CtaAhorros,
FechaPago =@FechaPago,
NetoAPagar =@NetoAPagar
where IdPagoUtilidades =@IdPagoUtilidades
end 
go

-- procedimiento para buscar pago Utilidades
create procedure spBuscarPagoUtilidades
@IdPagoUtilidades int
 as  begin
 select *from PagoDeUtilidades where IdPagoUtilidades like @IdPagoUtilidades;
 end

 --Procedimiento para eliminar un pago 
 create procedure spEliminarPagoUtilidad
@IdPagoUtilidades int
as
delete from PagoDeUtilidades where IdPagoUtilidades=@IdPagoUtilidades
go

--procedimineto para listar pago de utilidades 
create procedure spListarPagoUtilidades
as
select IdPagoUtilidades, IdPlanilla, IdTrabajador ,TotalRemuneraciones ,TotalDescuentos ,TotalAportes ,CtaAhorros ,FechaPago ,NetoAPagar 
	from PagoDeUtilidades
	go


	 -----------------------------------------------------------------------------------------------------------------
-- Para Mantenedor PEDIDO
------------------------------------------------------------------------------------------------------------------
--Tabla PEDIDO
CREATE TABLE PEDIDO(
IDPEDIDO int not null primary key identity(1,1), 
ENCARGADO varchar(50),
DNIR INT NOT NULL,
NOMBRER VARCHAR(100),
CORREOR VARCHAR (30),
TELEFONOR INT,
DIRECCIONR VARCHAR(60),
DISTRITOR VARCHAR(50),
PROVINCIAR VARCHAR(50),
DEPARTAMENTOR VARCHAR(50),

DNID INT NOT NULL,
NOMBRED VARCHAR(100),
CORREOD VARCHAR (30),
TELEFONOD INT,
DIRECCIOND VARCHAR(60),
DISTRITOD VARCHAR(50),
PROVINCIAD VARCHAR(50),
DEPARTAMENTOD VARCHAR(50),

CODIGOPEDIDO int,
CANTIDADPAQUETE INT,
CATEGORIAPAQUETE varchar(15),
DESCRIPCIONPAQUETE varchar(500),
);
GO

select *from PEDIDO
          --procedimiento almacenado para insertar un nuevo PAQUETE/PEDIDO
CREATE PROCEDURE spinsertarPedido(
@ENCARGADO varchar(50),
@DNIR INT ,
@NOMBRER VARCHAR(100),
@CORREOR VARCHAR (30),
@TELEFONOR INT,
@DIRECCIONR VARCHAR(60),
@DISTRITOR VARCHAR(50),
@PROVINCIAR VARCHAR(50),
@DEPARTAMENTOR VARCHAR(50),
@DNID INT,
@NOMBRED VARCHAR(100),
@CORREOD VARCHAR (30),
@TELEFONOD INT,
@DIRECCIOND VARCHAR(60),
@DISTRITOD VARCHAR(50),
@PROVINCIAD VARCHAR(50),
@DEPARTAMENTOD VARCHAR(50),
@CODIGOPEDIDO int,
@CANTIDADPAQUETE int,
@CATEGORIAPAQUETE varchar(15),
@DESCRIPCIONPAQUETE varchar(500)
)
as 
begin
insert into PEDIDO(ENCARGADO,DNIR,NOMBRER,CORREOR,TELEFONOR,DIRECCIONR,DISTRITOR,PROVINCIAR,DEPARTAMENTOR,DNID,NOMBRED,CORREOD,TELEFONOD,DIRECCIOND,DISTRITOD,PROVINCIAD,DEPARTAMENTOD,CODIGOPEDIDO,CANTIDADPAQUETE,CATEGORIAPAQUETE,DESCRIPCIONPAQUETE) 
	values(@ENCARGADO,@DNIR,@NOMBRER,@CORREOR,@TELEFONOR,@DIRECCIONR,@DISTRITOR,@PROVINCIAR,@DEPARTAMENTOR,@DNID,@NOMBRED,@CORREOD,@TELEFONOD,@DIRECCIOND,@DISTRITOD,@PROVINCIAD,@DEPARTAMENTOD,@CODIGOPEDIDO,@CANTIDADPAQUETE,@CATEGORIAPAQUETE,@DESCRIPCIONPAQUETE)
end
GO

-- buscar pedido
CREATE PROCEDURE  spBuscarPedido(
	@IdPedido int 
)
as begin
select * from  PEDIDO where IDPEDIDO =@IdPedido
end
GO

-- Listar  pedido
CREATE PROCEDURE  spListarPedido
	
as begin
select * from  PEDIDO 
end
GO
-- actualizar Pedido
create procedure spModificarPedido(
@IDPEDIDO int,
@ENCARGADO varchar(50),
@DNIR INT ,
@NOMBRER VARCHAR(100),
@CORREOR VARCHAR (30),
@TELEFONOR INT,
@DIRECCIONR VARCHAR(60),
@DISTRITOR VARCHAR(50),
@PROVINCIAR VARCHAR(50),
@DEPARTAMENTOR VARCHAR(50),
@DNID INT,
@NOMBRED VARCHAR(100),
@CORREOD VARCHAR (30),
@TELEFONOD INT,
@DIRECCIOND VARCHAR(60),
@DISTRITOD VARCHAR(50),
@PROVINCIAD VARCHAR(50),
@DEPARTAMENTOD VARCHAR(50),
@CODIGOPEDIDO int,
@CANTIDADPAQUETE int,
@CATEGORIAPAQUETE varchar(15),
@DESCRIPCIONPAQUETE varchar(500)
)
as 
begin
update PEDIDO  set 
ENCARGADO=@ENCARGADO,
DNIR=@DNIR,
NOMBRER=@NOMBRER,
CORREOR=@CORREOR,
TELEFONOR=@TELEFONOR,
DIRECCIONR=@DIRECCIONR,
DISTRITOR=@DISTRITOR,
PROVINCIAR=@PROVINCIAR,
DEPARTAMENTOR=@DEPARTAMENTOR,
DNID=@DNID,
NOMBRED=@NOMBRED,
CORREOD=@CORREOD,
TELEFONOD=@TELEFONOD,
DIRECCIOND=@DIRECCIOND,
DISTRITOD=@DISTRITOD,
PROVINCIAD=@PROVINCIAD,
DEPARTAMENTOD=@DEPARTAMENTOD,
CODIGOPEDIDO=@CODIGOPEDIDO,
CANTIDADPAQUETE=@CANTIDADPAQUETE,
CATEGORIAPAQUETE=@CATEGORIAPAQUETE,
DESCRIPCIONPAQUETE=@DESCRIPCIONPAQUETE
where IDPEDIDO =@IDPEDIDO
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

----------------------------------------------------------------
--						Para Proceso Tabla Cotizacion						
----------------------------------------------------------------
--TABLA COTIZACION
Create table Cotizacion(
IdCotizacion INT PRIMARY key identity(1,1), 
Descripcion VARCHAR(250),
precio float,
IDPEDIDO INT not null,
constraint Fk_IdPedido foreign key (IDPEDIDO) references Pedido(IDPEDIDO)
);

SELECT * FROM Cotizacion
--INSERTAR COTIZACION
create procedure spInsertarCotizacion( 
@Descripcion VARCHAR(250),
@precio float(20),
@IDPEDIDO INT
)
as begin
insert into Cotizacion(Descripcion,precio,IDPEDIDO) values 
(@Descripcion,@precio,@IDPEDIDO)
end ;
go
--LISTAR COTIZACION
create procedure spListarCotizacion
as
select IdCotizacion,IDPEDIDO, Descripcion,precio 
	from Cotizacion
	go

--MODIFICAR COTIZACION
create procedure spModificarCotizacion(
@IdCotizacion int,
@Descripcion VARCHAR(250),
@precio float,
@IDPEDIDO int
)
as begin update Cotizacion set
Descripcion=@Descripcion,
precio=@precio,
IDPEDIDO=@IDPEDIDO
where IdCotizacion=@IdCotizacion
end 
go


--BUSCAR COTIZACION
 create procedure spBuscarCotizacion
 @id int
 as  begin
 select *from Cotizacion where IdCotizacion like @id;
 end
 --ELIMINAR COTIZACION
create procedure spEliminarCotizacion
@Id int
as
delete from Cotizacion where IdCotizacion=@Id
go

--TABLA DE FICHA ESTADO VEHICULAR 
create table FichaEstadoVehiculo(
IdEstadoVehiculo int not null primary key identity(1,1),
IdConductor int,
IdVehiculo int, 
Fecha date,
SistemaElectrico varchar(500),
SistemeMecanico varchar(500),
LetoneriayPintura varchar(500),
Otros varchar(500),
constraint Fk_IdConductorFE foreign key(IdConductor) references Trabajadores(IdTrabajador),
constraint Fk_IdVehiculoFE foreign key(IdVehiculo) references Vehiculo(IdVehiculo) 
)

--Procedimiento para insertar ficha estado vehiculo
create procedure spInsertarFichaEstadoVehiculo( 
@IdConductor int,
@IdVehiculo int, 
@Fecha date,
@SistemaElectrico varchar(500),
@SistemeMecanico varchar(500),
@LetoneriayPintura varchar(500),
@Otros varchar(500)
)as begin
insert into FichaEstadoVehiculo(IdConductor,IdVehiculo,Fecha, SistemaElectrico, SistemeMecanico, LetoneriayPintura, Otros ) values 
(@IdConductor,@IdVehiculo,@Fecha,@SistemaElectrico, @SistemeMecanico, @LetoneriayPintura, @Otros)
end 
go


--procedimiento para listar Ficha 
create procedure spListarFichaEstado
as
select IdEstadoVehiculo,IdConductor,IdVehiculo, Fecha,SistemaElectrico ,SistemeMecanico ,LetoneriayPintura ,Otros 
	from FichaEstadoVehiculo
	go
	
	
--Editar ficha estado
create procedure spModificarFichaEstadoVehiculo(
@IdEstadoVehiculo int,
@IdConductor int,
@IdVehiculo int, 
@Fecha date,
@SistemaElectrico varchar(500),
@SistemeMecanico varchar(500),
@LetoneriayPintura varchar(500),
@Otros varchar(500)
)
as begin update FichaEstadoVehiculo set
IdConductor=@IdConductor,
IdVehiculo=@IdVehiculo, 
Fecha=@Fecha,
SistemaElectrico=@SistemaElectrico,
SistemeMecanico=@SistemeMecanico,
LetoneriayPintura=@LetoneriayPintura,
Otros=@Otros
where IdEstadoVehiculo=@IdConductor
end 
go

--Buscar ficha vehiculo
 create procedure spBuscarFichaEstado
 @IdEstadoVehiculo int
 as  begin
 select *from FichaEstadoVehiculo where IdEstadoVehiculo like @IdEstadoVehiculo;
 end
 go
 --Eliminar ficha vehiuclo
create procedure spEliminarFichaEstadoVehiculo
@IdEstadoVehiculo int
as
delete from FichaEstadoVehiculo where IdEstadoVehiculo=@IdEstadoVehiculo
go

--Tabla gastos de viaje
create table GastosViaje(
IdGastosViaje int not null primary key identity(1,1),
IdProgramaciondesalida int,
Fecha date,
Viaticos varchar(200),
preciosviaticos float,
Combustible varchar(200),
precioscombustible float,
Otros varchar(200),
preciosotros float,
Total float,
constraint Fk_IdProgramacionSalida foreign key(IdProgramaciondesalida) references ProgramacionSalida(IdProgramacionSalida)
)
 
--Insertar GastosDeViaje
Create procedure spInsertarGastosViaje( 
@IdProgramaciondesalida int,
@Fecha date,
@Viaticos varchar(200),
@preciosviaticos float,
@Combustible varchar(200),
@precioscombustible float,
@Otros varchar(200),
@preciosotros float,
@Total float
)as begin
insert into GastosViaje(IdProgramaciondesalida,Fecha,Viaticos, preciosviaticos, Combustible, precioscombustible, Otros, preciosotros,Total ) values 
(@IdProgramaciondesalida,@Fecha,@Viaticos,@preciosviaticos, @Combustible, @precioscombustible, @Otros, @precioscombustible,@Total)
end 
go

--Procedimiento para listar gastos de viaje 
create procedure spListarGastosViaje
as
select IdGastosViaje, IdProgramaciondesalida,Fecha,Viaticos, preciosviaticos, Combustible, precioscombustible, Otros, preciosotros,Total 
	from GastosViaje
	go


--Editar gastos viaje
create procedure spModificarGastosViaje(
@IdGastosViaje int,
@IdProgramaciondesalida int,
@Fecha date,
@Viaticos varchar(200),
@preciosviaticos float,
@Combustible varchar(200),
@precioscombustible float,
@Otros varchar(200),
@preciosotros float,
@Total float
)
as begin update GastosViaje set
IdProgramaciondesalida=@IdProgramaciondesalida,
Fecha=@Fecha,
Viaticos=@Viaticos,
preciosviaticos=@preciosviaticos,
Combustible=@Combustible,
precioscombustible=@precioscombustible,
Otros=@Otros,
preciosotros=@preciosotros,
Total=@Total
where IdGastosViaje=@IdGastosViaje
end 
go

--Buscar gastos viaje 
 create procedure spBuscarGastosViaje
 @IdGastosViaje int
 as  begin
 select *from GastosViaje where IdGastosViaje like @IdGastosViaje;
 end


 --Eliminar Gastos de Viaje
 create procedure spEliminarGastosViaje
@IdGastosViaje int
as
delete from GastosViaje where IdGastosViaje=@IdGastosViaje
go

