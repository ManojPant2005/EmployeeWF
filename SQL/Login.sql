Create table Users
(
  Id int primary key identity(1,1),
  Username varchar(max) null,
  Password varchar(max) null,
  Date_Register date null
)
