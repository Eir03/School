using School.Classes;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
    /// Логика взаимодействия для PageMain.xaml
    /// </summary>
    public partial class PageMain : Page
    {
        public PageMain()
        {
            InitializeComponent();
            DG.ItemsSource = OdbClass.entities.Student.ToList();
            
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.GoBack();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
