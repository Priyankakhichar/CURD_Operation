CREATE PROCEDURE [dbo].[GetEmployeeById]
(
@EmpId varchar(50)
)   
AS
BEGIN
Select * from EmployeeDetails where EmpId = @EmpId
END