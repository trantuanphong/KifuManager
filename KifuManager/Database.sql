USE [master]
GO

CREATE DATABASE [GoBase]
GO

USE [GoBase]

CREATE TABLE Title (
	TitleID		INT IDENTITY(1,1)	NOT NULL,
	TitleName	NVARCHAR(50)		NOT NULL,
	Point		INT					NOT NULL,
	CONSTRAINT [PK_Title] PRIMARY KEY (TitleID),
) 

CREATE TABLE [UserAcc] (
	Username	NVARCHAR(50)		NOT NULL,
	[Password]	NVARCHAR(50)		NOT NULL,
	Email		NVARCHAR(50)		NOT NULL,
	APoint		INT					NOT NULL,
	TitleID		INT					NULL,
	[Status]	BIT					NOT NULL,
	[Type]		INT					NOT NULL,
	CONSTRAINT [PK_User] PRIMARY KEY (Username),
	CONSTRAINT [FK_User_Title] FOREIGN KEY (TitleID) REFERENCES Title(TitleID),
) 

CREATE TABLE Opening (
	OpenID		INT IDENTITY(1,1)	NOT NULL,
	OpenName	NVARCHAR(50)		NOT NULL,
	[Description]   NVARCHAR(MAX)		NOT NULL,
	CONSTRAINT [PK_Opening] PRIMARY KEY (OpenID),
) 

CREATE TABLE OpenSequence (
	OpenID		INT					NOT NULL,
	[Move]		INT IDENTITY(1,1)	NOT NULL,
	Position	VARCHAR(10)			NOT NULL,
	CONSTRAINT [PK_OpenSequence] PRIMARY KEY (OpenID,[Move]),
	CONSTRAINT [FK_Opening_OpenSequence] FOREIGN KEY (OpenID) REFERENCES [Opening](OpenID),
) 

CREATE TABlE Kifu (
	KifuID		INT IDENTITY(1,1)	NOT NULL,
	[Rule]		NVARCHAR(50)		NOT NULL,
	Size		INT					NOT NULL,
	Komi		FLOAT				NOT NULL,
	GameName	NVARCHAR(100)		NULL,
	[Event]		NVARCHAR(100)		NULL,
	WhitePlayer	NVARCHAR(50)		NOT NULL,
	BlackPlayer	NVARCHAR(50)		NOT NULL,
	WhiteLevel	VARCHAR(10)			NULL,
	BlackLevel	VARCHAR(10)			NULL,
	[Date]		DATE				NULL,
	Result		VARCHAR(10)			NULL,
	Uploader	NVARCHAR(50)		NOT NULL,
	CONSTRAINT [PK_Kifu] PRIMARY KEY (KifuID),
	CONSTRAINT [FK_Kifu_User] FOREIGN KEY (Uploader) REFERENCES [UserAcc](Username),
) 

CREATE TABLE KifuEvent (
	KifuID		INT					NOT NULL,
	[Move]		INT IDENTITY(1,1)	NOT NULL,
	Position	VARCHAR(10)			NOT NULL,
	Comment		NVARCHAR(MAX)		NULL,
	CONSTRAINT [PK_KifuEvent] PRIMARY KEY (KifuID,[Move]),
	CONSTRAINT [FK_Kifu_KifuEvent] FOREIGN KEY (KifuID) REFERENCES [Kifu](KifuID),
)

CREATE TABLE KifuOpen (
	KifuID		INT					NOT NULL,
	OpenID		INT					NOT NULL,
	Player		NVARCHAR(50)		NOT NULL,
	CONSTRAINT [PK_KifuOpen] PRIMARY KEY (KifuID,OpenID,Player),	
	CONSTRAINT [FK_KifuOpen_Kifu] FOREIGN KEY (KifuID) REFERENCES [Kifu](KifuID),
	CONSTRAINT [FK_KifuOpen_Opening] FOREIGN KEY (OpenID) REFERENCES Opening(OpenID),
) 

CREATE TABLE FavouriteKifu (
	KifuID		INT					NOT NULL,
	Username	NVARCHAR(50)		NOT NULL,
	CONSTRAINT [PK_FavouriteKifu] PRIMARY KEY (KifuID,Username),
	CONSTRAINT [FK_FavouriteKifu_Kifu] FOREIGN KEY (KifuID) REFERENCES [Kifu](KifuID),
	CONSTRAINT [FK_FavouriteKifu_UserAcc] FOREIGN KEY (Username) REFERENCES [UserAcc](Username),
)

CREATE TABLE KifuRating (
	KifuID		INT					NOT NULL,
	Username	NVARCHAR(50)		NOT NULL,
	RatePoint	INT					NOT NULL,
	Comment		NVARCHAR(MAX)		NOT NULL,
	CONSTRAINT	[PK_KifuRating] PRIMARY KEY (KifuID,Username),
	CONSTRAINT [FK_KifuRating_Kifu] FOREIGN KEY (KifuID) REFERENCES [Kifu](KifuID),
	CONSTRAINT [FK_KifuRating_UserAcc] FOREIGN KEY (Username) REFERENCES [UserAcc](Username),
) 