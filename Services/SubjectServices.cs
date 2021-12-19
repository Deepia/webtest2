using Dapper;
using webtest2.Context;
using webtest2.Models;

namespace webtest2.Services
{
    public class SubjectServices : ISubjectServices
    {
        private readonly DapperContext _context;
        public SubjectServices(DapperContext context)
        {
            _context = context;
        }
        public void DeleteASubject(int id)
        {
            var query = "DELETE FROM Subjects WHERE SubjectId = @Id";
            using (var connection = _context.CreateConnection())
            {
                connection.Execute(query, new { id });
            }
        }

        public  IEnumerable<Subject> GetAllSubjects()
        {
            var query = "SELECT * FROM Subjects";
            using (var connection = _context.CreateConnection())
            {
                var companies = connection.Query<Subject>(query);
                return companies.ToList();
            }
        }
    }
}
