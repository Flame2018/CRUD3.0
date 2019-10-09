using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD3._0.Data
{
    public class Manufacturers
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int MID { get; set; }

        [Display(Name ="Manufacturer Name")]
        public string Mname { get; set; }

        [Display(Name ="Quatity Manufactured")]
        public int Mqty { get; set; }

        [Display(Name ="Manufacturer Year")]
        public int Myear { get; set; }
    }
}
