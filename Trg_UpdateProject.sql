CREATE TRIGGER tr_ProjectUpdate
ON Project
AFTER UPDATE
AS
BEGIN
    SET NOCOUNT ON;
    IF UPDATE(Project_Name) OR UPDATE(Project_Description) OR UPDATE(Sphere_Id) OR UPDATE(Stage_Id)
    BEGIN
        INSERT INTO Change_Log (Change_Log_ID, Project_ID, Project_Status, Change_Date, Change_Description)
        SELECT
			(select max(Change_Log_Id)+1 from Change_Log),
            i.Project_ID,
            i.Stage_Id,
            GETDATE(),
            'Changes in Project: ' +
            CASE 
                WHEN i.Project_Name <> d.Project_Name THEN 'Project_Name from ' + COALESCE(d.Project_Name, 'NULL') + ' -> ' + COALESCE(i.Project_Name, 'NULL') + '; '
                ELSE ''
            END +
            CASE 
                WHEN i.Project_Description <> d.Project_Description THEN 'Project_Description from ' + COALESCE(d.Project_Description, 'NULL') + ' -> ' + COALESCE(i.Project_Description, 'NULL') + '; '
                ELSE ''
            END +
            CASE 
                WHEN i.Sphere_Id <> d.Sphere_Id THEN 'Sphere: '+ (select Sphere_Name from Project_Sphere where Sphere_Id = d.Sphere_Id) + ' -> ' + (select Sphere_Name from Project_Sphere where Sphere_Id = i.Sphere_Id) + '; '
                ELSE ''
            END +
            CASE 
                WHEN i.Stage_Id <> d.Stage_Id THEN 'Stage: ' + (select Stage_Name from Development_Stage where Stage_Id = d.Stage_Id) + ' -> ' + (select Stage_Name from Development_Stage where Stage_Id = i.Stage_Id) + '; '
                ELSE ''
            END +
			CASE 
                WHEN i.Mentor_Id <> d.Mentor_Id THEN 'Mentor changed to ' + (select CONCAT(Mentor_Name, ' ', Mentor_Surname) from Mentor where Mentor_ID = i.Mentor_ID)
                ELSE ''
            END
        FROM
            inserted i
            INNER JOIN deleted d ON i.Project_ID = d.Project_ID
        WHERE
            i.Project_Name <> d.Project_Name OR
            i.Project_Description <> d.Project_Description OR
            i.Sphere_Id <> d.Sphere_Id OR
            i.Stage_Id <> d.Stage_Id;
    END
END;