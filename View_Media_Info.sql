CREATE VIEW Media_Info As
SELECT Review_ID as 'Review ID', Project.Project_ID as 'Project ID', Project_Name as 'Project title', 
Review_Link as 'Review link', Review_Date as 'Review date'
FROM  Project, Media_Reviews
where Project.Project_ID = Media_Reviews.Project_ID