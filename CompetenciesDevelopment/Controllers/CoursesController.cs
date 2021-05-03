
using System.Linq;
using System.Web.Http;
using System;
using CompetenciesDevelopment.Models;

namespace Courses.Controllers
{
    public class CoursesController : ApiController
    {
        KursyEntities1 db = new KursyEntities1();

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

        public IHttpActionResult PostAdd([FromBody] Course newCourse)
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

        public IHttpActionResult putModify([FromBody] Course modifiedCourse, int id)
        {
            //sprawdzenie czy model jest poprawny
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //dodac linijke
            db.SaveChanges();
            return Ok("Zmodyfikowano kurs");
        }


    } 
}
