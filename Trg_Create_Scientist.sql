--drop trigger trg_AfterCreateScientists
CREATE TRIGGER trg_AfterCreateScientists
ON Scientist AFTER INSERT
as
    INSERT INTO Users_Roles(UserName, UserPassword, UserRole)
    VALUES 
	(
	CONCAT((select Scientist_Name FROM inserted), '_' ,(select Scientist_Surname FROM inserted)), 
	'S' + (SELECT SUBSTRING(Scientist_Name, 1, 4) + SUBSTRING(Scientist_Surname, 1, 4)+ CAST(Scientist_ID AS VARCHAR) AS GeneratedPassword FROM inserted),
	'Scientist'
	)