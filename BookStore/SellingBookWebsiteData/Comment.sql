CREATE TABLE [dbo].[Comment]
	(
	CommentId int identity(1,1) not null,
	BookId nvarchar(50),
	Content nvarchar(200),
	 primary key CLUSTERED (CommentId ASC)
	)