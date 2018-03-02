CREATE TABLE [dbo].[Users]
	(
	UserName varchar(20) not null,
	Pass varchar(20) not null,
	Email nvarchar(200) not null,
	IsActive Bit,
	 primary key CLUSTERED (UserName ASC)
	)