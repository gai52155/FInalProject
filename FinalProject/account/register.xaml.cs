using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Navigation;

namespace FinalProject.account
{
    public partial class register : Page
    {
        String randomValid;
        public register()
        {
            InitializeComponent();

            randomNumber();

            Member member = new Member();
            LayoutRoot.DataContext = member;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }
        private void submitBtn_Click(object sender, RoutedEventArgs e)
        {
            randomNumber();

        }

        public void randomNumber()
        {
            Random rnd = new Random();
            randomValid = rnd.Next(0, 99999).ToString();
            labelRnd.Content = "รหัสสุ่ม:" + randomValid;
        }
    }
}
