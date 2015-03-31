---------------------------------------------------------------
-- Problem 4 --
---------------------------------------------------------------

USE master
GO

DROP DATABASE ATM

CREATE DATABASE ATM

USE ATM
GO

CREATE TABLE CardAccounts(
	Id int IDENTITY NOT NULL,
	CardNumber char(10) NOT NULL,
	CardPIN  char(4) NOT NULL,
	CardCash money DEFAULT 0 NOT NULL,
	CONSTRAINT PK_CardAccounts PRIMARY KEY (Id),
	CONSTRAINT UK_CardNumber UNIQUE (CardNumber),
	CONSTRAINT CHK_CardCash CHECK (CardCash >= 0)
)

/*
DROP TABLE CardAccounts
GO
*/

INSERT INTO CardAccounts (CardNumber, CardPIN, CardCash)
VALUES ('1234567890', '4725', 1000),
	   ('7589641203', '3695', 5000),
	   ('7525771203', '1188', 800),
	   ('7735241203', '3693', 1200),
	   ('1289641568', '3695', 900)

---------------------------------------------------------------
-- Problem 6 --
---------------------------------------------------------------

CREATE TABLE TransactionHistory(
	Id int IDENTITY NOT NULL,
	CardNumber char(10) NOT NULL,
	TransactionDate datetime NOT NULL,
	Amount money NOT NULL,
	CONSTRAINT PK_TransactionHistory PRIMARY KEY (Id),
	CONSTRAINT CHK_Amount CHECK (Amount >= 0)
)