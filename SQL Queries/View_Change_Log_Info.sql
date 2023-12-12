CREATE VIEW Change_Log_Info As
SELECT 
	Change_Log.Change_Log_Id as 'Change log',
	Project.Project_ID as 'Project ID', Project_Name as 'Project title', 
	Change_Log.Project_Status as 'Project status',
	Change_Date as 'Change date', Change_Description as 'Change description',
	COALESCE(Inspection_Comments, 'No comments yet') AS 'Inspection comments' 
FROM  Project
JOIN Change_Log ON Project.Project_ID = Change_Log.Project_ID
JOIN Development_Stage ON Project.Stage_Id = Development_Stage.Stage_Id
LEFT JOIN Inspection_Result ON Inspection_Result.Change_Log_Id = Change_Log.Change_Log_Id;