CREATE TABLE [dbo].[AddNewPatient] (
    [PId]         INT           IDENTITY (1, 1) NOT NULL,
    [PName]       VARCHAR (100) NOT NULL,
    [PFathername] VARCHAR (100) NOT NULL,
    [PMothername] VARCHAR (100) NOT NULL,
    [PDOB]        VARCHAR (50)  NOT NULL,
    [PMobile]     VARCHAR (50)  NOT NULL,
    [PGender]     VARCHAR (50)  NOT NULL,
    [PEmail]      VARCHAR (100) NOT NULL,
    [PBloodgroup] VARCHAR (50)  NOT NULL,
    [PAdress]     VARCHAR (100) NOT NULL,
    PRIMARY KEY CLUSTERED ([PId] ASC)
);

