using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Sport
{
    [Table("User")]
    public class User
    {
        [Key]       
        public int Id_User { get; set; }
       public string Name { get; set; }
        //public string Username { get; set; }
       public string login { get; set; }
        public string pass { get; set; }
    }
}
