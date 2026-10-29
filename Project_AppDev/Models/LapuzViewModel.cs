namespace Project_AppDev.Models
{
    // Everything shown on Katrice's profile page
    public class LapuzViewModel
    {
        public string FullName { get; set; } = string.Empty;   // "KATRICE ANNE T. LAPUZ"
        public string Subtitle { get; set; } = string.Empty;   // "BSCS 3-2 | Polytechnic University of the Philippines"
        public string PhotoUrl { get; set; } = string.Empty;

        public List<LapuzInfoCard> AboutMe { get; set; } = new();
        public List<LapuzPet> Pets { get; set; } = new();
        public List<LapuzInfoCard> Hobbies { get; set; } = new();
    }

    // One box with a title and a short text (used in About Me and Hobbies)
    public class LapuzInfoCard
    {
        public string Title { get; set; } = string.Empty;
        public string Text { get; set; } = string.Empty;
    }

    public class LapuzPet
    {
        public string Name { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}
