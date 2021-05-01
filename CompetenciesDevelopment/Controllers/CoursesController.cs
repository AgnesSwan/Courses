
using CompetenciesDevelopment.Models;
using System.Linq;
using System.Web.Http;

namespace CompetenciesDevelopment.Controllers
{
    public class CoursesController : ApiController
    {
        KursyEntities db = new KursyEntities();

        [HttpGet]
        public IHttpActionResult getCourses()
        {
            return Ok(db.Courses.ToList());
            // I oznacza interfejs/ wynikiem może byc wszystko
        }

        [HttpGet]
        public IHttpActionResult getDetails(int id)
        {
            return Ok(db.Courses.Find(id));
        }
    }
}
