Create table JobApplication
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 IdCv int,
 UserId INT FOREIGN KEY REFERENCES Candidates(Id),
 JobId INT FOREIGN KEY REFERENCES Jobs(Id),
 CompanyId INT FOREIGN KEY REFERENCES Employers(Id),
 Status INT ,
);
go

select *from JobApplication;