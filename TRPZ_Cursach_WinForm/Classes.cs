using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Data.Linq.Mapping;

[Table(Name = "Users_Roles")]
public class Users_Roles
{
    [Column(Name = "UserName", IsPrimaryKey = true)]
    public string? UserName { get; set; }
    [Column(Name = "UserPassword")]
    public string? UserPassword { get; set; }
    [Column(Name = "UserRole")]
    public string? UserRole { get; set; }
}

[Table(Name = "Scientist")]
public class Scientist
{
    [Column(Name = "Scientist_ID", IsPrimaryKey = true)]
    public int Scientist_ID { get; set; }
    [Column(Name = "Scientist_Name")]
    public string? Scientist_Name { get; set; }
    [Column(Name = "Scientist_Surname")]
    public string? Scientist_Surname { get; set; }
    [Column(Name = "Institution_Id")]
    public int? Institution_ID { get; set; }
}

[Table(Name = "Mentor")]
public class Mentor
{
    [Column(Name = "Mentor_ID", IsPrimaryKey = true)]
    public int Mentor_ID { get; set; }
    [Column(Name = "Mentor_Name")]
    public string? Mentor_Name { get; set; }
    [Column(Name = "Mentor_Surname")]
    public string? Mentor_Surname { get; set; }
    [Column(Name = "Institution_Id")]
    public int? Institution_ID { get; set; }
}

[Table(Name = "Development_Stage")]
public class Development_Stage
{
    [Column(Name = "Stage_ID", IsPrimaryKey = true)]
    public int Stage_ID { get; set; }
    [Column(Name = "Stage_Name")]
    public string? Stage_Name { get; set; }
}

[Table(Name = "Project_Sphere")]
public class Project_Sphere
{
    [Column(Name = "Sphere_ID", IsPrimaryKey = true)]
    public int Sphere_ID { get; set; }
    [Column(Name = "Sphere_Name")]
    public string? Sphere_Name { get; set; }
}

[Table(Name = "Institution")]
public class Institution
{
    [Column(Name = "Institution_ID", IsPrimaryKey = true)]
    public int Institution_ID { get; set; }
    [Column(Name = "Institution_Name")]
    public string? Institution_Name { get; set; }
    [Column(Name = "Institution_Country")]
    public string? Institution_Country { get; set; }
    [Column(Name = "Institution_City")]
    public int? Institution_City { get; set; }
}

[Table(Name = "Project")]
public class Project
{
    [Column(Name = "Project_ID", IsPrimaryKey = true)]
    public int Project_ID { get; set; }
    [Column(Name = "Project_Name")]
    public string Project_Name { get; set; }
    [Column(Name = "Project_Description")]
    public string Project_Description { get; set; }
    [Column(Name = "Sphere_Id")]
    public int Sphere_Id { get; set; }
    [Column(Name = "Stage_Id")]
    public int Stage_Id { get; set; }
    [Column(Name = "Scientist_Id")]
    public int Scientist_Id { get; set; }
    [Column(Name = "Mentor_Id")]
    public int Mentor_Id { get; set; }
    [Column(Name = "Institution_Id")]
    public int Institution_Id { get; set;}
}

[Table(Name = "Media_Reviews")]
public class Media_Reviews
{
    [Column(Name = "Review_ID", IsPrimaryKey = true, IsDbGenerated = false)]
    public int Review_ID { get; set; }
    [Column(Name = "Project_ID")]
    public int Project_ID { get; set; }
    [Column(Name = "Review_Link")]
    public string Review_Link { get; set; }
    [Column(Name = "Review_Date")]
    public DateTime Review_Date { get; set; }
}

[Table(Name = "Change_Log")]
public class Change_Log
{
    [Column(Name = "Change_Log_ID", IsPrimaryKey = true, IsDbGenerated = false)]
    public int Change_Log_ID { get; set; }
    [Column(Name = "Project_ID")]
    public int Project_ID { get; set; }
    [Column(Name = "Project_Status")]
    public int Project_Status { get; set; }
    [Column(Name = "Change_Date")]
    public DateTime Change_Date { get; set; }
    [Column(Name = "Change_Description")]
    public string Change_Description { get; set; }
}

[Table(Name = "Inspection_Result")]
public class Inspection_Result
{
    [Column(Name = "Inspection_ID", IsPrimaryKey = true, IsDbGenerated = false)]
    public int Inspection_ID { get; set; }
    [Column(Name = "Change_Log_ID")]
    public int Change_Log_ID { get; set; }
    [Column(Name = "Inspection_Date")]
    public DateTime Inspection_Date { get; set; }
    [Column(Name = "Inspection_Comments")]
    public string Inspection_Comments { get; set; }
}