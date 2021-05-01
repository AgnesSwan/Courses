using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CompetenciesDevelopment.Controllers
{
    public class CoursesController : ApiController
    {
        [HttpGet]
        public IHttpActionResult getCourses()
        {
            return Ok("jest ok");
            // I oznacza interfejs/ wynikiem może byc wszystko
        }
    }
}
