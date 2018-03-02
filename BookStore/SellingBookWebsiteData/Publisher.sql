CREATE TABLE [dbo].[Publisher]
		(
	PubId int identity(1,1) not null,
	Name nvarchar(50),
	Summary nvarchar(200),
	 primary key CLUSTERED (PubId ASC)
	)