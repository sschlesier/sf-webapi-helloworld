using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using DotNetNuke.Web.Api;

namespace MyServices
{
    public class WelcomeController : DnnApiController
    {
        [AllowAnonymous] 
        [HttpGet]
        public HttpResponseMessage HelloWorld()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "Hello World!");
        }
    }
}
