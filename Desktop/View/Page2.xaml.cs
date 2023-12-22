  using Desktop.Connector;
using Desktop.Connectori;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Desktop.View
{
    /// <summary>
    /// Логика взаимодействия для Page2.xaml
    /// </summary>
    public partial class Page2 : UserControl
    {
        //private BindingList<Doctor> _doctors;
        private BindingList<Patient> _patients;


        public Page2()
        {
            InitializeComponent();

        }




        private void DataGrid_Loaded(object sender, RoutedEventArgs e)
        {
            _patients = new BindingList<Patient>();
            {
                using (var dbContext = new MyConnector())
                {
                    // Получите данные из базы данных
                    //var doctorsData = dbContext.Doctors.ToList();
                    var patientsData = dbContext.patients.ToList();
                    // Инициализируйте BindingList с данными из базы данных
                    _patients = new BindingList<Patient>(patientsData);
                }


            };
            
            DataGrid.ItemsSource = _patients;


        }


    }

}
