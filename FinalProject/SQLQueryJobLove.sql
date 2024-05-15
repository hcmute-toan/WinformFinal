Create table JobLove
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 UserId INT FOREIGN KEY REFERENCES Candidates(Id),
 JobId INT FOREIGN KEY REFERENCES Jobs(Id),
 CompanyId INT FOREIGN KEY REFERENCES Employers(Id)
);
go

select *from Joblove;