CREATE PROCEDURE [dbo].[UpdateEmployee]
@EmpId varchar(50),
@Firstname varchar(50),
   @Lastname varchar(50),
   @Contact varchar(50),
      @City varchar(50),
   @Email varchar(50)
AS
BEGIN
Update EmployeeDetails
set EmpId = @EmpId, 
    Firstname = @Firstname,
     Lastname = @Lastname,
	 Contact = @Contact,
	  City = @City,
	 Email = @Email
	 where EmpId = @EmpId
	 END
SELECT * FROM EmployeeDetails
RETURN 0