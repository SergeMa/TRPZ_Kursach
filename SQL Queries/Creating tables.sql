--create database Scientific_Library
--go
use Scientific_Library
go

create table Development_Stage
(
Stage_ID int primary key,
Stage_Name varchar(100) not null
)

create table Project_Sphere	
(
Sphere_ID int primary key,
Sphere_Name varchar(100) not null
)

create table Institution
(
Institution_ID int primary key,
Institution_Name varchar(100) not null,
Institution_Country varchar(100) not null,
Institution_City varchar(100) not null
)

create table Scientist
(
Scientist_ID int primary key,
Scientist_Name varchar(100) not null,
Scientist_Surname varchar(100) not null,
Institution_Id int references Institution(Institution_Id)  not null
)

create table Mentor
(
Mentor_ID int primary key,
Mentor_Name varchar(100) not null,
Mentor_Surname varchar(100) not null,
Institution_Id int references Institution(Institution_Id) not null
)

create table Project
(
Project_ID int primary key,
Project_Name varchar(250) not null,
Project_Description varchar(1000) not null,
Sphere_Id int references Project_Sphere(Sphere_Id) not null,
Stage_Id int references Development_Stage(Stage_Id) not null,
Scientist_ID int references Scientist(Scientist_Id) not null,
Mentor_ID int references Mentor(Mentor_Id) not null,
Institution_ID int references Institution(Institution_Id) not null
)

create table Change_Log
(
Change_Log_ID int primary key,
Project_ID int references Project(Project_Id) not null,
Project_Status int references Development_Stage(Stage_Id) not null,
Change_Date date,
Change_Description varchar(250) not null
)

create table Inspection_Result(
Inspection_ID int primary key,
Change_Log_Id int references Change_Log(Change_Log_Id) not null,
Inspection_Date date,
Inspection_Comments varchar(250) not null
)

create table Media_Reviews
(
Review_ID int primary key not null,
Project_ID int references Project(Project_Id) not null,
Review_Link varchar(250) not null,
Review_Date Date
)

create table Users_Roles
(
UserName Varchar(100) primary key,
UserPassword varchar(100) not null,
UserRole varchar(100) not null
)