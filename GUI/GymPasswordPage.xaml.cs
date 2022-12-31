﻿using loremipsum.Gym;
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

namespace GUI
{
    /// <summary>
    /// Interaktionslogik für GymPasswordPage.xaml
    /// </summary>
    public partial class GymPasswordPage : Page
    {
        public GymPasswordPage()
        {
            InitializeComponent();
        }

        private void LogIn_Click(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string password = Password.Text;
            IProductAdmin admin = (IProductAdmin)Application.Current.Properties["IProductAdmin"];
            MemberPage member = new MemberPage();//nur grad hier um zu testen ob die navigation geht
            NavigationService.Navigate(member);
            //if (admin.checkUser(username, password)){
            //navigate to next window, check which one 
        }
    }
}