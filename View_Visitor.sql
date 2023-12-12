CREATE VIEW Visitor_Info As
SELECT Project_ID as 'Project ID', Project_Name as 'Project title', Project_Description as 'Project Description',
Sphere_Name as 'Sphere', Stage_Name as 'Development stage', 
concat(Scientist_Name, ' ', Scientist_Surname) as 'Scientist',
concat(Mentor_Name, ' ', Mentor_Surname) as 'Mentor', Institution_Name as 'Institution'
FROM  Project, Scientist, Mentor, Project_Sphere, Institution, Development_Stage
where Project.Scientist_Id = Scientist.Scientist_ID and Project.Mentor_Id = Mentor.Mentor_ID and Project.Sphere_Id = Project_Sphere.Sphere_Id
and Project.Institution_ID = Institution.Institution_ID and Project.Stage_Id = Development_Stage.Stage_Id