﻿using PRAKTIKA_1.praktikaDataSetTableAdapters;
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

namespace PRAKTIKA_1
{
    public partial class Page1 : Page
    {
        int re = 0;

        werhouseTableAdapter werehouse = new werhouseTableAdapter();
        werhouseTableAdapter tip = new werhouseTableAdapter();
        public Page1()
        {
            InitializeComponent();

            werehouseDataGrid_Copy.ItemsSource = tip.GetData();
            werehouseDataGrid_Copy.DisplayMemberPath = "adress";

            werehouseDataGrid.ItemsSource = werehouse.GetData();
        }
        private void ColourDgr_Click(object sender, RoutedEventArgs e)
        {
            werehouse.InsertQuery(NameTbx.Text, NameTbx_Copy.Text, NameTbx_Copy2.Text);
            werehouseDataGrid.ItemsSource = werehouse.GetData();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PagFrame.Content = new Page1();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PagFrame.Content = new Page2();
        }

        private void del_Click(object sender, RoutedEventArgs e)
        {
            object id = (werehouseDataGrid.SelectedItem as DataRowView).Row[0];
            werehouse.DeleteQuery(Convert.ToInt32(id));

            werehouseDataGrid.ItemsSource = werehouse.GetData();

        }
    }
}
