using Microsoft.AspNetCore.Mvc;
using Project_AppDev.Models;
using System.Diagnostics;

namespace Project_AppDev.Controllers
{
        public class StudentController : Controller
        {
            public IActionResult Index()
            {
                var student = new StudentViewModel
                {
                    //header
                    FirstName = "ALLIAH",
                    LastName = "M. GATMEN",
                    Tagline = "Undergraduate Student | Computer Science",
                    YearLevel = "3RD",
                    Section = "BSCS 3-2",
                    Age = 20,
                    Bio = "A third-year Computer Science student with hands-on experience as a " +
                      "Virtual and Personal Assistant since 2024, and a graphic designer and " +
                      "commission artist since 2020. I combine organized administrative support " +
                      "with creative design skills to help clients work efficiently and present " +
                      "their brand with confidence.",
                    PhotoUrl = "/images/profile.png", 

                    //Contact info
                    Phone = "0976-298-3131",
                    Email = "gatmenalliah@gmail.com",
                    Location = "Carmona, Cavite",

                    //what do i help section
                    HelpText = "I help clients save time and stand out, with support and standout design.",
                    HelpTraits = "Organized, Creative, Dependable.",
                    HelpImageUrl = "/images/help.jpg",

                    Skills = new List<StudentSkill>
                    {
                        new StudentSkill { Name = "Digital illustration", Description = "Create custom graphics and illustrations for clients.", Icon = "/images/pen.png" },
                        new StudentSkill { Name = "Admin Support", Description = "Manage emails, schedules, and records efficiently.", Icon = "/images/admin.png" },
                        new StudentSkill { Name = "Client-focused", Description = "Communicate clearly and meet every deadline.", Icon = "/images/handshake.png" }
                    },

                    WorkExperiences = new List<WorkExperience>
                    {
                        new WorkExperience
                        {
                            Role = "Personal Assistant",
                            Company = "Glassnpde",
                            Years = "2025-2026",
                            Description = "Manage emails and calendars, schedule meeting and travel, update records " + 
                            "and spreadsheets, maintain social media, and support daily business operations remotely."
                        },

                        new WorkExperience
                        {
                            Role = "Virtual Assistant",
                            Company = "Bastion Investment LLC",
                            Years = "2024-Present",
                            Description = "Encode information to the database, check vacant properties, substitute " +
                            "trustees, and foreclosure and enter qualified leads to Podio."
                        },

                        new WorkExperience
                        {
                            Role = "Graphic Designer/Artist",
                            Company = "Self-Employed",
                            Years = "2020-Present",
                            Description = "Create custom artwork and designs based on client requests, develop logos, " +
                            "illustrations, and digital graphics, and deliver final files in the required formats."
                        },
                    },

                    Educations = new List<EducationEntry>
                    {
                        new EducationEntry
                        {
                        Level = "Senior High School Graduate",
                        School = "Angelo L. Loyola Senior High School",
                        Years = "2022–2024",
                        Honors = "With High Honors"
                        }
                    },

                    SampleWorks = new List<SampleWork>
                    {
                    new SampleWork { Title = "Haikyuu", ImageUrl = "/images/work1.jpg" },
                    new SampleWork { Title = "Cat",          ImageUrl = "/images/work2.jpg" },
                    new SampleWork { Title = "Study",             ImageUrl = "/images/work3.png" },
                    new SampleWork { Title = "A Dream",             ImageUrl = "/images/work4.png" },
                    }
                };

                return View(student); 
            }
        }
}
