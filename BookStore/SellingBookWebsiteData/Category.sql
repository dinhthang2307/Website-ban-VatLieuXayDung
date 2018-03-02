CREATE TABLE [dbo].[Category]
	(
	CateID int identity(1,1) not null,
	CateName nvarchar(50),
	Summary nvarchar(200),
	 primary key CLUSTERED (CateID ASC)
	)