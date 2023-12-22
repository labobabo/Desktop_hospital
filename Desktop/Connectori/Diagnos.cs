using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Connectori
{
    [Table("diagnoses", Schema = "Hospital")]
    public class Diagnos
    {
        [Column("id")]
        public int id { get; set; }
        [Column("Name")]
        public string Name { get; set; }
    }
}
