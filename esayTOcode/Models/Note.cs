using System.ComponentModel.DataAnnotations;

namespace esayTOcode.Models
{
    public class Note
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="الوصف مطلوب")]
        public  string? Notetext { get; set; }
        [Required(ErrorMessage = "العنوان مطلوب")]
        public  string? Title { get; set; }
        public DateTime NoteDate { get; set; }=DateTime.Now;
    }
}
