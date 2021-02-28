using System;
using System.ComponentModel.DataAnnotations;
using JCTools.GenericCrud.DataAnnotations;
public class Student
{
    [Key]
    [Crud(Visible = false)]
    public int Id { get; set; }
    public string LastName { get; set; }
    public string FirstMidName { get; set; }    
    [DataType(DataType.Date)]
    public DateTime EnrollmentDate { get; set; }
}