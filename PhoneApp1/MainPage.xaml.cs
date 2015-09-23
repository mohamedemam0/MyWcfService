using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using PhoneApp1.Resources;
using PhoneApp1.ServiceReference1;
namespace PhoneApp1
{
    public partial class MainPage: PhoneApplicationPage
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        // Constructor
        public MainPage()
        {
            InitializeComponent();

            // Sample code to localize the ApplicationBar
            //BuildLocalizedApplicationBar();
        }

        private  void InsertBtn_Click(object sender, RoutedEventArgs e)
        {
            UserDetails userInfo = new UserDetails();
            userInfo.UserName = txtUserName.Text;
            userInfo.Password = txtPassword.Text;
            userInfo.Email = txtEmail.Text;
            try
            {

            service.InsertUserDetailsAsync(userInfo);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                
            }
            service.InsertUserDetailsCompleted += service_InsertUserDetailsCompleted;
        }

        void service_InsertUserDetailsCompleted(object sender, InsertUserDetailsCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        private void FindBtn_Click(object sender, RoutedEventArgs e)
        {
            string s = txtFind.Text;
            this.Content = new Page1(s);
        }

        
    }
}