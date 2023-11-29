using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Sport
{
    [Table("Raspisanie")]
    public partial class Raspisanie
    {
        [Key]
        public int Id_Zapis { get; set; }
        public TimeSpan Time { get; set; }

        public DateTime Data{ get; set; }
        public string Name_Rasp { get; set; }
    }
}
