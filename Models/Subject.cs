using System.ComponentModel.DataAnnotations;

namespace webtest2.Models
{
    public class Subject
    {
        [Key]
        public int SubjectId { get; set; }
        public string? SubjectName { get; set; }
        public string SubjectTerm { get; set; }
        public string SubjectCredets { get; set; }
        public List<Teacher> SubjectTeachers { get; set; }= new List<Teacher>();
    }
}
