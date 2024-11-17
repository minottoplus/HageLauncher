using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Policy;
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

namespace HageLauncher
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void add_instance_button_Click(object sender, RoutedEventArgs e)
        {

            string InstanceName = "RTM";
            string InstanceVersion = "1.12.2";

            string textToAdd = InstanceName + "/" + InstanceVersion + ";"; // 追加したい文字列をここに指定

            //string relativePath = @"..\assets\instances.txt";
            //string absolutePath = System.IO.Path.GetFullPath(relativePath);

            string absolutePath = "assets/instances.txt";


            File.AppendAllText(absolutePath, "Good morning!");

        }
    }
}
