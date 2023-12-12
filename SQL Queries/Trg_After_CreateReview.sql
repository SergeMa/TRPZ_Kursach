CREATE TRIGGER trg_UpdateToChangeLog
ON Media_Reviews
AFTER Update
AS
BEGIN
    SET NOCOUNT ON;
    INSERT INTO Change_Log (Change_Log_ID, Project_ID, Project_Status, Change_Date, Change_Description)
    SELECT
		(SELECT COALESCE(MAX(Change_Log_Id), 0) + 1 FROM Change_Log),
        i.Project_ID,
        (SELECT Stage_Id from Project where Project.Project_ID = i.Project_ID),
        GETDATE(),
        'Media review updated'
    FROM
         inserted i;
END;