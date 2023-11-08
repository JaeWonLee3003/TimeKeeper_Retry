using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;
using System.Windows.Media.Imaging;
using WpfApp3.SideDisplay;

namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
            /*this.Loaded += MainWindow_Loaded;*/

            Main_Btn1.Click += ShowScreen;
            Main_Btn2.Click += ShowScreen;
            Main_Btn3.Click += ShowScreen;
            Main_Btn4.Click += ShowScreen;

        }


        private void ShowScreen(object sender, RoutedEventArgs e)
        {

            HIdeScreen();

            switch(sender.ToString())
            {
                case "System.Windows.Controls.Button: 앱 가이드":
                    AppGuide.Visibility = Visibility.Visible;                
                    break;
                case "System.Windows.Controls.Button: 알림 대시보드":
                    AlramDashBoadrd.Visibility = Visibility.Visible;
                    break;
                case "System.Windows.Controls.Button: PC 사용 정보":
                    PCUseInfo.Visibility = Visibility.Visible;
                    break;
                case "System.Windows.Controls.Button: 설정":
                    Setting.Visibility = Visibility.Visible;
                    break;
            }
        }

        private void HIdeScreen()
        {
            AppGuide.Visibility = Visibility.Collapsed;
            AlramDashBoadrd.Visibility = Visibility.Collapsed;
            PCUseInfo.Visibility = Visibility.Collapsed;
            Setting.Visibility = Visibility.Collapsed;
        }
    }
}
