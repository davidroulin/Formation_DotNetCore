
using Microsoft.AspNetCore.Mvc;

namespace WebAppEcole.Models
{

    [BindProperties]
	public class Student
	{

        public Student()
        {
            FirstName = "";
            LastName = "";
        }

        //public bool EstMajeur { get { return true; } }

        public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime BirthDate{ get; set; }

        public override string ToString()
        {
            return $"{LastName} {FirstName} (born {BirthDate})";
        }


        //public Student(string nom,string prenom)
        //{
        //    FirstName = prenom;
        //    LastName = nom;
        //}
    }
}
