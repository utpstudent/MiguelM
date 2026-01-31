CREATE DATABASE ConversionesDB;
GO

USE ConversionesDB;
GO

CREATE TABLE HistorialConversiones (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Fecha DATETIME DEFAULT GETDATE(),
    TipoConversion VARCHAR(20),
    ValorIngresado DECIMAL(18,3),
    Euro DECIMAL(18,3),
    Dolar DECIMAL(18,3),
    Peso DECIMAL(18,3)
);


Select * from HistorialConversiones;
Go