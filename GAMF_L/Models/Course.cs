using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GAMF_L.Models
{
    [Display(Name = "Tantárgy")]
    public class Course
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [Display(Name ="Azonosító")]
        [Required(ErrorMessage = "Azonosító kitöltése kötelező!")]
        public int CourseId { get; set; }

        [Display(Name ="Tárgy neve")]
        [Required(ErrorMessage = "Tárgy kitöltése kötelező!")]
        public string? Title { get; set; }

        [Display(Name = "Kredit")]
        [Required(ErrorMessage = "Kredit kitöltése kötelező!")]
        public int Credits { get; set; }

        [Display(Name = "Jelentkezések")]
        public virtual ICollection<Enrollment>? Enrollments { get; set; }
    }
}
