CREATE PROCEDURE [dbo].[DeleteById]
(
@FirstName int
)   
AS
BEGIN
Delete from EmployeeDetails where FirstName = @FirstName
END
SELECT * FROM EmployeeDetails
RETURN 0