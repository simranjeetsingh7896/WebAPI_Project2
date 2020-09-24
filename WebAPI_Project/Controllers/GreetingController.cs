using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI_Project.Controllers
{
    public class GreetingController : ApiController
    {
        // GET api/Greeting/{id}
        public string Get(int id)
        {
            string value1 = "Greetings to ";
            string value2 = " people!";
            return value1 + id + value2 ;
        }

        /// <summary>
        /// This method returns string when receiving a post request
        /// <greeting> POST api/Greeting </greeting>
        /// </summary>
        /// <returns>["Hello World!"]</returns>
       
        public string Post()
        {
            return "Hello World!";
        }
    }
}
