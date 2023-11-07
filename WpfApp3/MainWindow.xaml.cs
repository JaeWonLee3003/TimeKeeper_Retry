using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;
using System.Windows.Media.Imaging;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        private DateTime startTime;
        private Grid dashboard; // dashboard 필드 추가

        public MainWindow()
        {
            InitializeComponent();

            this.Loaded += MainWindow_Loaded;

            startTime = DateTime.Now;
            Main_Btn1.Click += Main_Btn1_Click;
            Main_Btn2.Click += Main_Btn2_Click;
            Main_Btn3.Click += Main_Btn3_Click;

        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {


        }




        /// <summary>
        /// 메인 버튼 중 "앱 가이드" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn1_Click(object sender, RoutedEventArgs e)
        {
            /*Body.Child = dashboard;*/
        }

        /// <summary>
        /// 메인 버튼 중 "알림 대시보드" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn2_Click(object sender, RoutedEventArgs e)
        {
            /*Body.Child = dashboard;*/
        }

        /// <summary>
        /// 메인 버튼 중 "PC 사용 분석" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn3_Click(object sender, RoutedEventArgs e)
        {
            /*Body.Child = dashboard;*/
        }
    }
}
