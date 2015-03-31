USE SoftUni
GO

CREATE PROCEDURE usp_GetAllProjectsForEmployee (@firstName NVARCHAR(MAX), @lastName NVARCHAR(MAX))
AS
	SELECT p.Name
	FROM Employees AS e
		JOIN EmployeesProjects AS ep
			ON ep.EmployeeID = e.EmployeeID
		JOIN Projects AS p
			ON p.ProjectID = ep.ProjectID
	WHERE e.FirstName = @firstName AND 
		e.LastName = @lastName
GO

EXEC usp_GetAllProjectsForEmployee 'Roberto', 'Tamburello'
