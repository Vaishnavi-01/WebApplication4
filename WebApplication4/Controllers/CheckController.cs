using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApplication4.Controllers
{
    public class CheckController : ApiController
    {
        public IEnumerable<string> Get()
        {
            IList<string> lstNames = new List<string>();
            lstNames.Add("abc");
            lstNames.Add("def");
            lstNames.Add("qwe");

            return lstNames;
        }
    }
}
