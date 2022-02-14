using School.Classes;
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
    /// Логика взаимодействия для PageTeacher.xaml
    /// </summary>
    public partial class PageTeacher : Page
    {
        public PageTeacher()
        {
            InitializeComponent();

            DG.ItemsSource = OdbClass.entities.Teacher.ToList();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DG.SelectedItem != null)
                {
                    dynamic row = DG.SelectedItem;
                    int id = row.Id;
                    var del = OdbClass.entities.Teacher.FirstOrDefault(x => x.Id == id);
                    OdbClass.entities.Teacher.Remove(del);
                    OdbClass.entities.SaveChanges();
                    FrameClass.frm.Navigate(new PageTeacher());
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
