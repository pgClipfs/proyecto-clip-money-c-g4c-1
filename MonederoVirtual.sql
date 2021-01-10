CREATE DATABASE MonederoVirtual
GO

USE MonederoVirtual
GO
CREATE TABLE Usuario(
	IdUsuario varchar(16) PRIMARY KEY,
	DNI int NOT NULL, 
	Nombre varchar(20) NOT NULL,
	Apellido varchar(20)  NOT NULL,
	Contraseña varchar(20) NOT NULL,
	Telefono int NULL,
	Email varchar(30) NOT NULL,
	Direccion varchar(20) NOT NULL,
	Numeracion int NOT NULL
)

CREATE TABLE Ingresos(
	IdIngresos int IDENTITY (1,1) PRIMARY KEY,
	Fecha datetime NOT NULL,
	Monto int NOT NULL,
	Detalle varchar(10) NOT NULL
)

CREATE TABLE Egresos(
	IdEgresos int IDENTITY (1,1) PRIMARY KEY,
	Fecha datetime NOT NULL,
	Monto int NOT NULL,
	Detalle varchar(10) NOT NULL
)

CREATE TABLE CajaMonedaLocal(
	IdMonedaLocal int IDENTITY (1,1) PRIMARY KEY,
	Monto int NULL,
	IdEgresos int NULL,
	IdIngresos int NULL

	CONSTRAINT Relacion_a_Ingresos FOREIGN KEY (IdIngresos) REFERENCES Ingresos(IdIngresos),
	CONSTRAINT Relacion_a_Egresos FOREIGN KEY (IdEgresos) REFERENCES Egresos(IdEgresos)
)

CREATE TABLE Cuenta(
	CBU int  IDENTITY (100000000,1) PRIMARY KEY,
	IdUsuario varchar(16) NOT NULL,
	IdMonedaLocal int NULL,
	idHistorial int NULL,
	IdAmigos int NULL

	CONSTRAINT Relacion_a_Usuario FOREIGN KEY (IdUsuario) REFERENCES Usuario(IdUsuario),
	CONSTRAINT Relacion_a_Moneda_Local FOREIGN KEY (IdMonedaLocal) REFERENCES CajaMonedaLocal(IdMonedaLocal)
)

CREATE TABLE Historial(
	IdHistorial int IDENTITY (1,1) PRIMARY KEY,
	IdIngresos int NULL,
	IdEgresos int NULL
	CONSTRAINT Relacion_a_Ingresos_H FOREIGN KEY (IdIngresos) REFERENCES Ingresos(IdIngresos),
	CONSTRAINT Relacion_a_Egresos_H FOREIGN KEY (IdEgresos) REFERENCES Egresos(IdEgresos)
)

CREATE TABLE Amigos(
	IdAmigos int IDENTITY (1,1) PRIMARY KEY,
	IDUsuario varchar(16) NULL,
	CBU int NULL,
	CONSTRAINT Relacion_a_Usuario_A FOREIGN KEY (IDUsuario) REFERENCES Usuario(IDUsuario),
	CONSTRAINT Relacion_a_Cuenta_A FOREIGN KEY (CBU) REFERENCES Cuenta(CBU)
)
