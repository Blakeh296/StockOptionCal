--UOELKEB


/*
						********** WARNING, DO NOT RUN ENTIRE SCRIPT AT RISK OF LOSING DATA *************
						********** WARNING, DO NOT RUN ENTIRE SCRIPT AT RISK OF LOSING DATA *************
						********** WARNING, DO NOT RUN ENTIRE SCRIPT AT RISK OF LOSING DATA *************
*/

USE [master]
GO
		PRINT ''
		PRINT 'Database'
		PRINT ''

IF EXISTS (SELECT * FROM Sys.databases WHERE Name = 'VolCalDb') DROP DATABASE VolCalDb

	PRINT 'VolCalDb DROPPED'

CREATE DATABASE VolCalDb
GO

	PRINT 'VolCalDb CREATED'
	PRINT ''
	PRINT 'Tables'
	PRINT ''

USE VolCalDb
GO

CREATE TABLE CompInfo(symblID INT IDENTITY(1,1),
					symbl VARCHAR(15) NOT NULL,
					companyName VARCHAR(155) NOT NULL,
					PRIMARY KEY (symblID))

CREATE TABLE DailyVolCal(
					dVolCalID int Identity(1,1),
					dsymblID INT NULL,
					symbl VARCHAR(15) NOT NULL,
					pps MONEY NOT NULL,
					iv DECIMAL NOT NULL,
					dailyIV DECIMAL NOT NULL,
					dPPSMove MONEY NOT NULL,
					dPPSLow MONEY NOT NULL,
					dPPSHigh MONEY NOT NULL,
					calDate DATETIME NULL,
					PRIMARY KEY (dVolCalID))

CREATE TABLE CustomVolCal(
						cVolCalID INT IDENTITY(1,1),
						csymblID INT NULL,
						symbl VARCHAR(15) NOT NULL,
						pps MONEY NOT NULL,
						iv DECIMAL NOT NULL,
						customIV DECIMAL NOT NULL,
						cPPSMove MONEY NOT NULL,
						cPPSLow MONEY NOT NULL,
						cPPSHigh MONEY NOT NULL,
						daysCal INT NULL,
						calDate DATETIME NULL,
						PRIMARY KEY (cVolCalID))


ALTER TABLE CustomVolCal ADD CONSTRAINT FK_csymblID FOREIGN KEY (csymblID)
REFERENCES CompInfo (symblID)
GO

ALTER TABLE DailyVolCal ADD CONSTRAINT FK_dSymblID FOREIGN KEY (dsymblID)
REFERENCES CompInfo (symblID)
GO

CREATE PROC insertDVolCal
( @symbl VARCHAR(15), @pps MONEY, @iv DECIMAL, @dailyIV DECIMAL, @dPPSMove MONEY,  @dPPSLow MONEY, @dPPSHigh MONEY, @calDate DATETIME)
AS
	BEGIN
		INSERT INTO DailyVolCal (symbl,pps,iv,dailyIV,dPPSMove,dPPSLow,dPPSHigh,calDate)
		VALUES (@symbl, @pps, @iv, @dailyIV,  @dPPSMove,  @dPPSLow, @dPPSHigh, @calDate)
		RETURN
	END
	GO

CREATE PROC insertCVolCal
(@Symbl VARCHAR(15), @PPS MONEY, @IV DECIMAL,@CustomIV DECIMAL,@CPPSMove MONEY,@CPPSLow MONEY, @CPPSHigh MONEY, @DaysCal INT, @CalDate DATETIME)
AS
	BEGIN
		INSERT INTO CustomVolCal (symbl, pps, iv,customIV,cPPSMove,cPPSLow,cPPSHigh,daysCal,calDate)
		VALUES (@Symbl, @PPS, @IV,@CustomIV,@CPPSMove,@CPPSLow, @CPPSHigh,  @DaysCal, @CalDate)
		RETURN
	END
	GO

	select * from DailyVolCal