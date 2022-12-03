using GAMF_L.Data;
using GAMF_L.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace GAMF_L.Controllers
{
    public class ReportController : Controller
    {
        private readonly GAMFDbContext _context;

        public ReportController(GAMFDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public IActionResult EnrollmentDateReport()
        {
            var result = _context.Students.GroupBy(s => s.EnrollmentDate)
            .Select(s => new EnrollmentDateVM
            {
                EnrollmentDate = s.Key,
                StudentCount = s.Count()
            });

            return View(result.ToList());
        }

        public IActionResult StudentFullCredit()
        {

            var result = (from enrollment in _context.Enrollments
                          join student in _context.Students
                              on enrollment.StudentId equals student.Id
                          join course in _context.Courses
                              on enrollment.CourseId equals course.CourseId
                          select new StudentFullCreditVM
                          {
                              StudentFirstName = student.FirstMidName,
                              StudentLastName = student.LastName,
                              CreditCount = course.Credits,
                              CourseName = course.Title
                          })
                 .ToList();

            return View(result.ToList());
        }


    }
}
