
CREATE TABLE Contacts (
    ContactID INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(100),
    Email NVARCHAR(100)
);

INSERT INTO Contacts (Name, Email) VALUES
('John Doe', 'john.doe@example.com'),
('Jane Smith', 'jane.smith@example.com'),
('Alice Johnson', 'alice.johnson@example.com'),
('Bob Ray', 'bob.ray@example.com'),
('Charlie Brown', 'charlie.brown@example.com'),
('David Smith', 'david.smith@example.com'),
('Eva Green', 'eva.green@example.com'),
('Frank White', 'frank.white@example.com'),
('Gina Hall', 'gina.hall@example.com'),
('Hank Marvin', 'hank.marvin@example.com'),
('Irene Adler', 'irene.adler@example.com'),
('Jane Smith', 'jane.smith@example.com'), -- Duplicate
('Karl Marx', 'karl.marx@example.com'),
('Lena Horne', 'lena.horne@example.com'),
('Mike Tyson', 'mike.tyson@example.com'),
('Nina Simone', 'nina.simone@example.com'),
('Oscar Wilde', 'oscar.wilde@example.com'),
('Zelda Kim', 'david.smith@example.com'), ---- Duplicate
('Peter Pan', 'peter.pan@example.com'),
('Quincy Jones', 'quincy.jones@example.com'),
('Rachel Green', 'rachel.green@example.com'),
('Steve Jobs', 'steve.jobs@example.com'),
('Tim Cook', 'tim.cook@example.com'),
('Uma Thurman', 'uma.thurman@example.com'),
('Vince Neil', 'vince.neil@example.com'),
('Walter White', 'walter.white@example.com'),
('Xena Warrior', 'xena.warrior@example.com'),
('Yoko Ono', 'yoko.ono@example.com'),
('Zelda Fitzgerald', 'zelda.fitzgerald@example.com'),
('David Smith', 'david.smith@example.com'); -- Duplicate
