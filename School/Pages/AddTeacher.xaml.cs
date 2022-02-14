using School.Classes;
using School.ModelDataBase;
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
    /// Логика взаимодействия для AddTeacher.xaml
    /// </summary>
    public partial class AddTeacher : Page
    {
        public AddTeacher()
        {
            InitializeComponent();

            CmbCabinet.SelectedValuePath = "Id";
            CmbCabinet.SelectedValue = "Number";
            CmbCabinet.ItemsSource = OdbClass.entities.Cabinet;

            CmbLesson.SelectedValuePath = "Id";
            CmbLesson.SelectedValue = "Name";
            CmbLesson.ItemsSource = OdbClass.entities.Subject;
        }

        private void BtnExit_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.GoBack();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Teacher teacher = new Teacher()
                {
                    FirstName = TxbName.Text,
                    LastName = TxbMiddleName.Text,
                    IdCabinet = (int)CmbCabinet.SelectedValue,
                    IdSubject = (int)CmbLesson.SelectedValue
                };
                OdbClass.entities.Teacher.Add(teacher);
                FrameClass.frm.Navigate(new PageTeacher());
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
