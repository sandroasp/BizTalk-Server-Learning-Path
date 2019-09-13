USE [CustomProperties]
GO

INSERT INTO [dbo].[Configurations]
           ([KeyName]
           ,[KeyValue])
     VALUES
           ('WhoIs'
           ,'Although the deployment can also be archive very easy that is a false sensation because we need to statically specify the connstring to use inside the DatabaseLookup Functoid to extract info')
GO


