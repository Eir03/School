﻿using School.Classes;
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

namespace School.Pages
{
    /// <summary>
    /// Логика взаимодействия для PageAddStudent.xaml
    /// </summary>
    public partial class PageAddStudent : Page
    {
        public PageAddStudent()
        {
            InitializeComponent();
            CmbClass.SelectedValuePath = "Id";
            CmbClass.DisplayMemberPath = "Number";

            CmbClass.ItemsSource = OdbClass.entities.Class.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            if (true)
            {

            }
        }
    }
}
