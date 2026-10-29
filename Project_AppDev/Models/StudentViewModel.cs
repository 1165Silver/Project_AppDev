namespace Project_AppDev.Models
{
    public class StudentViewModel
    {
        //the header
        public string FirstName { get; set; } = string.Empty;   // "ALLIAH"
        public string LastName { get; set; } = string.Empty;    // "M. GATMEN"
        public string Tagline { get; set; } = string.Empty;     // "Undergraduate Student | Computer Science"
        public string YearLevel { get; set; } = string.Empty;   // "3RD"
        public string Section { get; set; } = string.Empty;     // "BSCS 3-2"
        public int Age { get; set; } // 20 y/0
        public string Bio { get; set; } = string.Empty; //mahaba
        public string PhotoUrl { get; set; } = string.Empty; 

        //contact info
        public string Phone { get; set; } = string.Empty; //09762983131
        public string Email { get; set; } = string.Empty; //gatmenalliah@gmail.com
        public string Location { get; set; } = string.Empty; //Carmona, Cavite

        //what do I help section
        public string HelpText { get; set; } = string.Empty;
        public string HelpTraits { get; set; } = string.Empty;  
        public string HelpImageUrl { get; set; } = string.Empty;

        //lists 
        public List<StudentSkill> Skills { get; set; } = new();
        public List<WorkExperience> WorkExperiences { get; set; } = new();
        public List<EducationEntry> Educations { get; set; } = new();
        public List<SampleWork> SampleWorks { get; set; } = new();
    }

    public class StudentSkill
    {
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string Icon { get; set; } = string.Empty; 
    }

    public class WorkExperience
    {
        public string Role { get; set; } = string.Empty;
        public string Company { get; set; } = string.Empty;
        public string Years { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
    }

    public class EducationEntry
    { 
        public string Level { get; set; } = string.Empty;   
        public string School { get; set; } = string.Empty;
        public string Years { get; set; } = string.Empty;
        public string Honors { get; set; } = string.Empty;
    }

    public class SampleWork
    {
        public string Title { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }

}
