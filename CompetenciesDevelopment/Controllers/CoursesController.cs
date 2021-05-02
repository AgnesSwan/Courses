
using CompetenciesDevelopment.Models;
using System.Linq;
using System.Web.Http;
using System;

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
        public IHttpActionResult getDetails([FromUri] int id)
        {
            return Ok(db.Courses.Find(id));
        }
        [ActionName("Dodaj")]
        [HttpPost]

        public IHttpActionResult postAddCourse([FromBody] Cours newCourse)
        {
            //sprawdzenie czy model jest poprawny
            if(!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Courses.Add(newCourse);
            db.SaveChanges();
            return Ok(newCourse.id);
        }

        [ActionName("Usuń")]
        [HttpDelete]

        public IHttpActionResult deleteCourse([FromBody] int id)
        {
            var toDelete = db.Courses.Find(id);
            db.Courses.Remove(toDelete);
            db.SaveChanges();
            return Ok(toDelete.id);
        }



        [ActionName("Edytuj")]
        [HttpPut]

        public IHttpActionResult putModify([FromBody] Cours modifiedCourse, int id)
        {
            //sprawdzenie czy model jest poprawny
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Entry(modifiedCourse).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
            return Ok("Zmodyfikowano kurs");
        }


    } 
}
