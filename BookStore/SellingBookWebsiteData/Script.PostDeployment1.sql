/*
Post-Deployment Script Template							
--------------------------------------------------------------------------------------
 This file contains SQL statements that will be appended to the build script.		
 Use SQLCMD syntax to include a file in the post-deployment script.			
 Example:      :r .\myfile.sql								
 Use SQLCMD syntax to reference a variable in the post-deployment script.		
 Example:      :setvar TableName MyTable							
               SELECT * FROM [$(TableName)]					
--------------------------------------------------------------------------------------
*/

MERGE INTO Users AS Target 
USING (VALUES 
        ('Admin', '12345678', 'dinhthang2307@gmail.com', 1)
) 
AS Source (UserName, Pass, Email, IsActive) 
ON Target.UserName = Source.UserName 
WHEN NOT MATCHED BY TARGET THEN 
INSERT (UserName, Pass, Email, IsActive)
VALUES (UserName, Pass, Email, IsActive);