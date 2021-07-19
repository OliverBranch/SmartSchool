namespace SmartSchool_WebAPI.Models
{
    public class SubjectStudent
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }
        public int SubjectId { get; set; }
        public Subject Subject { get; set; }
        public SubjectStudent()
        {
            
        }
        public SubjectStudent(int studentId, int subjectId)
        {
            this.StudentId = studentId;
            this.SubjectId = subjectId;

        }
    }
}