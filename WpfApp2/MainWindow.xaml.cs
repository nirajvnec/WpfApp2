using System.Collections.Generic;
using System.IO;
using System.Windows;
using Microsoft.Win32;
using WpfApp2.ViewModels;

namespace WpfApp2
{
    public partial class MainWindow : Window
    {
        public List<dynamic> ExcelData { get; set; }

        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MainViewModel();
        }

        

    }
}
