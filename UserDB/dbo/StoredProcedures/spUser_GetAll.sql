CREATE PROCEDURE [dbo].[spUser_GetAll]
AS
Begin
	SELECT Id,FirstName,LastName
	From [dbo].[User];
End
