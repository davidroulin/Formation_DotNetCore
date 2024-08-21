using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

using WebAppEcole.Models;
using WebAppEcole.Services;

namespace WebAppEcole.Pages
{

    public class StudentsModel : PageModel
    {

        private readonly DataService _dataService = DataService.Instance;

        public IEnumerable<Student> theStudents = new List<Student>();

        private void Refresh()
        {
            theStudents = _dataService.GetAllStudents().Result;
        }

        public void OnGet()
        {
            System.Diagnostics.Debug.WriteLine("recu GET request");

            Refresh();

        }

        // approche 1
        //public void OnPost()
        //{
        //    System.Diagnostics.Debug.WriteLine("recu POST request");
        //    System.Diagnostics.Debug.WriteLine(Request);
        //    string firstName = Request.Form["FirstName"];
        //    string lastName = Request.Form["LastName"];
        //    Student newStudent = new Student
        //    {
        //        FirstName = firstName,
        //        LastName = lastName
        //    };

        //    System.Diagnostics.Debug.WriteLine(newStudent);

        //    allStudents.Add(newStudent);

        //}

        // approche 2
        //public void OnPost(string firstName, string lastName, DateTime birthDate)
        //{
        //    Student newStudent = new Student
        //    {
        //        FirstName = firstName,
        //        LastName = lastName,
        //        BirthDate = birthDate
        //    };

        //    System.Diagnostics.Debug.WriteLine(newStudent);

        //    allStudents.Add(newStudent);
        //}


        // approche 3
        public void OnPost(Student newStudent)
        {
            System.Diagnostics.Debug.WriteLine("recu POST request");
            
            System.Diagnostics.Debug.WriteLine(newStudent);

            //theStudents.Add(newStudent);

            _dataService.CreateStudent(newStudent).Wait();

            // ne pas oublier le refresh aussi ici, pas que dans GET
            Refresh();

        }
    }
}
