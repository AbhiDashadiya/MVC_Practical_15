create database Practical_15

use Practical_15

create table Users 
(
	Id int primary key identity,
	UserName varchar(50) not null unique,
	Password varchar(50) not null,
)

-- feeding some data to initial login