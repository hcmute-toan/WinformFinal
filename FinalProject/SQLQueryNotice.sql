Create table Notice1
(
 Id INT IDENTITY(1,1) PRIMARY KEY,
 IdLogin INT ,
 TypeLogin varchar(11),
 IdSender INT,
 IdReceiver INT,
 IdJob INT,
 Type varchar(11),
 TimeNotice DATETIME2,
 StatusCV INT,
 Mess VARCHAR(8000)
);
select *from Notice1;