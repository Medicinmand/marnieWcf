﻿using MarnieWcf.DbAccess;
using MarnieWcf.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace MarnieWcf.Controllers
{
    public class PersonController : ApiController
    {
        DbPerson db = new DbPerson();        

        // GET: api/Person
        public IEnumerable<Person> Get()
        {
            return db.GetAllWithRelations();
        }

        // GET: api/Person/5
        public Person Get(int id)
        {
            return db.GetWithRelations(id);
        }

        // POST: api/Person
        public void Post([FromBody]Person person)
        {
            db.Insert(person);
        }

        // PUT: api/Person/5
        public void Put(int id, [FromBody]Person person)
        {
            db.Update(person);
        }

        // DELETE: api/Person/5
        public void Delete(int id)
        {
            db.Delete(id);
        }
    }
}
