CREATE PROCEDURE [dbo].[spRetriveRecords]
(
@Firstname varchar(50),
   @Lastname varchar(50),
   @City varchar(50),
   @Contact varchar(50),
   @Gender varchar(50)
)
AS
begin
Select * from EmployeeDetails
END