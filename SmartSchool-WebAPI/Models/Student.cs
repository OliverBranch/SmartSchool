namespace SmartSchool_WebAPI.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

        public Student()
        {
            
        }
        
        public Student(int id, string name, string lastName, string phoneNumber)
        {
            this.Id = id;
            this.Name = name;
            this.LastName = lastName;
            this.PhoneNumber = phoneNumber;

        }
    }
}