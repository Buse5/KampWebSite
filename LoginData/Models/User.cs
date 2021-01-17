using System;
using System.Collections.Generic;

#nullable disable

namespace LoginData.Models
{
    public partial class User
    {
        public User()
        {
            KampAlanBilgis = new HashSet<KampAlanBilgi>();
        }

        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }

        public virtual ICollection<KampAlanBilgi> KampAlanBilgis { get; set; }
    }
}
