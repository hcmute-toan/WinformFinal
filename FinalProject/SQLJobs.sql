Create table Jobs
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 CompanyId INT FOREIGN KEY REFERENCES Employers(Id),
 NameJob varchar(50) NOT NULL,
 PositionNeeded varchar(50) NOT NULL,
 CompanyName varchar(50),
 Salary varchar(50) NOT NULL,
 Address varchar(50) NOT NULL,
 PostingTime varchar(50) NOT NULL,
 NumberOfRecruit varchar(50) NOT NULL,
 DescribeJob varchar(1000) NOT NULL,
 Contact varchar(50) NOT NULL
);
go
INSERT INTO Jobs (CompanyId, NameJob, PositionNeeded,CompanyName,Salary,Address,PostingTime,NumberOfRecruit,DescribeJob,Contact)
VALUES (1,'Software engineer', 'Junior','FPT','12000000','TP Ho Chi Minh','03/04/2024','25','Software design for partners','vancongtoan09102004@gmail.com');
go
select *from Jobs;