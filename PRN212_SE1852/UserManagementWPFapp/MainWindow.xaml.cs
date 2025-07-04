﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using BusinessObject;
using Services;


namespace UserManagementWPFapp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        UserServices userService = new UserServices();
        public MainWindow()
        {
            InitializeComponent();
            LoaDingDataUser();
        }

        private void LoaDingDataUser()
        {
            List<User> users = userService.GetAllUser();
            lbUser.ItemsSource = users;
        }
    }
}