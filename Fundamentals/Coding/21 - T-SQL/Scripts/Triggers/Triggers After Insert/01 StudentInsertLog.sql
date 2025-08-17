
-- Table for logging new student entries
CREATE TABLE StudentInsertLog (
    LogID INT IDENTITY PRIMARY KEY,
    StudentID INT,
    Name NVARCHAR(50),
    Subject NVARCHAR(50),
    Grade INT,
    InsertedDateTime DATETIME DEFAULT GETDATE()
);

