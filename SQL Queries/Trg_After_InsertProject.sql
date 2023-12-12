--drop trigger trg_after_insert_project

CREATE TRIGGER trg_after_insert_project
ON Project AFTER INSERT
as
    -- Insert a new record into the Change_Log table
    INSERT INTO Change_Log (Change_Log_ID, Project_ID, Project_Status, Change_Date, Change_Description)
    VALUES ((SELECT COALESCE(MAX(Change_Log_Id), 0) + 1 FROM Change_Log), (select Project_ID FROM inserted), 1, GETDATE(), 'Project Created');