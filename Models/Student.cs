using System.ComponentModel.DataAnnotations;

namespace CourseApp.Models
{
    public class Student
    {
        [Required(ErrorMessage = "İsminizi Giriniz")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Email Giriniz")]
        [EmailAddress(ErrorMessage = "Mail Formatı Uygun Değil")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Telefon Giriniz")]
        public string Phone { get; set; }
        [Required(ErrorMessage = "Katılım Tercihi Belirtiniz")]
        public bool? Confirm { get; set; }
    }
}