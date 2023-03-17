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
    public partial class Page2 : Page
    {
        int re = 0;
        tipe_of_produktTableAdapter tipe_of_produkt = new tipe_of_produktTableAdapter();
        werhouseTableAdapter werhouse = new werhouseTableAdapter();
        public Page2()
        {
            InitializeComponent();
            NameTbx_Copy1.ItemsSource = werhouse.GetData();
            NameTbx_Copy1.DisplayMemberPath = "adress";

            tipe_of_produktDataGrid.ItemsSource = tipe_of_produkt.GetData();
        }

        private void Button_Click1(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PagFrame.Content = new Page2();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            (Application.Current.MainWindow as MainWindow).PagFrame.Content = new Page1();
        }
        private void ColourDgr_Click(object sender, RoutedEventArgs e)
        {
            tipe_of_produkt.InsertQuery(NameTbx.Text, NameTbx_Copy.Text, re);
            tipe_of_produktDataGrid.ItemsSource = tipe_of_produkt.GetData();
        }

        private void NameTbx_Copy1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            object cell = (NameTbx_Copy1.SelectedItem as DataRowView).Row[0];
            re = (int)cell;
        }
    }
}
