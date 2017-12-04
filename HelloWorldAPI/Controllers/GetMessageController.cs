using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace HelloWorldAPI.Controllers
{
    public class GetMessageController : ApiController
    {
        // GET api/GetMessage
        public string GetMessage()
        {
            return "Hello World";
        }

        // GET api/GetMessage/id
        public string Get(string id)
        {
            return "Hello " + id;
        }
    }
}
