using Desktop.Connector;
using Desktop.Connectori;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desktop.Connector
{
    internal class MyConnector : DbContext
    {
        public  DbSet<Doctor> Doctors { get; set; }
        public  DbSet<Patient> patients { get; set; }
        public DbSet<Diagnos> diagnoses { get; set; }
        public MyConnector()
        {
            Database.EnsureCreated();

        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Hospital;Username=postgres;Password=2282");
        }



    }
}
        

