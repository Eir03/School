using School.Classes;
using School.Pages;
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

namespace School
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OdbClass.entities = new ModelDataBase.Eir_SchoolEntities();
            FrameClass.frm = FrmMain;
            FrameClass.frm.Navigate(new PageMain());
        }

        private void ListMain_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch (ListMain.SelectedIndex)
            {
                case 0:
                    FrameClass.frm.Navigate(new PageTeacher());
                    break;
                case 1:
                    FrameClass.frm.Navigate(new PageMain());
                    break;
                case 2:
                    FrameClass.frm.Navigate(new PageMarkStat());
                    break;
                default:
                    break;
            }
        }
    }
}
