namespace TheBookProject.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using Common.Models;
    using TheBookProject.Common.Constants;

    public class Book : BaseModel<int>
    {
        [Required]
        [StringLength(DataModelConstants.BookTitleMaxLength)]
        [MinLength(DataModelConstants.BookTitleMinLength)]
        public string Title { get; set; }

        [Required]
        [StringLength(DataModelConstants.BookAuthorMaxLength)]
        [MinLength(DataModelConstants.BookAuthorMinLength)]
        public string Author { get; set; }

        [Required]
        [StringLength(DataModelConstants.BookPublishingHouseMaxLenght)]
        [MinLength(DataModelConstants.BookPublishingHouseMinLenght)]
        public string PublishingHouse { get; set; }

        [StringLength(DataModelConstants.BookSeriesNameMaxLenght)]
        [MinLength(DataModelConstants.BookSeriesNameMinLenght)]
        public string Series { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        [Range(DataModelConstants.BookMinPrice, DataModelConstants.BookMaxPrice)]
        public double Price { get; set; }

        [Required]
        public bool IsBought { get; set; }
    }
}
