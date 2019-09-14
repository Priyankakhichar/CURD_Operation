CREATE PROCEDURE [dbo].[spAddEmployee]
@EmpId varchar(50),
@Firstname varchar(50),
   @Lastname varchar(50),
   @Contact varchar(50),
   @City varchar(50),
   @Email varchar(50),
   @Salary varchar(50)
AS
BEGIN
INSERT INTO EmployeeDetails(EmpId,Firstname,Lastname,Contact,City,Email,Salary)
VALUES (@EmpId,@Firstname, @Lastname,@Contact,@City,@Email,@Salary)
END
SELECT * FROM EmployeeDetails
RETURN 0
