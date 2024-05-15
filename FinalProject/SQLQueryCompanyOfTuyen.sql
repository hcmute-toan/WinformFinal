Create table Company
(
NumberJobs INT,
 IdEmployer Nvarchar(50) not null,
  Id INT IDENTITY(1,1) PRIMARY KEY ,
  Name Nvarchar(50) not null,
  Gmail varchar(50) not null ,
  Phone  varchar(50)  not null,
  Field  varchar(50)  not null,
  Address  varchar(50)  not null, 
  CompanySize varchar(50)  not null,
  Descibe varchar(50)  not null ,
 logo Image , 
 coverimage Image,
);
go
INSERT INTO Company ( NumberJobs,IdEmployer,Name ,Gmail ,Phone ,Field ,Address , CompanySize,Descibe ,logo , coverimage) VALUES (0,'1','tuyenbest123','123','12312' , '12312', '123123','12331','23432' , '234324' ,'32432');
go
select *from Company;