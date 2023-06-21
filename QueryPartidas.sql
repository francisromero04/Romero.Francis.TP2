CREATE DATABASE Truco_Simulador;
GO

USE Truco_Simulador;
GO

CREATE TABLE Partidas (
	IdPartidas INT IDENTITY(1,1) PRIMARY KEY,
	Jugador1 VARCHAR(50),
	PuntajeJugador1 INT,
	Jugador2 VARCHAR(50),
	PuntajeJugador2 INT,
	Ganador VARCHAR(50)
	);