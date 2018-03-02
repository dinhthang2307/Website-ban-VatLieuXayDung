CREATE TABLE [dbo].[Book]
(
BookId int identity(1,1) not null,
Title nvarchar(50),
CateId int,
AuthorId int,
PubId int, 
Summary nvarchar(200),
ImgUrl nvarchar(200),
Price float,
Quantity int,  
CreatedDate DateTime,
ModifiedDate DateTime,
IsActive Bit,
 primary key CLUSTERED (BookId ASC)
)
