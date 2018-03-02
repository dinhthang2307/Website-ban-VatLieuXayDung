CREATE TABLE [dbo].[Author]
	(
	AuthorId int identity(1,1) not null,
	AuthorName nvarchar(50),
	History nvarchar(200),
	 primary key CLUSTERED (AuthorId ASC)
	)
