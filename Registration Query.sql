CREATE TABLE [dbo].[registration] (
    [Name]              VARCHAR (50) NOT NULL,
    [Date_of_Birth]     VARCHAR (50) NOT NULL,
    [Medical_Insurance] INT          NOT NULL,
    [Medical_History]   VARCHAR (50) NOT NULL,
    [Street]            VARCHAR (50) NOT NULL,
    [City]              VARCHAR (50) NOT NULL,
    [State]             VARCHAR (50) NOT NULL,
    [Blood_Group]       VARCHAR (50) NOT NULL,
    [Phone_Number]      VARCHAR (11) NOT NULL,
    [Password]          VARCHAR (50) NOT NULL,
    [Confirm_Password]  VARCHAR (50) NOT NULL,
    PRIMARY KEY CLUSTERED ([Phone_Number] ASC)
);
