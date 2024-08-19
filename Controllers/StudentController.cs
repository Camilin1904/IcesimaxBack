using Microsoft.AspNetCore.Mvc;
using IcesiMaxBack.Models;
using IcesiMaxBack.Services;

namespace IcesiMaxBack.Controllers;


[ApiController]
[Route("[controller]")]
public class StudentController : ControllerBase{

    public StudentController(){

    }

    [HttpGet]
    public ActionResult<List<Student>> GetAll() => StudentService.GetAll();

    [HttpGet("{id}")]
    public ActionResult<Student> Get(int id) {

        var Student = StudentService.Get(id);

        if (Student == null)
            return NotFound();
        
        return Student;

        
    }

    [HttpPut("{id}")]
    public ActionResult<Student> Update(int id, Student student) {
        Console.WriteLine(student);
        if (id != student.Id)
            return BadRequest();


        var Student = StudentService.Get(id);

        if (Student == null)
            return NotFound();
        
        StudentService.Update(student);

        return Student;
    }

    [HttpPost]
    public ActionResult<Student> Add(Student student) {
        StudentService.Add(student);
        return CreatedAtAction(nameof(Get), new{id=student.Id}, student);
    }

    

    [HttpDelete("{id}")]
    public ActionResult<List<Student>> GetAll(int id){
        var Student = StudentService.Get(id);

        if (Student == null)
            return NotFound();

        StudentService.Delete(id);

        return NoContent();
    }



    
}