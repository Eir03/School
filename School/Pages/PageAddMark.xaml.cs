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
    /// Логика взаимодействия для PageAddMark.xaml
    /// </summary>
    public partial class PageAddMark : Page
    {
        public PageAddMark(IQueryable<Student> students)
        {
            InitializeComponent();
            var studentsList = students.Select(x=>x.Id).ToList();
            DG.ItemsSource = OdbClass.entities.Mark.Where(x=>x.IdStudent == studentsList.FirstOrDefault()).ToList();

            TbName.Text = students.Select(x => x.MiddleName).FirstOrDefault();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
