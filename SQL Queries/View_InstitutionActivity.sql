create view Institution_Activity as
SELECT
    p.Project_ID as 'Project ID',
    p.Project_Name as 'Project Title',
    p.Project_Description as 'Project description',
    ps.Sphere_Name as 'Project sphere',
    ds.Stage_Name as 'Development stage',
    Concat(s.Scientist_Name, ' ', s.Scientist_Surname) as 'Scientist',
    Concat(m.Mentor_Name, ' ', m.Mentor_Surname) as 'Mentor',
    i.Institution_Name as 'Institution',
    cl.Change_Date as 'Change date',
    cl.Change_Description as 'Change description',
    ir.Inspection_Date as 'Inspection date',
    ir.Inspection_Comments as 'Inspection comment'
FROM
    Project p
JOIN
    Change_Log cl ON p.Project_ID = cl.Project_ID
JOIN
    Development_Stage ds ON p.Stage_Id = ds.Stage_ID
JOIN
    Scientist s ON s.Scientist_ID = p.Scientist_ID
JOIN
    Mentor m ON m.Mentor_ID = p.Mentor_ID
JOIN
    Institution i ON i.Institution_ID = p.Institution_ID
JOIN
    Project_Sphere ps ON p.Sphere_Id = ps.Sphere_ID
LEFT JOIN
    Inspection_Result ir ON cl.Change_Log_ID = ir.Change_Log_Id