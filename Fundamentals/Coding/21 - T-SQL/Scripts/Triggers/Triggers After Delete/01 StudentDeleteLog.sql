

CREATE TABLE StudentDeleteLog (
    LogID INT IDENTITY PRIMARY KEY,
    StudentID INT,
    Name NVARCHAR(50),
    Subject NVARCHAR(50),
    Grade INT,
    DeletedDateTime DATETIME DEFAULT GETDATE()
);