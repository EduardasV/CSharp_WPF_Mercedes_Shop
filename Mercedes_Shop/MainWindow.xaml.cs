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

namespace Mercedes_Shop
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string colour = "white";
        string model = "C-Class";

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string result = String.Format("Mercedes {0} {1}", model, colour);
            listBox1.Items.Add(result);
        }

        private void ColourButton_Checked(object sender, RoutedEventArgs e)
        {
            if (clr1.IsChecked == true) colour = "white";
            else if (clr2.IsChecked == true) colour = "black";
            else if (clr3.IsChecked == true) colour = "grey";
        }

        private void ModelButton_Checked(object sender, RoutedEventArgs e)
        {
            if (mdl1.IsChecked == true) model = "C-Class";
            else if (mdl2.IsChecked == true) model = "S-Class";
            else if (mdl3.IsChecked == true) model = "E-Class";
        }
    }
}
