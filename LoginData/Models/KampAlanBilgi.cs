using System;
using System.Collections.Generic;

#nullable disable

namespace LoginData.Models
{
    public partial class KampAlanBilgi
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Weather { get; set; }
        public string Manzara { get; set; }
        public string Aciklama { get; set; }
        public string Lokasyon { get; set; }
        public bool? Bungalov { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? CreateId { get; set; }
        public DateTime? CreateDate { get; set; }

        public virtual User Create { get; set; }
    }
}
