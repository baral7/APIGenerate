using ApplicationService.contract;
using DomainLayer.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


namespace SecondTryOnion.Controllers
{
    [Route("api/[controller]")]
   [ApiController]
    
    public class StudentController : ControllerBase
    {
        private readonly IStudent student1;
        public StudentController(IStudent student)
        {
            this.student1 = student;

        }
        //getting all record
        [HttpGet]
        [Route("getall")]
        public IActionResult Getall()
        {
            var response = student1.GetAll();
            return Ok(response);
        }
        //getting single record
        [HttpGet("getsingle")]
        public IActionResult GetSingle(int id)
        {
            var response = student1.GetSingle(id);
            return Ok(response);
        }
        //add record
        [HttpPost]
        public IActionResult Addrecord(Student student)
        {
            var response = student1.AddRecord(student);
            return Ok(response);
        }
        //delete record
         [HttpDelete("deleterecord")]
        public IActionResult RemoveRecord(int id)
        {
            return Ok(student1.DeleteRecord(id));
           // var response = student1.DeleteRecord(id);
        }
        [HttpPut("update")]
        public IActionResult UpdateName(Student students)
        {
            return Ok(student1.UpdateRecord(students));
        }

    }
}
