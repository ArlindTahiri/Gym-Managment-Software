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
    /// Interaktionslogik für DeleteMember.xaml
    /// </summary>
    public partial class DeleteMember : Page
    {
        IProductAdmin admin = (IProductAdmin)Application.Current.Properties["IProductAdmin"];
        public DeleteMember()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            admin.DeleteMember(MemberCache.cacheID);

            GymHomepage home = new GymHomepage();
            NavigationService.Navigate(home);
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            GymHomepage home  = new GymHomepage();
            NavigationService.Navigate(home);
        }
    }
}