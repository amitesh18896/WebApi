using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApi.Models;

namespace WebApi.Controllers
{
    public class NewApiController : ApiController
    {
        practiceEntities1 db = new practiceEntities1();

        [System.Web.Http.HttpGet]
        public IHttpActionResult Index()
        {
            List<Models.student> obj = db.students.ToList();
            return Ok(obj);
        }

        [System.Web.Http.HttpGet]
        public IHttpActionResult Index(int id)
        {
            var obj = db.students.Where(model => model.id == id).FirstOrDefault();
            return Ok(obj);
        }
    }
}