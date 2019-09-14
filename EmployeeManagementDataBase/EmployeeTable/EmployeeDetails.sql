CREATE TABLE [dbo].[EmployeeDetails]
(
	[EmpId] VARCHAR(50) NOT NULL PRIMARY KEY, 
    [Firstname] VARCHAR(50) NOT NULL, 
    [Lastname] VARCHAR(50) NULL, 
    [Contact] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Salary] VARCHAR(50) NULL
)
