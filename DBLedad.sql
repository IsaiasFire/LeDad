
use LEDAD

create table Usuario
(
  UsuarioID int primary key identity(1,1),
  Nombre varchar(50),
  Apellido varchar(50),
  Cedula varchar(15),
  CorreoElectronico varchar(50),
  NombreDeUsuario varchar(50),
  ClaveDeAcceso varchar(50)
)
drop table Usuario

insert into Usuario(Nombre, Apellido, Cedula, CorreoElectronico, NombreDeUsuario, ClaveDeAcceso) values ( 'Isaias', 'De Leon', '402-2809834-5', 'FireMan@hola.com', 'FireMan', '12345')
select * from usuario

create table Estudiante 
(
  EstudianteID int primary key identity(1,1),
  Nombre varchar(50),
  Apellido varchar(50),
  Sexo varchar(15),
  FechaNacimiento varchar(20),
  Edad int,
  NombreTutor varchar(70),
  TelefonoTutor varchar(15)
)

drop table Estudiante
select * from Estudiante
select * from Usuario