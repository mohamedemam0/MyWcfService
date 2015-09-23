using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.ServiceReference1;

namespace PhoneApp1
{
    public partial class Page1: PhoneApplicationPage
    {
        public Page1( string s)
        {
            InitializeComponent();

            ServiceReference1.Service1Client client = new ServiceReference1.Service1Client();

            client.FindUserCompleted += client_FindUserCompleted;
            client.FindUserAsync(s);
        }

        private void client_FindUserCompleted(object sender, FindUserCompletedEventArgs e)
        {
            listBox1.ItemsSource = e.Result;
        }
    }
}