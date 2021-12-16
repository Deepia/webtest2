using Microsoft.AspNetCore.Mvc;
using webtest2.Context;
using webtest2.Models;

namespace webtest2.Controllers
{
    public class SubjectController : Controller
    {
        MVCContext db;
        public SubjectController(MVCContext _db)
        {
            db=_db;
        }
        public IActionResult Index()
        {
            IEnumerable<Subject> subjects = db.Subjects.Select(x => x).ToList();
            return View(subjects);
        }
    }
}
