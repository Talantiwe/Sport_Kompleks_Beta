using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace Sport
{
    [Table("Trainer")]
    public class Trainer
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime ДатаРождения { get; set; }
        public string Spezialist { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Age { get; set; }
        public string History { get; set; }
        public string Expirience { get; set; }
        public string Education { get; set; }
        public byte[] Photo { get; set; }


        // Другие свойства, которые вам необходимы

        // Обратите внимание, что типы данных и другие атрибуты должны быть указаны явно

    }

}
