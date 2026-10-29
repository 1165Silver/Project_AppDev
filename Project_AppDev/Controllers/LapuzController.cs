using Microsoft.AspNetCore.Mvc;
using Project_AppDev.Models;

namespace Project_AppDev.Controllers
{
    public class LapuzController : Controller
    {
        // GET: /Lapuz
        public IActionResult Index()
        {
            var profile = new LapuzViewModel
            {
                FullName = "KATRICE ANNE T. LAPUZ",
                Subtitle = "BSCS 3-2 | Polytechnic University of the Philippines",
                PhotoUrl = "/Images/lapuz/profile.jpg",

                AboutMe = new List<LapuzInfoCard>
                {
                    new LapuzInfoCard
                    {
                        Title = "Name",
                        Text = "I am Katrice Anne T. Lapuz, a student at the Polytechnic University of the Philippines, " +
                               "pursuing a Bachelor of Science in Computer Science."
                    },
                    new LapuzInfoCard
                    {
                        Title = "Sexual Orientation",
                        Text = "I am part of the LGBTQ community and am Bisexual."
                    },
                    new LapuzInfoCard
                    {
                        Title = "Animal Lover",
                        Text = "I am an Animal Lover! I have 2 cats, 1 boy and 1 girl, and a dog. I love them so much. " +
                               "And currently thinking of raising a duck or a hamster soon."
                    }
                },

                Pets = new List<LapuzPet>
                {
                    new LapuzPet { Name = "Kookie", ImageUrl = "/Images/lapuz/kookie.jpg" },
                    new LapuzPet { Name = "Kali",   ImageUrl = "/Images/lapuz/kali.jpg" },
                    new LapuzPet { Name = "Ash",    ImageUrl = "/Images/lapuz/ash.jpg" }
                },

                Hobbies = new List<LapuzInfoCard>
                {
                    new LapuzInfoCard
                    {
                        Title = "Gaming",
                        Text = "I love playing video games like Roblox, Valorant, and any Steam games."
                    },
                    new LapuzInfoCard
                    {
                        Title = "Dancing",
                        Text = "I love dancing, especially TikTok dances. It makes me feel energetic."
                    },
                    new LapuzInfoCard
                    {
                        Title = "Sports",
                        Text = "I have played sports since elementary. I play chess, soccer, basketball, volleyball, " +
                               "badminton, tennis, and many more!"
                    }
                }
            };

            return View(profile);
        }
    }
}
