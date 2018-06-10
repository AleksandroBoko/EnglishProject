using EnglishProject.DataAccess;
using System.Collections.Generic;
using System.Web.Mvc;

namespace EnglishProject.Controllers
{
    public class HomeController : Controller
    {
        private DbService dbService = new DbService();
        private IList<EnglishPrase> list;

        public HomeController()
        {
            list = dbService.GetListEnglishPhrases();
        }

        // GET: Home
        public ActionResult Index()
        {
            var JSONResult = new JsonResult();
            JSONResult.Data = (object)list;
            return JSONResult;
        }
    }
}