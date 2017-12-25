
create table Institute(
InstituteID int primary key identity(100,1),
InstituteName varchar(30) not null,
City varchar(20) not null,
);

create table Course(
CourseID int primary key identity(1,1),
CourseName varchar(20) not null,
);

create table Student(
StudentID int primary key identity(1,1),
StudentName varchar(30),
DOB Date not null,
);

create table LoginDetails(
StudentID int foreign key references Student(StudentID),
StPassword varchar(10)
);

create table Admission(
AdmissionID int primary key identity(1,1),
AdmissionDate date not null,
StudentID int foreign key references Student(StudentID),
CourseID int foreign key references Course(CourseID),
InstituteID int foreign key references Institute(InstituteID)
);

create procedure Register
(
	@StudentName varchar(20),
	@DOB date,
	@AdmissionDate date,
	@CourseName varchar(30),
	@InstituteName varchar(20)
)
as
declare @sid int;
declare @cid int;
declare @iid int;
declare @aid int;
insert into Student values(@StudentName, @DOB);
select @cid = CourseID from Course where CourseName = @CourseName;
select @iid = InstituteID from Institute where InstituteName = @InstituteName;
select @sid = IDENT_CURRENT('Student');
insert into Admission values (@AdmissionDate, @sid, @cid, @iid);

go

CREATE PROCEDURE [dbo].[GetInstitutes] 
AS
	select InstituteID,InstituteName from Institute;
	RETURN
GO

CREATE PROCEDURE [dbo].[GetCourses] 
AS
	select CourseID,CourseName from Course;
	RETURN
GO

create procedure LoginProc
(
	@StudentID int,
	@Password varchar(10)
)
as
select StudentID, StPassword from LoginDetails
where StudentID=@StudentID;


