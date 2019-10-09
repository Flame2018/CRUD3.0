using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD3._0.Data
{
    public class Automobiles
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AID { get; set; }

        [Display(Name ="Car Name")]
        public string Aname { get; set; }

        [Display(Name = "Color")]
        public string Color{ get; set; }

        [Display(Name = "Manufacturer ID")]
        public int MID { get; set; }

        [ForeignKey("MID")]
        public Manufacturers ManID { get; set; }
    }
}
