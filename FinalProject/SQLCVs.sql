Create table CVs
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 UserId INT FOREIGN KEY REFERENCES Candidates(Id),
 Name varchar(50) NOT NULL,
 Gender VARCHAR (10) NOT NULL,
 Address varchar(50) NOT NULL,
 DateOfBirth  varchar(50) NOT NULL,
 WorkExperience varchar(255) NOT NULL,
 EducationAndCertifications varchar(255) NOT NULL,
 ProfessionalSkills varchar(255) NOT NULL,
 GoalsAtWork varchar(255) NOT NULL
);
go
INSERT INTO CVs (UserId, Name, Gender,Address,DateOfBirth,WorkExperience,EducationAndCertifications,ProfessionalSkills,GoalsAtWork) VALUES (1, 'VanCongToan','Male','TpHCM','09/10/2024','Fresher','Graduated from UTE','AI programming','Become a boss');
INSERT INTO CVs (UserId, Name, Gender,Address,DateOfBirth,WorkExperience,EducationAndCertifications,ProfessionalSkills,GoalsAtWork) VALUES (2, 'TranVanTuyen','Male','TpHCM','30/10/2024','Fresher','Graduated from UTE','WEB programming','Become a boss');
INSERT INTO CVs (UserId, Name, Gender,Address,DateOfBirth,WorkExperience,EducationAndCertifications,ProfessionalSkills,GoalsAtWork) VALUES (3, 'PhanDinhTrung','FeMale','TpHCM','14/02/2024','Fresher','Graduated from UTE','Software programming','Become a boss');
go
select *from CVs;