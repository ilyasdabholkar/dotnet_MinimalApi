CREATE PROCEDURE [dbo].[spUser_Get]
	@Id int
AS
Begin
	SELECT Id,FirstName,LastName
	From [dbo].[User]
	Where Id=@Id;
End
