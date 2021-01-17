using System;
using System.Collections.Generic;

#nullable disable

namespace LoginData.Models
{
    public partial class Registration
    {
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}
