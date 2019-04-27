using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cache_using_sample.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult homepage()
        {
            HttpContext.Cache.Add("name", "alican", null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(0, 0, 20), System.Web.Caching.CacheItemPriority.High, null);
            HttpContext.Cache.Add("surname", "yilmaz", null, new DateTime(2018, 12, 16, 00, 34,0), System.Web.Caching.Cache.NoSlidingExpiration, System.Web.Caching.CacheItemPriority.Low, null);
            HttpContext.Cache.Add("age", "24", null, System.Web.Caching.Cache.NoAbsoluteExpiration, new TimeSpan(50000), System.Web.Caching.CacheItemPriority.High, null);

            return View();
        }

        public ActionResult samplepage()
        {
            return View();
        }
    }
}