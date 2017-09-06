BACKUP DATABASE [BmiDB] 
	TO  DISK = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\Backup\BmiDB.bak' WITH NOFORMAT, 
	NOINIT,  
	NAME = N'BmiDB-Full Database Backup',
	SKIP, 
	NOREWIND, 
	NOUNLOAD,  
	STATS = 10
GO
