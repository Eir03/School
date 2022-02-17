using School.Classes;
using School.ModelDataBase;
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
    /// Логика взаимодействия для PageAddMark.xaml
    /// </summary>
    public partial class PageAddMark : Page
    {
        private IQueryable<Student> _students { get; set; }
        public PageAddMark(IQueryable<Student> students)
        {
            InitializeComponent();
            
            _students = students;

            CmbSubject.SelectedValuePath = "Id";
            CmbSubject.DisplayMemberPath = "Name";
            CmbSubject.ItemsSource = OdbClass.entities.Subject.ToList();

            var student = _students.Select(x => x.Id).FirstOrDefault();
            DG.ItemsSource = OdbClass.entities.Mark.Where(x => x.IdStudent == student).ToList();

            TbName.Text = students.Select(x => x.MiddleName).FirstOrDefault();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (CmbMark.SelectedIndex != -1 && CmbSubject.SelectedIndex != -1)
                {
                    Mark mark = new Mark() 
                    {
                        IdStudent = _students.Select(x=>x.Id).FirstOrDefault(),
                        IdSubject = (int)CmbSubject.SelectedValue,
                        MarkSubject = int.Parse(CmbMark.Text)
                    };
                    OdbClass.entities.Mark.Add(mark);
                    OdbClass.entities.SaveChanges();

                    FrameClass.frm.Navigate(new PageAddMark(_students));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnDelete_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (DG.SelectedItem != null)
                {
                    dynamic row = DG.SelectedItem;
                    int id = row.Id;
                    var del = OdbClass.entities.Mark.FirstOrDefault(x=>x.Id == id);
                    OdbClass.entities.Mark.Remove(del);
                    OdbClass.entities.SaveChanges();
                    FrameClass.frm.Navigate(new PageAddMark(_students));
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void BtnBack_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new PageMain());
        }
    }
}
