using webtest2.Context;
using webtest2.Models;

namespace webtest2.Services
{
    public class SubjectServices : ISubjectServices
    {
        MVCContext db;
        public SubjectServices(MVCContext _db)
        {
            db = _db;
        }
        public void DeleteASubject(int id)
        {
            Subject obj = db.Subjects.FirstOrDefault(x => x.SubjectId == id);
            if (obj != null)
            {
                db.Remove(obj);
                db.SaveChanges();
            }
        }

        public IEnumerable<Subject> GetAllSubjects()
        {
            return db.Subjects.Select(x => x).ToList();
        }
    }
}
