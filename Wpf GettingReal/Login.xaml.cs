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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Name_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Check for existense
        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {
            // Check for match
        }

        private void Login1_Click(object sender, RoutedEventArgs e)
        {
            // GO TO: Menu.xaml
        }
    }
}
