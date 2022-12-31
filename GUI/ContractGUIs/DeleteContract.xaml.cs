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

namespace GUI.ContractGUIs
{
    /// <summary>
    /// Interaktionslogik für DeleteContract.xaml
    /// </summary>
    public partial class DeleteContract : Page
    {

        private readonly IProductAdmin admin = (IProductAdmin)Application.Current.Properties["IProductAdmin"];
        public DeleteContract()
        {
            InitializeComponent();
        }

        private void YesButton_Click(object sender, RoutedEventArgs e)
        {
            admin.DeleteContract(ContractCache.cacheID);

            GymHomepage gymHomepage = new GymHomepage();
            NavigationService.Navigate(gymHomepage);
        }

        private void NoButton_Click(object sender, RoutedEventArgs e)
        {
            GymHomepage gymHomepage = new GymHomepage();
            NavigationService.Navigate(gymHomepage);
        }
    }
}
