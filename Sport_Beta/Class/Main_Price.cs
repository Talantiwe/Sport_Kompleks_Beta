using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport
{
    [Table("Main_Price")]
    public class Main_Price
    {
        [Key]
        public int Id_Main_Price{get;set;}
        public string Name { get; set; }
        public decimal Money { get; set; }
    }
}
