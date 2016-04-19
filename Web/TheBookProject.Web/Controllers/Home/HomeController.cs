namespace TheBookProject.Web.Controllers.Home
{
    using System.Collections.Generic;
    using System.Web.Mvc;

    using Data.Models;
    using Services.Data.Contracts;
    using Services.Web;
    
    using ViewModels.Home;

    public class HomeController : BaseController
    {
        private readonly IBookService books;
        private readonly IUserService users;
        private readonly ICacheService cache;

        public HomeController(IBookService books, IUserService users, ICacheService cache)
        {
            this.books = books;
            this.users = users;
            this.cache = cache;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Home()
        {
            var allAddedBooks = this.cache.Get<int>(
               "allAddedBooks",
               () =>
               {
                   return this.books.AllAddedBooks();
               },
                2 * 60 * 60);

            var allRegisteredUsers = this.cache.Get<int>(
               "allRegisteredUsers",
               () =>
               {
                   return this.users.AllRegisteredUsers();
               },
                2 * 60 * 60);

            var viewModel = new HomeViewModel
            {
                Books = allAddedBooks,
                Users = allRegisteredUsers
            };

            return this.View(viewModel);
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
