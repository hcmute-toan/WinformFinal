Create table Employers
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Name Nvarchar(50) UNIQUE,
 Gmail varchar(50) UNIQUE,
 Password varchar(50) NOT NULL,
 Picture image
);
go
INSERT INTO Employers (Name, Gmail, Password,Picture) VALUES ('Toan', 'vancongtoan09102004@gmail.com', '1234',null);
INSERT INTO Employers (Name, Gmail, Password,Picture) VALUES ('Tuyen', 'tuyenbest1234@gmail.com', '1234',null);
go
select *from Employers;