using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace GAMF_L.Models
{
    public enum Grade {A,B,C,D,F }
    public class Enrollment
    {
        public int EnrollmentId { get; set; }

        public int CourseId { get; set; }

        public int StudentId { get; set; }

        [Display(Name = "Eredmény")]
        public Grade? Grade { get; set; }

        [Display(Name = "Kurzusok")]
        public virtual Course? Courses { get; set; }

        [Display(Name = "Hallgatók")]
        public virtual Student? Students { get; set; }





    }
}
