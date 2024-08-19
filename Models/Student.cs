namespace IcesiMaxBack.Models;

public class Student{
    public int Id {get; set;}
    public required string Code {get; set;}
    public required string Name {get; set;}
    public int Semester {get; set;}
    public string? Carreer {get; set;}
}