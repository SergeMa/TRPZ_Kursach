CREATE TRIGGER trg_AfterCreateInstitutions
ON Institution AFTER INSERT
as
    INSERT INTO Users_Roles(UserName, UserPassword, UserRole)
    VALUES 
	(
	(select Institution_Name FROM inserted), 
	'I' + (SELECT SUBSTRING(Institution_Name, 1, 4) + SUBSTRING(Institution_City, 1, 4)+ CAST(Institution_ID AS VARCHAR) AS GeneratedPassword FROM inserted),
	'Admin'
	)