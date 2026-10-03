namespace Project_AppDev.Models
{
    public class StudentModel
    {
        public int id { get; set; } //get - pwede kong iget, meaning may access 
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string address { get; set; }
        public string contactNumber { get; set; }
        public DateOnly dateOfBirth {  get; set; }
    }
}
