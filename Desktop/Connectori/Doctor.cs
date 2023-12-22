using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.Connector
{
    [Table("Doctors", Schema = "Hospital")]
    public class Doctor
    {
        public long id { get; set; }
        public string login { get; set; }
        public string password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string age { get; set; }
       

    }
}
