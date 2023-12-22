using Desktop.Connector;
using Desktop.Connectori;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
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
    /// Логика взаимодействия для UserControl1.xaml
    /// </summary>
    public partial class Page1 : UserControl
    {
        private MyConnector dbContext = new MyConnector();
        public Page1()
        {
            InitializeComponent();

   
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string name = txtFullName.Text;
            string surname = txtSurname.Text;
            string diagnosis = cmbDiagnosis.Text;
            

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            if (!DateTime.TryParse(txtDate.Text, out DateTime date))
            {
                MessageBox.Show("Invalid date format. Use mm.dd.yyyy");
                return;
            }

            if (!TimeSpan.TryParse(txtTime.Text, out TimeSpan time))
            {
                MessageBox.Show("Invalid time format. Use hh:mm:ss");
                return;
            }

            using (var context = new MyConnector())
            {
                try
                {

                    var entity = new Patient
                    {
                        Name = name,
                        Surname = surname,
                        Diagnos = diagnosis,
                        Date = date,
                        Time = time
                    };

                    context.patients.Add(entity);
                    context.SaveChanges();

                    MessageBox.Show("Data saved successfully.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}\n\nInner Exception: {(ex.InnerException != null ? ex.InnerException.Message : "N/A")}");
                }
            }
        }



    }
}
