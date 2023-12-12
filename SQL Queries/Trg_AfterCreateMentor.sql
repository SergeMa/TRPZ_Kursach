CREATE TRIGGER trg_AfterCreateMentors
ON Mentor AFTER INSERT
as
    INSERT INTO Users_Roles(UserName, UserPassword, UserRole)
    VALUES 
	(
	CONCAT((select Mentor_Name FROM inserted), '_' ,(select Mentor_Surname FROM inserted)), 
	'M' + (SELECT SUBSTRING(Mentor_Name, 1, 4) + SUBSTRING(Mentor_Surname, 1, 4)+ CAST(Mentor_ID AS VARCHAR) AS GeneratedPassword FROM inserted),
	'Mentor'
	)