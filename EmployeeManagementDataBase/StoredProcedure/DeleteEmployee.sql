CREATE PROCEDURE [dbo].[DeleteEmployee]
@EmpId varchar(50),
@Firstname varchar(50),
   @Lastname varchar(50),
   @Contact varchar(50),
     @City varchar(50),
   @Email varchar(50),
   @Salary varchar(50)
AS
BEGIN
Delete from EmployeeDetails
END
SELECT * FROM EmployeeDetails
RETURN 0