using System;
using System.Collections.Generic;

namespace Noble.Models
{
    public class User : IModel
    {
        public Guid Id { get; set; }

        public string Username { get; set; }

        public string EmailAddress { get; set; }

        public string Password { get; set; }

        public string PasswordSalt { get; set; }

        public List<string> Claims { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime ModifiedDate { get; set; }

    }
}
