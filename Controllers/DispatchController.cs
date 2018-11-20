using Newtonsoft.Json;
using Operations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using darkHeresyBack.Models;

namespace darkHeresyService.Controllers
{
    public class DispatchController : ApiController
    {

        [HttpGet]
        [Route("{name}/{id}")]
        public object DispatchGet(string name, int id)
        {
            Console.WriteLine(name);
            return name == null ? "Give a name" : Operation.Get(name, id);
        }

        //[HttpGet]
        //[Route("{name}")]
        //public object DispatchGet(string name)
        //{
        //    Console.WriteLine(name);
        //    return name == null ? "Give a name" : Operation.Get(name, User.Identity.GetUserId());
        //}

        [HttpPost]
        [Route("{name}")]
        public object DispatchPost(RequestModel obj, string name)
        {
            return name == null ? "Give a name" : Operation.Add(name, obj.FindCorrectDTO());
        }


        [HttpPut]
        [Route("{name}")]
        public object DispatchPut(RequestModel obj, string name)
        {
            if (name == null)
                return "Give a name";
            Operation.Modify(name, obj.FindCorrectDTO());
            return "";
        }

        [HttpDelete]
        [Route("{name}")]
        public object DispatchDelete(RequestModel obj, string name)
        {
            if (name == null)
                return "Give a name";
            Operation.Remove(name, obj.FindCorrectDTO());
            return "";
        }
  
    }
}
