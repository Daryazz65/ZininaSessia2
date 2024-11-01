using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
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
using System.Windows.Shapes;
using ZininaSessia2.Model;

namespace ZininaSessia2.View.JournalWindows
{
    /// <summary>
    /// Логика взаимодействия для DiscipWindow.xaml
    /// </summary>
    public partial class DiscipWindow : Window
    {
        public DiscipWindow()
        {
            InitializeComponent();

        }
        private void ListDicp()
        {
            DicpLb.Items.Add(" биологии");
            DicpLb.Items.Add("   компьютерных наук");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.Items.Add("   международных отношений");
            DicpLb.SelectionChanged += DicpLb_SelectionChanged1;

        }
        private void SpecialitesLv_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            // ---
        }

        private void DicpLb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }

        private void DicpLb_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            if (DicpLb.SelectedItem != null)
            {
                //--
            }
            
        }
    }
}
