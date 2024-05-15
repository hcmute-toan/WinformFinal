Create table Company
(
  Id INT IDENTITY(1,1) PRIMARY KEY ,
  Name Nvarchar(50) UNIQUE,
  Gmail varchar(50) UNIQUE ,
  Phone  varchar(50)  not null,
  Field  varchar(50)  not null,
  Address  varchar(50)  not null, 
  CompanySize varchar(50)  not null,
  Descibe varchar(50)  not null ,
 logo Image , 
 coverimage Image,
);
go
INSERT INTO Company (Name ,Gmail ,Phone ,Field ,Address , CompanySize,Descibe ,logo , coverimage) VALUES ('tuyenbest123','123','12312' , '12312', '123123','12331','23432' , '234324' ,'32432');
go
select *from Company;