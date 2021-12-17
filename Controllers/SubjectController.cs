using Microsoft.AspNetCore.Mvc;
using webtest2.Context;
using webtest2.Models;
using webtest2.Services;

namespace webtest2.Controllers
{
    public class SubjectController : Controller
    {
        ISubjectServices iss;
        public SubjectController(ISubjectServices _iss)
        {
            iss = _iss;
        }
        public IActionResult Index()
        {
            return View(iss.GetAllSubjects());
        }

        public IActionResult Delete(int id=0)
        {
            
            iss.DeleteASubject(id);
            return RedirectToAction("Index");
        }
    }
}
