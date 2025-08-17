CREATE TABLE Employees6 (
    EmployeeId INT PRIMARY KEY,
    Name VARCHAR(100),
    Sales DECIMAL(10, 2),
    Department VARCHAR(50)
);

INSERT INTO Employees6 (EmployeeId, Name, Sales, Department) VALUES
(1, 'John Doe', 50000.00, 'Sales'),
(2, 'Jane Smith', 40000.00, 'Sales'),
(3, 'Alice Johnson', 60000.00, 'Marketing'),
(4, 'Bob Williams', 45000.00, 'Sales'),
(5, 'Mike Brown', 55000.00, 'IT');
