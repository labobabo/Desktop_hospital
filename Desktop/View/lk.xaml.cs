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
using System.Runtime.InteropServices;
using System.Windows.Interop;
using Desktop.Images.View;

namespace Desktop.View
{
    /// <summary>
    /// Логика взаимодействия для lk.xaml
    /// </summary>
    public partial class lk : Window
    {
        public lk()
        {
            InitializeComponent();

        }
        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }

        [DllImport("user32.dll")]
        private static extern IntPtr SendMessage(IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pnlControlBar_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            WindowInteropHelper helper = new WindowInteropHelper(this);
            SendMessage(helper.Handle, 161, 2, 0);
        }

        private void pnlControlBar_MouseEnter(object sender, MouseEventArgs e)
        {
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }

        private void btnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if (this.WindowState == WindowState.Normal)
            {
                this.WindowState = WindowState.Maximized;
            }
            else this.WindowState = WindowState.Normal;
        }

        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Page2();
        }

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Page1();
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new Page3();
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            contentControl.Content = new FAQ();
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            LoginView log = new LoginView();
            log.Show();
            this.Close();
        }
    }
} 
