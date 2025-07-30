using DependencyInjection.Services;

namespace DependencyInjection.Managers
{
    public class Teacher :ITeacher
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }


        public string GetInfo()
        {
            return $"Öğretmen: {FirstName} {LastName}";
        }
    }
    
    
}
