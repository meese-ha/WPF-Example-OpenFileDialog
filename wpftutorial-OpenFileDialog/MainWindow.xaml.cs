using Microsoft.Win32;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace wpftutorial_OpenFileDialog
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

        private void btnFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            bool? success = fileDialog.ShowDialog();
            fileDialog.Filter = "C# Success Files | *.cs";
            fileDialog.Title = "Please pick CS Source file(s)...";
            fileDialog.Multiselect = true;
        
            if(success == true)
            {
                string[] paths = fileDialog.FileNames;
                string[] fileNames = fileDialog.SafeFileNames;
                //tbInfo.Text = fileNames;
            }
            else
            {
                 
            }

        }
    }
}