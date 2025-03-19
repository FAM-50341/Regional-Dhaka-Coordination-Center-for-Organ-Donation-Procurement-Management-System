CREATE TABLE [dbo].[Hospital] (
    [HId]           INT           NOT NULL,
    [HName]         VARCHAR (500) NOT NULL,
    [HAdress]       VARCHAR (50)  NOT NULL,
    [HGovtapproved] INT           NOT NULL,
    PRIMARY KEY CLUSTERED ([HId] ASC)
);
