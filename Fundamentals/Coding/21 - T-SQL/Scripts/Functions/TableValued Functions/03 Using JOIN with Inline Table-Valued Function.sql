SELECT s.StudentID, s.Name AS StudentName, t.Name AS TeacherName, s.Grade
FROM dbo.GetStudentsBySubject('Math') s
JOIN Teachers t ON s.Subject = t.Subject