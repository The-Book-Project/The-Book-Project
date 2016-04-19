namespace TheBookProject.Web.ViewModels.Book
{
    using System.ComponentModel.DataAnnotations;

    using Common.Constants;

    public class AddBookViewModel
    {
        [Required]
        [StringLength(DataModelConstants.BookTitleMaxLength)]
        [MinLength(DataModelConstants.BookTitleMinLength)]
        [Display(Name = "Заглавие")]
        public string Title { get; set; }

        [Required]
        [StringLength(DataModelConstants.BookAuthorMaxLength)]
        [MinLength(DataModelConstants.BookAuthorMinLength)]
        [Display(Name = "Автор")]
        public string Author { get; set; }

        [Required]
        [StringLength(DataModelConstants.BookPublishingHouseMaxLenght)]
        [MinLength(DataModelConstants.BookPublishingHouseMinLenght)]
        [Display(Name = "Издателство")]
        public string PublishingHouse { get; set; }

        [StringLength(DataModelConstants.BookSeriesNameMaxLenght)]
        [MinLength(DataModelConstants.BookSeriesNameMinLenght)]
        [Display(Name = "Серия")]
        public string Series { get; set; }

        [Required]
        [Display(Name = "Корица/Снимка")]
        public string Image { get; set; }

        [Required]
        [Range(DataModelConstants.BookMinPrice, DataModelConstants.BookMaxPrice)]
        [Display(Name = "Цена")]
        public double Price { get; set; }
    }
}
