namespace TheBookProject.Web.Controllers.Home
{
    using System.Linq;
    using System.Web.Mvc;

    using Services.Data.Contracts;
    using Services.Web;

    using ViewModels.Home;
    using Data.Models;
    using System.Collections.Generic;
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
