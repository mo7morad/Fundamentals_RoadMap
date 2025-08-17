

CREATE TABLE Employees7 (
    EmployeeID INT PRIMARY KEY,
    ManagerID INT NULL,
    Name VARCHAR(50)
);

INSERT INTO Employees7 (EmployeeID, ManagerID, Name)
VALUES
    (1, NULL, 'CEO'),
    (2, 1, 'VP of Sales'),
    (3, 1, 'VP of Marketing'),
    (4, 2, 'Sales Manager'),
    (5, 2, 'Sales Representative'),
    (6, 3, 'Marketing Manager'),
    (7, 4, 'Sales Associate'),
    (8, 6, 'Marketing Specialist'),
	(9, 1, 'VP IT');