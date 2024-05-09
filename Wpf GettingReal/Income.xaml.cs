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
using System.Windows.Shapes;

namespace Wpf_GettingReal
{
    /// <summary>
    /// Interaction logic for Income.xaml
    /// </summary>
    public partial class Income : Window
    {
        public Income()
        {
            InitializeComponent();
        }

        private void Amount_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Write to file
        }

        private void PaymentMethod_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Write to file
        }

        private void PaymentStatus_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Write to file
        }
    }
}
