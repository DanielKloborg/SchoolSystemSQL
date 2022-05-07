using System.Linq;

namespace School.Models
{
    public interface ISchoolRepository
    {
        IQueryable<StudentCheck> StudentCheck { get; }
        void SaveStudent(StudentCheck s);
        void CreateStudent(StudentCheck s);
        void DeleteStudent(StudentCheck s);
    }
}
