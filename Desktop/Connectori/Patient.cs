using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Connectori
{
    [Table("patients", Schema = "Hospital")]
    internal class Patient
    {
        public int id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Diagnos { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }

    }
}
