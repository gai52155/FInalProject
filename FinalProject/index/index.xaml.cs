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

namespace FinalProject.index
{
    public partial class index : Page
    {
        MySQL.connectionSoapClient myService;
        public index()
        {
            InitializeComponent();

            myService = new MySQL.connectionSoapClient();
            myService.ExecuteScalarCompleted += Myservice_ExecuteScalarCompleted;
            myService.ExecuteNonQueryCompleted += Myservice_ExecuteNonQueryCompleted;
        }

        void Myservice_ExecuteNonQueryCompleted(object sender, MySQL.ExecuteNonQueryCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        void Myservice_ExecuteScalarCompleted(object sender, MySQL.ExecuteScalarCompletedEventArgs e)
        {
            MessageBox.Show(e.Result);
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void esBtn_Click(object sender, RoutedEventArgs e)
        {
            myService.ExecuteScalarAsync(textBox1.Text);
        }

        private void enqBtn_Click(object sender, RoutedEventArgs e)
        {
            myService.ExecuteNonQueryAsync(textBox1.Text);
        }
    }
}
