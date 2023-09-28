﻿using DemoWebApp.Models;
using DemoWebApp.ViewModel;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DemoWebApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        BookDbContext db = new BookDbContext();
        [HttpGet]
        public IEnumerable<Book> GetBooks()
        {
            return db.Books;
        }
        [HttpPost]
        public IActionResult AddBooks(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return Ok("Record is being added successfully");

        }

        [HttpDelete]
        public IActionResult DeleteBooks(int id)
        {
            var bk = db.Books.Where(x => x.Id == id).FirstOrDefault();
            db.Books.Remove(bk);
            db.SaveChanges();
            return Ok("Record has been deleted successfully");
        }
        [HttpPut]
        public IActionResult PutBook(Book book)
        {
            db.Books.Update(book);
            db.SaveChanges();
            return Ok("Record has being updated successfully");
        }

        [HttpGet]
        [Route("/get-student-data")]
        public IEnumerable<StudentData> GetStudentData()
        {
            //var data = db.TblStudents.
            //    Join(db.TblCourses, 
            //    s => s.CourseId, c => c.Id, (s, c) => new { s,c}).
            //    Join(db.TblCourseBookMappings,
            //    course=> course.c.Id,cb=>cb.CourseId,(course,cb)=>new {course,cb}).
            //    Join(db.TblBooks,coursebook=> coursebook.cb.BookId, 
            //    b => b.Id, (coursebook, b) => 
            //    new { Id= coursebook.course.s.Id,Name= coursebook.course.s.StudentName,
            //    CourseName= coursebook.course.c.CourseName

            //    }).ToList();


            var data = db.Students.
               Join(db.Courses,
               s => s.Id, c => c.Id, (s, c) =>
               new { Id = s.Id, Name = s.StudentName, CourseName = c.CourseName, CourseId = c.Id });

            var books = data.Join(db.CourseBookMappings, d => d.CourseId, cb => cb.CourseId
            , (d, cb) => new { d, cb }).Join(db.Books, cbm => cbm.cb.BookId, b => b.Id,

            (cbm, b) => new { BookId = b.Id, BookName = b.Bookname, StudentId = cbm.d.Id });

            List<StudentData> studentdatalist = new List<StudentData>();

            foreach (var item in data)
            {
                StudentData student = new StudentData();
                student.Id = item.Id;
                student.CourseName = item.CourseName;
                student.Name = item.Name;
                List<StudentBooks> studentbooks = new List<StudentBooks>();
                var bookdata = books.Where(x => x.StudentId == item.Id);
                foreach (var book in bookdata)
                {
                    StudentBooks s = new StudentBooks();
                    s.Id = book.BookId;
                    s.BookName = book.BookName;
                    studentbooks.Add(s);

                }
                student.studentBooks = studentbooks;
                studentdatalist.Add(student);
            }

            return studentdatalist;
        }
        [HttpGet]
        [Route("/test")]
        public IList<Book> LinqPractice()
        {
            //Take function in Linq
            var data = db.Books.Take(1).ToList();
            
            //Skip function in Linq
            var temp = db.Books.Skip(1).ToList();
            IQueryable query = db.Books.Skip(1);

            //OrderBy Function in Linq
            var orderbyvaluedesc =  db.Books.OrderByDescending(x => x.Id);
            var orderbyvalueasc = db.Books.OrderBy(x => x.Id);

            //Single function in Linq
            List<int> numbers = new List<int> { 1 };
            List<int> emptynumbers = new List<int>();
            var single = numbers.Single();
            var singleordefault = emptynumbers.SingleOrDefault();


            return data;
        }
    }
}