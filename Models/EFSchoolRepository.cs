using System.Linq;

namespace School.Models
{
    public class EFSchoolRepository : ISchoolRepository
    {
        private SchoolDbContext context;
        public EFSchoolRepository(SchoolDbContext ctx) {
            context = ctx;
        }
        public IQueryable<StudentCheck> StudentCheck => context.StudentCheck;
        public void CreateStudent(StudentCheck s) {
            context.Add(s);
            context.SaveChanges();
        }
        public void DeleteStudent(StudentCheck s) {
            context.Remove(s);
            context.SaveChanges();
        }
        public void SaveStudent(StudentCheck s) {
            context.SaveChanges();
        }
    }
}
