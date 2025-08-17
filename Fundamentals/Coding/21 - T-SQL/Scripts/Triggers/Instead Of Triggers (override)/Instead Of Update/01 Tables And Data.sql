
CREATE TABLE PersonalInfo (
    StudentID INT PRIMARY KEY,
    Name NVARCHAR(100),
    Address NVARCHAR(255)
);

Go

CREATE TABLE AcademicInfo (
    StudentID INT PRIMARY KEY,
    Course NVARCHAR(100),
    Grade INT,
    FOREIGN KEY (StudentID) REFERENCES PersonalInfo(StudentID)
);

Go

CREATE VIEW StudentView AS
SELECT P.StudentID, P.Name, P.Address, A.Course, A.Grade
FROM PersonalInfo P
JOIN AcademicInfo A ON P.StudentID = A.StudentID;

go

INSERT INTO PersonalInfo (StudentID, Name, Address) VALUES
(1, 'John Doe', '123 Main St'),
(2, 'Jane Smith', '456 Oak Ave');

Go

INSERT INTO AcademicInfo (StudentID, Course, Grade) VALUES
(1, 'Computer Science', 90),
(2, 'Mathematics', 85);

Go
