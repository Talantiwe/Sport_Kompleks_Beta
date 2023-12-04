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
    [Table("Zapis")]
    public class Zapis
    {
        [Key]
        public int Id_Zapis { get; set; }
        public string Name { get; set; }
        public TimeSpan Time { get; set; }
        public DateTime Data { get; set; }
        public int Id_User { get; set; }
      //  public int Id { get; set; }
    }
}
