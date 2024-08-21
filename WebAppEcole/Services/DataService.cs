using WebAppEcole.Models;


namespace WebAppEcole.Services
{
    public class DataService
    {

        private static DataService _singleton = new();

        private DataService()
        {

        }

        public static DataService Instance { get => _singleton; }

        public IEnumerable<Student> allStudents = new List<Student>();

        public Task<IEnumerable<Student>> GetAllStudents()
        {
            // this could take time (database, http, etc)
            //return Task.FromResult<IEnumerable<Student>>(allStudents);
            return Task.FromResult(allStudents);
        }

        public Task CreateStudent(Student newStudent)
        {
            // this could take time (database, http, etc)
            //Task.Run( () => allStudents.Append(newStudent));
            allStudents.Append(newStudent);
            return Task.CompletedTask;
        }














        //private static DataService _singleton = new();

        //public static DataService Instance { get => _singleton; }

        //private List<Student> allStudents = [];

        //public Task<List<Student>> GetStudents()
        //{
        //    return Task.FromResult(allStudents);
        //}

        //public Task AddStudent(Student s)
        //{
        //    allStudents.Add(s);
        //    return Task.CompletedTask;
        //}
    }
}
