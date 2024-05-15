Create table Recruitment
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 UserId INT FOREIGN KEY REFERENCES Candidates(Id),
 Name varchar(50) NOT NULL,
 Gender VARCHAR (10) NOT NULL,
 Address varchar(50) NOT NULL,
 DateOfBirth  varchar(50) NOT NULL,
 JobApplication varchar(50) NOT NULL,
 WorkExperience varchar(255) NOT NULL,
 EducationAndCertifications varchar(255) NOT NULL,
 ProfessionalSkills varchar(255) NOT NULL,
 GoalsAtWork varchar(255) NOT NULL,
 Picture image ,
);
go
select *from Recruitment