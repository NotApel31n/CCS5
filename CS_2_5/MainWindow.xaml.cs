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
using System.IO;
namespace CS_2_5
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();


            InitializeSavedDaysFile();


            int yy = DateTime.Now.Year;
            int mm = DateTime.Now.Month;


            PageFrame.Content = new Page1(mm, yy);
        }

        private void InitializeSavedDaysFile()
        {
            string filePath = "saved_days.json";

            if (!File.Exists(filePath))
            {
                File.WriteAllText(filePath, "[]");
            }
        }

    }
}
