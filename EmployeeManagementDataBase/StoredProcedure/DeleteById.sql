CREATE PROCEDURE [dbo].[DeleteById]
(
@EmpId varchar(50)
)   
AS
BEGIN
Delete from EmployeeDetails where EmpId = @EmpId
END
SELECT * FROM EmployeeDetails
RETURN 0