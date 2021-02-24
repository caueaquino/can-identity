using System;

namespace Identity.Domain.Entities
{
    public class User : BaseEntity
    {
        public string Name { get; set; }
        public DateTimeOffset Birthdate { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public User(string name, DateTimeOffset birthDate, string email, string password)
        {
            this.Name = name;
            this.Birthdate = birthDate;
            this.Email = email;
            this.Password = password;
        }
    }
}
