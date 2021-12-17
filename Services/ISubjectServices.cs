using webtest2.Models;

namespace webtest2.Services
{
    public interface ISubjectServices
    {
        public IEnumerable<Subject> GetAllSubjects();
        public void DeleteASubject(int id);
    }
}
