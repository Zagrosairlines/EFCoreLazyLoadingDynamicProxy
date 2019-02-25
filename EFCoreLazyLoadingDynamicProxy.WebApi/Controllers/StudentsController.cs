using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EFCoreLazyLoadingDynamicProxy.WebApi.Models;

namespace EFCoreLazyLoadingDynamicProxy.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        private readonly MyAppContext _db;

        public StudentsController(MyAppContext context)
        {
            _db = context;
        }

        // GET: api/Students
        //[HttpGet]
        //public async Task<ActionResult<IEnumerable<Student>>> GetStudent()
        //{
        //    return await _context.Student.ToListAsync();
        //}


        [HttpGet]
        public ActionResult<IEnumerable<Student>> GetStudent()
        {

            var students = _db.Student.Include(s => s.LeaderProfessor);
            //foreach (var teacher in teachers)
            //{
            //    foreach (var student in teacher.Students) 
            //    {

            //    }
            //}
            var studentList= students.ToList();
            return studentList;
        }
        // GET: api/Students/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Student>> GetStudent(int id)
        {
            var student = await _db.Student.FindAsync(id);

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }

        // PUT: api/Students/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudent(int id, Student student)
        {
            if (id != student.StudentId)
            {
                return BadRequest();
            }

            _db.Entry(student).State = EntityState.Modified;

            try
            {
                await _db.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Students
        [HttpPost]
        public async Task<ActionResult<Student>> PostStudent(Student student)
        {
            _db.Student.Add(student);
            await _db.SaveChangesAsync();

            return CreatedAtAction("GetStudent", new { id = student.StudentId }, student);
        }

        // DELETE: api/Students/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Student>> DeleteStudent(int id)
        {
            var student = await _db.Student.FindAsync(id);
            if (student == null)
            {
                return NotFound();
            }

            _db.Student.Remove(student);
            await _db.SaveChangesAsync();

            return student;
        }

        private bool StudentExists(int id)
        {
            return _db.Student.Any(e => e.StudentId == id);
        }
    }
}
