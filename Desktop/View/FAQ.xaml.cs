﻿using System;
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
    /// Логика взаимодействия для FAQ.xaml
    /// </summary>
    public partial class FAQ : UserControl
    {
        public FAQ()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            Help Hlab = new Help();
            Hlab.Show();
            
        }
    }
}
