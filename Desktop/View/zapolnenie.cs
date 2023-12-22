using Desktop.Connector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desktop.View
{
    internal class zapolnenie
    {
        private BindingList<Doctor> _doctorsList;

        public BindingList<Doctor> DoctorsList
        {
            get { return _doctorsList; }
            set { _doctorsList = value; }
        }

        public void LoadDoctorsFromDatabase()
        {
            using (var dbContext = new MyConnector())
            {
                // Получите данные из базы данных
                var doctorsData = dbContext.Doctors.ToList();

                // Инициализируйте BindingList с данными из базы данных
                _doctorsList = new BindingList<Doctor>(doctorsData);
            }
        }
    }
}
