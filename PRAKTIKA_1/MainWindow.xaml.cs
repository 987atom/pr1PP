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
        werhouseTableAdapter werehouse = new werhouseTableAdapter();
        tipe_of_produktTableAdapter tipe_of_produkt = new tipe_of_produktTableAdapter();

        public MainWindow()
        {
            InitializeComponent();
            werehouseDataGrid.ItemsSource = werehouse.GetData();
            tipe_of_produktDataGrid.ItemsSource = tipe_of_produkt.GetData();
            tipe_of_produktDataGrid.DisplayMemberPath = "color";
        }

        private void tipe_of_produktDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (tipe_of_produktDataGrid.SelectedItem as DataRowView).Row[0];
            MessageBox.Show(cell.ToString());
        }
    }
}

