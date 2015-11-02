using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Mvc;
using IAT.Web.Models.DAL;
using IAT.Web.Models.DAL.Entities;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace IAT.Web.Controllers.API
{
    [Route("api/[controller]")]
    public class AppController : Controller
    {
        private IATDataContext db;

        public AppController(IATDataContext IATDB)
        {
            this.db = IATDB;
            if (this.db.Apps.ToList().Count == 0)
            {
                //add default apps
                var applist = new List<App>();
                applist.Add(new App() { AppName = "IBC Japan" });
                applist.Add(new App() { AppName = "Auto Terminal" });
                applist.Add(new App() { AppName = "Buying Solutions" });
                applist.Add(new App() { AppName = "IBC Corp" });

                this.db.Apps.AddRange(applist);
                this.db.SaveChanges();
            }
        }

        // GET: api/values
        [HttpGet]
        public IEnumerable<App> Get()
        {
            return this.db.Apps.ToList();
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
