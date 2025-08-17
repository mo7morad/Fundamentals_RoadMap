

-- Table for logging grade updates
CREATE TABLE StudentUpdateLog (
    LogID INT IDENTITY PRIMARY KEY,
    StudentID INT,
    OldGrade INT,
    NewGrade INT,
    UpdatedDateTime DATETIME DEFAULT GETDATE()
);

