using System;
using System.Collections.Generic;
using System.Data;
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

using PRAKTIKA_1.praktikaDataSetTableAdapters;

namespace PRAKTIKA_1
{
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            PagFrame.Content = new Page2();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            PagFrame.Content = new Page1();
        }
    }
}