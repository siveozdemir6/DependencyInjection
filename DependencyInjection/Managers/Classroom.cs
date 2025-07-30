using DependencyInjection.Services;

namespace DependencyInjection.Managers
{
    public class Classroom : IClassroom
    {
        private readonly ITeacher _teacher;
        public Classroom(ITeacher teacher)
        {
            _teacher = teacher;
        }
        public string GetTeacherInfo()
        {
            return _teacher.GetInfo();
        }
    }
    
    
}
