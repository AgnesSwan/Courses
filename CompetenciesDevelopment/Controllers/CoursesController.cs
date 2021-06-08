
using System.Linq;
using System.Web.Http;
using System;
using CompetenciesDevelopment.Models;
using System.Data.Entity;

namespace Courses.Controllers
{
    public class CoursesController : ApiController
    {
        KursyEntities1 db = new KursyEntities1();

        [HttpGet]
        [ActionName("ListaOgloszen")]
        public IHttpActionResult getCourses()
        {

            var coursesList = db.Courses.ToList();
            if (coursesList == null)
                return NotFound();
            
            return Ok(coursesList);


            // return Ok(db.Courses.ToList());
            // I oznacza interfejs/ wynikiem może byc wszystko


        }

        [HttpGet]
        [ActionName("OgloszeniePoId")]
        public IHttpActionResult getDetails([FromUri] int id)
        {
            /* if(id == 0)
             {
                 throw new ArgumentException(
                     "Nie mamy tego ogłoszenia");
             }
             return Ok(db.Courses.Find(id));*/
            var toFind = db.Courses.Find(id);

            if (toFind == null)
                return NotFound();

            return Ok(toFind);
        }

        [ActionName("Dodaj")]
        [HttpPost]
        public IHttpActionResult PostAdd([FromBody] Course newCourse)
        {
            //sprawdzenie czy model jest poprawny
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            db.Courses.Add(newCourse);
            db.SaveChanges();
            return Ok(newCourse.id);
        }

        
        [HttpDelete]
        [ActionName("Usun")]
        public IHttpActionResult deleteCourse([FromUri] int id)
        {
            var toDelete = db.Courses.Find(id);
            db.Courses.Remove(toDelete);
            db.SaveChanges();
            return Ok();
        }



        [ActionName("Edytuj")]
        [HttpPut]

        public IHttpActionResult putModify([FromBody] Course modifiedCourse, [FromUri] int id)
        {
            
           
                //sprawdzenie czy model jest poprawny
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
            var courseDb = db.Courses.Find(id);
            courseDb.name = modifiedCourse.name;
            courseDb.lecturer = modifiedCourse.lecturer;
            courseDb.place = modifiedCourse.place;
            courseDb.description = modifiedCourse.description;
            courseDb.category = modifiedCourse.category;
            courseDb.date = modifiedCourse.date;

            //dodac linijke
            //db.Entry(modifiedCourse).State = System.Data.Entity.EntityState.Modified;
            //db.Entry(modifiedCourse).State = EntityState.Modified;
                db.SaveChanges();
                return Ok("Zmodyfikowano kurs");
            }
            
        


    }
}
