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
using System.Windows.Shapes;
using Desktop.View;
using Desktop.Connector;
using Microsoft.EntityFrameworkCore;
using Npgsql;
using System.Security.Cryptography.X509Certificates;

namespace Desktop.Images.View
{
    /// <summary>
    /// Логика взаимодействия для LoginView.xaml
    /// </summary>
    public partial class LoginView : Window
    {
        public LoginView()
        {
            InitializeComponent();
            // Проверка подключения при инициализации LoginView
            string connectionString = "Host=localhost;Port=5432;Database=Hospital;Username=postgres;Password=2282";

            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("Подключение успешно!");
                }
                catch (NpgsqlException ex)
                {
                    Console.WriteLine($"Ошибка подключения: {ex.Message}");
                    MessageBox.Show("Не удалось подключиться к базе данных.", "Ошибка подключения", MessageBoxButton.OK, MessageBoxImage.Error);
                    Close(); // Закрыть окно, если подключение не удалось
                }
            }

        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            WindowState = WindowState.Minimized;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }





        
        public static string Global_login { get; set; }
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string enteredLogin = txtUser.Text; 
            string enteredPassword = txtPass.Password;
            

            using (var Context = new MyConnector()) 
            {
                try
                {
                    var doctor = Context.Doctors.FirstOrDefault(d => d.login == enteredLogin && d.password == enteredPassword);

                    if (doctor != null)
                    {
                        // Логин успешен
                        MessageBox.Show("Логин успешен!");

                        LoginView.Global_login = enteredLogin;

                       
                        lk lcab = new lk();
                        lcab.Show();
                        this.Close();
                    }
                    else
                    {
                        // Неверные учетные данные
                        MessageBox.Show("Неверные учетные данные.", "Ошибка входа", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Ошибка при выполнении запроса: {ex.Message}");
                    MessageBox.Show("Произошла ошибка при выполнении запроса.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

        }


    }
}
