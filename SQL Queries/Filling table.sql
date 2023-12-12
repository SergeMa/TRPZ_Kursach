INSERT INTO Project_Sphere (Sphere_Id, Sphere_Name)
VALUES 
    (1, 'Software Development'),
    (2, 'Data Science'),
    (3, 'Artificial Intelligence'),
    (4, 'Mobile App Development'),
    (5, 'Web Development'),
    (6, 'E-commerce'),
    (7, 'Digital Marketing'),
    (8, 'Healthcare IT'),
    (9, 'Financial Technology'),
    (10, 'Cybersecurity'),
	(11, 'Game development'),
	(12, 'Military technology'),
	(13, 'Government technology')

INSERT INTO Development_Stage (Stage_Id, Stage_Name)
VALUES 
    (1, 'Planning'),
    (2, 'Design'),
	(3, 'Prototyping'),
    (4, 'Development'),
    (5, 'Testing'),
    (6, 'Deployment');

INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (1, 'Taras Shevchenko National University of Kyiv', 'Kyiv', 'Ukraine');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (2, 'Lviv Polytechnic National University', 'Lviv', 'Ukraine');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (3, 'National Technical University of Ukraine "Igor Sikorsky Kyiv Polytechnic Institute"', 'Kyiv', 'Ukraine');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (4, 'V. N. Karazin Kharkiv National University', 'Kharkiv', 'Ukraine');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (5, 'Ivan Franko National University of Lviv', 'Lviv', 'Ukraine');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (6, 'Chernivtsi National University', 'Chernivtsi', 'Ukraine');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (7, 'Harvard University', 'Cambridge', 'United States');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (8, 'Massachusetts Institute of Technology (MIT)', 'Cambridge', 'United States');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (9, 'Stanford University', 'Stanford', 'United States');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (10, 'University of Cambridge', 'Cambridge', 'United Kingdom');
INSERT INTO Institution (Institution_Id, Institution_Name, Institution_City, Institution_Country)
VALUES (11, 'University of Oxford', 'Oxford', 'United Kingdom');

INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (1, 'Oksana', 'Ivanenko', 4);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (2, 'Andriy', 'Petrenko', 5);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (3, 'Yulia', 'Kovalenko', 6);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (4, 'Serhiy', 'Lysenko', 7);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (5, 'Kateryna', 'Pavlenko', 8);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (6, 'Volodymyr', 'Kuchma', 9);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (7, 'Nataliya', 'Yakovenko', 10);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (8, 'Oleksandr', 'Zakharov', 11);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (9, 'Tetiana', 'Petrova', 1);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (10, 'Igor', 'Ivanko', 2);
INSERT INTO Scientist (Scientist_ID, Scientist_Name, Scientist_Surname, Institution_Id)
VALUES (11, 'Svitlana', 'Shevchenko', 3);


INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (1, 'Ivan', 'Kovalenko', 4);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (2, 'Olena', 'Petrenko', 5);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (3, 'Yuriy', 'Lysenko', 6);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (4, 'Nadiya', 'Pavlenko', 7);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (5, 'Oleh', 'Kuchma', 8);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (6, 'Ludmila', 'Yakovenko', 9);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (7, 'Viktor', 'Zakharov', 10);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (8, 'Tetiana', 'Ivanenko', 1);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (9, 'Dmytro', 'Shevchenko', 2);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (10, 'Olha', 'Ivanko', 3);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (11, 'Yaroslav', 'Petrova', 11);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (12, 'Sofia', 'Zakharova', 1);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (13, 'Roman', 'Mykhailenko', 2);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (14, 'Kateryna', 'Vasylchenko', 3);
INSERT INTO Mentor (Mentor_ID, Mentor_Name, Mentor_Surname, Institution_Id)
VALUES (15, 'Oleksiy', 'Symonenko', 4);


INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (1, 'Online Marketplace Platform', 'Develop an e-commerce platform connecting buyers and sellers worldwide.', 6, 2, 1, 2, 3);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (2, 'Health Monitoring App', 'Create a mobile app for real-time health monitoring and data analysis.', 8, 3, 2, 3, 1);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (3, 'AI-driven Financial Analysis', 'Build an AI system for analyzing financial market trends and providing investment insights.', 9, 4, 3, 1, 2);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (4, 'Cybersecurity Threat Detection', 'Develop a system for detecting and mitigating cybersecurity threats in real-time.', 10, 5, 1, 2, 3);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (5, 'Government Data Analytics', 'Implement a data analytics solution for government agencies to make informed decisions.', 13, 2, 2, 3, 1);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (6, 'Game Development - Virtual Reality', 'Create an immersive virtual reality game with cutting-edge graphics and gameplay.', 11, 4, 3, 1, 2);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (7, 'Military Technology Innovation', 'Research and develop advanced military technology for enhanced defense capabilities.', 12, 1, 1, 2, 3);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (8, 'Digital Marketing Analytics Platform', 'Build a platform for analyzing and optimizing digital marketing campaigns.', 7, 3, 2, 3, 1);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (9, 'Web-Based Financial Tools', 'Develop a suite of web-based financial tools for personal and business use.', 9, 5, 3, 1, 2);
INSERT INTO Project (Project_ID, Project_Name, Project_Description, Sphere_Id, Stage_Id, Scientist_ID, Mentor_ID, Institution_ID)
VALUES (10, 'AI in Healthcare Diagnostics', 'Utilize AI for improving medical diagnostics and patient care in the healthcare sector.', 8, 6, 1, 2, 3);