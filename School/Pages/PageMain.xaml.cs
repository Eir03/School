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

            CmdClass.SelectedValuePath = "Id";
            CmdClass.DisplayMemberPath = "Number";

            CmdClass.ItemsSource = OdbClass.entities.Class.ToList();

            DG.ItemsSource = OdbClass.entities.Student.OrderBy(x => x.IdClass).ThenBy(x=>x.MiddleName).ToList();
            
        }

        private async void  BtnBack_Click(object sender, RoutedEventArgs e)
        {
            DG.ItemsSource = await OdbClass.entities.Student.ToListAsync();
        }

        private void BtnAdd_Click(object sender, RoutedEventArgs e)
        {
            FrameClass.frm.Navigate(new PageAddStudent());
        }

        private async void CmdClass_DropDownClosed(object sender, EventArgs e)
        {
            if(CmdClass.SelectedIndex != -1)
            DG.ItemsSource = await OdbClass.entities.Student.Where(x => x.IdClass == (int)CmdClass.SelectedValue)
                    .OrderBy(x => x.MiddleName).ToListAsync();
            CmdClass.SelectedIndex = -1;
        }

        private void DataGridRow_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            try
            {
                dynamic row = DG.SelectedItem;
                int ID = row.Id;
                FrameClass.frm.Navigate(new PageAddMark(OdbClass.entities.Student.Where(x=>x.Id== ID)));
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
