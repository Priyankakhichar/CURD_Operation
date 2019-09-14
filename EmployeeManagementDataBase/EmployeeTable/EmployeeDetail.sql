CREATE TABLE [dbo].[EmployeeDetail]
(
	[Id] INT NOT NULL PRIMARY KEY, 
    [EmpId] VARCHAR(50) NOT NULL, 
    [FirstName] VARCHAR(50) NOT NULL, 
    [LastName] VARCHAR(50) NULL, 
    [Contact] VARCHAR(50) NOT NULL, 
    [City] VARCHAR(50) NOT NULL, 
    [Email] VARCHAR(50) NULL, 
    [Salary] VARCHAR(50) NULL
)
