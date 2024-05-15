Create table Company
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 Name Nvarchar(50) UNIQUE,
 Gmail varchar(50) UNIQUE,
 Phone varchar(50) UNIQUE,
 Field varchar(50) UNIQUE,
 address varchar(50) UNIQUE,
 CompanySize varchar(50) UNIQUE,
 Descibe varchar(50) UNIQUE,

 Picture logo,
 Picture coverimage,
);
go
go
select *from Company;