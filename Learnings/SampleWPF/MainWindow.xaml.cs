using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

namespace SampleWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private async Task SearchDirc()
        {
            string strDir = "";
            try
            {
                string path = @"C:/";
                string[] lsDirec = Directory.GetDirectories(path);
                foreach (string s in lsDirec)
                {
                    Thread.Sleep(100);
                    strDir = strDir + "\n" + s;
                    viewDirecArea.Text += strDir;
                }
            }
            catch (Exception ex)
            {

            }
        }

        private async void Button_Click(object sender, RoutedEventArgs e)
        {
            await SearchDirc();
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void Button_SourceUpdated(object sender, DataTransferEventArgs e)
        {

        }
    }
}
