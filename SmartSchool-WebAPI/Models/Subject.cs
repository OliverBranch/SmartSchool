namespace SmartSchool_WebAPI.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }
        public Subject()
        {
            
        }
        public Subject(int id, string name, int teacherId)
        {
            this.Id = id;
            this.Name = name;
            this.TeacherId = teacherId;

        }


    }
}