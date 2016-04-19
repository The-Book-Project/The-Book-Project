namespace TheBookProject.Web.Controllers.Home
{
    using System.Web.Mvc;

    public class HomeController : BaseController
    {

        public HomeController()
        {
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Home()
        {
            return this.View();
        }

        public ActionResult About()
        {
            return this.View();
        }

        public ActionResult Contacts()
        {
            return this.View();
        }
    }
}
