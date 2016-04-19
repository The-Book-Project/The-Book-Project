namespace TheBookProject.Web.Controllers.Book
{
    using System;
    using System.Web.Mvc;

    using Microsoft.AspNet.Identity;
    using Services.Data.Contracts;

    using ViewModels.Book;

    public class BookController : BaseController
    {
        private readonly IBookService books;

        public BookController(IBookService books)
        {
            this.books = books;
        }

        public ActionResult Index()
        {
            return this.View();
        }

        public ActionResult Add(AddBookViewModel model)
        {
            if (this.User.Identity.IsAuthenticated)
            {
                this.RedirectToAction("Login", "Accounnt");
            }

            if (this.ModelState.IsValid)
            {
                var series = string.Empty;
                if (model.Series == string.Empty)
                {
                    series = "No series";
                }
                else
                {
                    series = model.Series;
                }

                var book = new Data.Models.Book()
                {
                    Title = model.Title,
                    Author = model.Author,
                    PublishingHouse = model.PublishingHouse,
                    Series = series,
                    Image = model.Image,
                    Price = model.Price,
                    CreatedOn = DateTime.Now,
                    IsBought = false,
                    UserId = this.User.Identity.GetUserId()
                };

                this.books.AddBook(book);
            }

            return this.View("Add");
        }
    }
}