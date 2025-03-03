using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AtlegangStudyGroup.Models;

namespace AtlegangStudyGroup.Controllers
{
    public class StudentController : Controller
    {
		// GET: Student
		public ActionResult Index()
		{
			List<Student> students = new List<Student>
			{
			  new Student
			  {
				  StudentNumber="u23554925",
				  Name="Felicity",
				  Surname="Mantadile",
				  Email="u23554925@tuks.co.za",
			  },

			new Student
			{
				StudentNumber = "u21446781",
				Name = "Jonas",
				Surname = "Smith",
				Email = "u21446781@tuks.co.za",
			},

			new Student
			{
				StudentNumber = "u25312346",
				Name = "Tebogo",
				Surname = "Martins",
				Email = "u25312346@tuks.co.za",
			},

			new Student
			{
				StudentNumber = "u19657897",
				Name = "Lee",
				Surname = "Thompson",
				Email = "u19657897@tuks.co.za",
			},
			  new Student
			  {
				  StudentNumber = "u20198765",
				  Name = "Goitseone",
				  Surname = "Moropa",
				  Email = "u20198765@tuks.co.za",
			  },
			};
            return View(students);
        }
    }
}