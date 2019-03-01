/*Sebastian Horton
March 1st, 2019
The User inputs an email and has it converted to a hotmail acount
*/

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

namespace _312551
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double input;
        double converted;
        double answer;
        bool truefalse
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnClick_Click(object sender, RoutedEventArgs e)
        {
            
            double.TryParse(txtInput.Text, out input);
            if(input == 0)
            {
                MessageBox.Show("Please enter a number between 0 and 360");
            }
            
            if (chkConvert.IsChecked == false)
            {
                converted = input;
            }

            if (rbSin.IsChecked == true)
            {
                answer = Math.Sin(converted);
            }

            else if (rbCos.IsChecked == true)
            {
                answer = Math.Cos(converted);

            }
            else if (rbTan.IsChecked == true)
            {
                answer = Math.Tan(converted);
            }

            Console.WriteLine(answer.ToString());

            if (rbSin.IsChecked == false & rbCos.IsChecked == false & rbTan.IsChecked == false)
            {
                MessageBox.Show("Please select a function.");
            }
            
        }

        private void chkConvert_Checked(object sender, RoutedEventArgs e)
        {
            converted = (input * Math.PI) / 180;
        }
    }
}
