using Desktop.Connector;
using Desktop.Connectori;
using Desktop.Images.View;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Management.Instrumentation;
using System.Numerics;
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
    /// Логика взаимодействия для Page3.xaml
    /// </summary>
    public partial class Page3 : UserControl
    {
        private MyConnector dbContext; 

        public Page3()
        {
            InitializeComponent();


            // Инициализация контекста данных
            dbContext = new MyConnector();
            LoadDataFromDatabase();

        }






        private void LoadDataFromDatabase()
        {
  
            string lg = LoginView.Global_login;
            try
            {
                using (var context = new MyConnector())
                {
                    // Выбираем врача по логину
                    var doctor = context.Doctors.FirstOrDefault(d => d.login == lg);;

                    if (doctor != null)
                    {
                        // Отображаем данные в TextBox
                        NAME.Text = $" {doctor.Name}";
                        SURNAME.Text = $" {doctor.Surname}";
                        AGE.Text = $" {doctor.age}";
                       
                    }
                    else
                    {
                        MessageBox.Show("Врач с указанным логином не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке данных: " + ex.Message);
            }
        }

        private void Update_Click(object sender, RoutedEventArgs e)
        {
            string name = NAME.Text;
            string surname = SURNAME.Text;
            string age = AGE.Text;
            
      
      

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }

            try
            {
                using (var context = new MyConnector())
                {
                    string lg = LoginView.Global_login;
                    var existingDoctor = context.Doctors.FirstOrDefault(d => d.login == lg);

                    if (existingDoctor != null)
                    {
                        // Обновляем существующего врача
                        existingDoctor.Name = name;
                        existingDoctor.Surname = surname;
                        existingDoctor.age = age;

                        // Сохраняем изменения
                        context.SaveChanges();

                        MessageBox.Show("Данные успешно обновлены.");
                    }
                    else
                    {
                        MessageBox.Show("Врач с указанным логином не найден.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}\n\nInner Exception: {(ex.InnerException != null ? ex.InnerException.Message : "N/A")}");
            }
        }
    }
}