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

namespace WPF_NFD_03
{

    public class User
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public override string ToString() => $@" {DateTime.Now} {Name} {Age }";
    }
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {



        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var r = FindResource("UserArray") as Array;

            foreach (var item in r)
            {
                MessageBox.Show(item.ToString());
            }

        }

        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            MessageBox.Show("Alloha!!!");

        }
    }
}
