namespace TheBookProject.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Security.Claims;
    using System.Threading.Tasks;

    using Common.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;

    using TheBookProject.Common.Constants;

    public class User : IdentityUser, IAuditInfo, IDeletableEntity
    {
        private ICollection<Book> books;

        public User()
        {
            this.books = new HashSet<Book>();
            this.CreatedOn = DateTime.UtcNow;
        }

        [Required]
        [StringLength(DataModelConstants.UserFirstNameMaxLength)]
        [MinLength(DataModelConstants.UserFirstNameMinLength)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(DataModelConstants.UserLastNameMaxLength)]
        [MinLength(DataModelConstants.UserLastNameMinLength)]
        public string LastName { get; set; }

        public string ProfileImage { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime? DeletedOn { get; set; }

        public bool IsDeleted { get; set; }

        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<Book> Books
        {
            get { return this.books; }
            set { this.books = value; }
        }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<User> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);

            return userIdentity;
        }
    }
}
