Create table Candidates
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Name Nvarchar(50) UNIQUE,
 Gmail varchar(50) UNIQUE,
 Password varchar(50) not null,
 Picture image 
);
go
INSERT INTO Candidates (Name, Gmail, Password,Picture) VALUES ('Toan', 'vancongtoan09102004@gmail.com', '1234',null);
INSERT INTO Candidates (Name, Gmail, Password,Picture) VALUES ('Tuyen', 'tuyenbest1234@gmail.com', '1234',null);
INSERT INTO Candidates (Name, Gmail, Password,Picture) VALUES ('Trung', 'trungnghien@gmail.com', '1234',null);
go
select *from Candidates;