﻿using System;
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
using System.Windows.Shapes;
using System.IO;

namespace HageLauncher
{
    /// <summary>
    /// CreateInstance.xaml の相互作用ロジック
    /// </summary>
    public partial class CreateInstance : Window
    {
        public CreateInstance()
        {
            InitializeComponent();




            string Versions_moto = "1.21.3,1.21.2,1.21.1,1.21,1.20,1.20.6,1.20.5,1.20.4,1.20.3,1.20.2,1.20.1,1.19,1.19.4,1.19.3,1.19.2,1.19.1,1.18,1.18.2,1.18.1,1.17,1.17.1,1.16,1.16.5,1.16.4,1.16.3,1.16.2,1.16.1,1.15,1.15.2,1.15.1,1.14,1.14.4,1.14.3,1.14.2,1.14.1,1.13,1.13.2,1.13.1,1.12,1.12.2,1.12.1,1.11,1.11.2,1.11.1,1.10,1.10.2,1.10.1,1.9,1.9.4,1.9.3,1.9.2,1.9.1,1.8,1.8.9,1.8.8,1.8.7,1.8.6,1.8.5,1.8.4,1.8.3,1.8.2,1.8.1,1.7,1.7.10,1.7.9,1.7.8,1.7.7,1.7.6,1.7.5,1.7.4,1.7.2,1.6,1.6.4,1.6.2,1.6.1,1.5,1.5.2,1.5.1,1.4,1.4.7,1.4.6,1.4.5,1.4.4,1.4.2,1.3,1.3.2,1.3.1,1.2,1.2.5,1.2.4,1.2.3,1.2.2,1.2.1,1.1,1.0,1.0.1,1.0.0";
            string[] Versions = Versions_moto.Split(',');

            foreach (string Version in Versions)
            {
                VersionComboBox.Items.Add(Version);
            }


        }








        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CreateButton_Click(object sender, RoutedEventArgs e)
        {
            string InstanceName = NameTextBox.Text;
            string InstanceVersion = VersionComboBox.Text;


            string textToAdd = InstanceName + "/" + InstanceVersion + ";"; // 追加したい文字列をここに指定

            //string relativePath = @"..\assets\instances.txt";
            //string absolutePath = System.IO.Path.GetFullPath(relativePath);

            string absolutePath = "assets/instances.txt";


            File.AppendAllText(absolutePath, textToAdd);

            //close window
            this.Close();


        }

        private void NameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

            if (NameTextBox.Text != "" & VersionComboBox.SelectedItem != null)
            {
                CreateButton.IsEnabled = true;
            }
            else
            {
                CreateButton.IsEnabled = false;
            }
        }

        private void VersionComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (NameTextBox.Text != "" & VersionComboBox.SelectedItem != null)
            {
                CreateButton.IsEnabled = true;
            }
            else
            {
                CreateButton.IsEnabled = false;
            }
        }


    }
}
