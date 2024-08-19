using IcesiMaxBack.Models;

namespace IcesiMaxBack.Services;

public static class StudentService
{
    static List<Student> Students { get; }
    static int nextId = 3;
    static StudentService()
    {
        Students = new List<Student>
        {
            new Student { Id = 1, Code = "A00381090", Name = "Camilo Carmona Valencia", Semester = 7, Carreer = "Computer systems engeneering" },
            new Student { Id = 2, Code = "A00380637", Name = "Andrés Camilo Romero Ruiz", Semester = 7, Carreer = "Computer systems engeneering" }
        };
    }

    public static List<Student> GetAll() => Students;

    public static Student? Get(int id) => Students.FirstOrDefault(p => p.Id == id);

    public static void Add(Student Student)
    {
        Student.Id = nextId++;
        Students.Add(Student);
    }

    public static void Delete(int id)
    {
        var Student = Get(id);
        if(Student is null)
            return;

        Students.Remove(Student);
    }

    public static void Update(Student Student)
    {
        var index = Students.FindIndex(p => p.Id == Student.Id);
        if(index == -1)
            return;

        Students[index] = Student;
    }
}