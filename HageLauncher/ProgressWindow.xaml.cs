using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.Windows.Threading;

namespace HageLauncher
{
    /// <summary>
    /// ProgressWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class ProgressWindow : Window
    {

        private DispatcherTimer timer;

        public ProgressWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;
        }


        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // DispatcherTimerのインスタンスを生成
            timer = new DispatcherTimer();

            // インターバルを5秒に設定
            timer.Interval = TimeSpan.FromSeconds(5);

            // Tickイベントハンドラを設定
            timer.Tick += Timer_Tick;

            // タイマーを開始
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            // タイマーを停止
            timer.Stop();

            // ウィンドウを閉じる
            this.Close();
        }


    }
}
