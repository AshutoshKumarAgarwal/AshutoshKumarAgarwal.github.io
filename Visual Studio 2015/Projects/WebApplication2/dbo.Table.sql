CREATE TABLE [dbo].[Table]
(
	[ID] NUMERIC NOT NULL PRIMARY KEY, 
    [Person_ID] NUMERIC NOT NULL, 
    [AddressLine1] VARCHAR(100) NOT NULL, 
    [AddressLine2] VARCHAR(100) NULL, 
    [City] VARCHAR(100) NOT NULL, 
    [State] VARCHAR(100) NOT NULL, 
    [Zip] NUMERIC NULL, 
    [Country] VARCHAR(100) NOT NULL, 
    CONSTRAINT [PK_Table] PRIMARY KEY ([ID]), 
    CONSTRAINT [FK_Person_PersonAddress] FOREIGN KEY (ID) REFERENCES Person(Id), 
    
)
