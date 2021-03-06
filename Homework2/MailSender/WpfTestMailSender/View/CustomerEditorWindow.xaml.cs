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
using System.Windows.Shapes;

namespace WpfTestMailSender.View
{
    /// <summary>
    /// Логика взаимодействия для Window1.xaml
    /// </summary>
    public partial class CustomerEditorWindow : Window
    {
        public CustomerEditorWindow()
        {
            InitializeComponent();
        }

        public void ShowCustomerProp()
        {
            txtDob.Visibility = Visibility.Visible;
            txtAddress.Visibility = Visibility.Visible;
            txtPhone.Visibility = Visibility.Visible;
        }

        public void HideCustomerProp()
        {
            txtDob.Visibility = Visibility.Hidden;
            txtAddress.Visibility = Visibility.Hidden;
            txtPhone.Visibility = Visibility.Hidden;
        }

    }
}
