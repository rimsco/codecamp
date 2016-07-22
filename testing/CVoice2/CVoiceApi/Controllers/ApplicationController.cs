using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Cors;
using CVoiceApi.Repositories;
using CVoiceApi.Implements;
using CVoiceApi.Models.Entities;
using MongoDB.Bson;

// For more information on enabling Web API for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace CVoiceApi.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/application")]
    [EnableCors("AllowSpecificOrigin")]
    public class ApplicationController : ApiController
    {
        IApplication _application;
        public ApplicationController()
        {
            _application = new UowApplication();
        }

        // GET: api/values
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("{id}")]
        public IHttpActionResult Get(string id)
        {
            var result = _application.GetOne(MongoDB.Bson.ObjectId.Parse(id));
            return Ok(result);
        }

        // GET api/values/5
        [Microsoft.AspNetCore.Mvc.HttpGet]
        [Microsoft.AspNetCore.Mvc.Route("")]
        public IHttpActionResult GetAll(int id)
        {
            var result = _application.GetAll();
            return Ok(result);
        }

        // POST api/values
        [System.Web.Http.HttpPost]
        [Microsoft.AspNetCore.Mvc.Route("")]
        public IHttpActionResult Create(Application objModel)
        {
            var result = _application.Create(objModel);
            return Ok();
        }

        // PUT api/values/5
        [Microsoft.AspNetCore.Mvc.HttpPut("{id}")]
        [Microsoft.AspNetCore.Mvc.Route("")]
        public IHttpActionResult Edit(Application objModel)
        {
            var result = _application.Create(objModel);
            return Ok();
        }

        //// DELETE api/values/5
        //[HttpDelete("{id}")]
        //public void Delete(int id)
        //{
        //}
    }
}
