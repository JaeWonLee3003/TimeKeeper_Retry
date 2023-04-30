using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
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
            startTime = DateTime.Now;

           
        }

        /// <summary>
        /// 앱 가이드를 구현해주는 메서드
        /// </summary>
        private void CreateAppGuide()
        {
            // 그리드 생성
            dashboard = new Grid();

            // 그리드에 텍스트블럭 추가
            var textBlock = new TextBlock();
            textBlock.Text = "앱 가이드";
            textBlock.FontSize = 20;
            textBlock.Margin = new Thickness(20, 40, 0, 0);
            textBlock.VerticalAlignment = VerticalAlignment.Top;
            textBlock.HorizontalAlignment = HorizontalAlignment.Left;
            dashboard.Children.Add(textBlock);

            // 그리드에 리스트박스 추가
            var listBox = new ListBox();
            listBox.Margin = new Thickness(0, 80, 0, 0);
            // listBox.ItemsSource = notificationList; // notificationList는 알림 목록 리스트입니다.
            dashboard.Children.Add(listBox);

            // Border에 그리드 추가
            if (Body != null)
            {
                Body.Child = dashboard;
            }
        }

        /// <summary>
        /// 알림 대시보드를 구현해주는 메서드
        /// </summary>
        private void CreateDashboard()
        {
            // 그리드 생성
            dashboard = new Grid();

            // 그리드에 텍스트블럭 추가
            var textBlock = new TextBlock();
            textBlock.Text = "알림 대시보드";
            textBlock.FontSize = 20;
            textBlock.Margin = new Thickness(20, 40, 0, 0);
            textBlock.VerticalAlignment = VerticalAlignment.Top;
            textBlock.HorizontalAlignment = HorizontalAlignment.Left;
            dashboard.Children.Add(textBlock);

            // 그리드에 리스트박스 추가
            var listBox = new ListBox();
            listBox.Margin = new Thickness(0, 80, 0, 0);
            // listBox.ItemsSource = notificationList; // notificationList는 알림 목록 리스트입니다.
            dashboard.Children.Add(listBox);

            // Border에 그리드 추가
            if (Body != null)
            {
                Body.Child = dashboard;
            }
        }

        /// <summary>
        /// PC 사용 시간을 구현해주는 메서드
        /// </summary>
        private void CreatePCtime(DateTime startTime)
        {
            // 그리드 생성
            dashboard = new Grid();

            // 그리드에 이미지 추가
            var image = new Image();
            image.Source = new BitmapImage(new Uri("C:\\Users\\mycom\\Source\\Repos\\JaeWonLee3003\\TimeKeeper_Retry\\WpfApp3\\Images\\PcHelp.png", UriKind.Absolute));
            image.Margin = new Thickness(20, 80, 0, 0);
            image.VerticalAlignment = VerticalAlignment.Top;
            image.HorizontalAlignment = HorizontalAlignment.Left;
            dashboard.Children.Add(image);

            // 그리드에 텍스트블럭 추가
            var textBlock = new TextBlock();
            textBlock.Text = "PC 사용 시간";
            textBlock.FontSize = 20;
            textBlock.Margin = new Thickness(20, 40, 0, 0);
            textBlock.VerticalAlignment = VerticalAlignment.Top;
            textBlock.HorizontalAlignment = HorizontalAlignment.Left;
            dashboard.Children.Add(textBlock);

            // 그리드에 리스트박스 추가
            var listBox = new ListBox();
            listBox.Margin = new Thickness(0, 80, 0, 0);
            dashboard.Children.Add(listBox);

            // Border에 그리드 추가
            if (Body != null)
            {
                Body.Child = dashboard;
            }

            // PC 사용 시간을 주기적으로 업데이트하고 리스트 박스에 추가하는 타이머 생성
            var timer = new System.Windows.Threading.DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += (sender, e) =>
            {
                // PC 사용 시간을 구합니다.
                TimeSpan pcTime = DateTime.Now.Subtract(startTime);

                // 사용 시간을 텍스트 형식으로 변환합니다.
                string pcTimeText = "PC 사용 시간: " + pcTime.ToString(@"hh\:mm\:ss");

                // 리스트 박스에 사용 시간을 추가합니다.
                listBox.Items.Clear(); // 리스트 박스를 초기화합니다.
                listBox.Items.Add(pcTimeText); // 사용 시간을 리스트 박스에 추가합니다.
            };

            // 타이머 시작
            timer.Start();
        }


        /// <summary>
        /// 메인 버튼 중 "앱 가이드" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn1_Click(object sender, RoutedEventArgs e)
        {
            CreateAppGuide();
            Body.Child = dashboard;
        }

        /// <summary>
        /// 메인 버튼 중 "알림 대시보드" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn2_Click(object sender, RoutedEventArgs e)
        {
            CreateDashboard();
            Body.Child = dashboard;
        }

        /// <summary>
        /// 메인 버튼 중 "PC 사용 분석" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn3_Click(object sender, RoutedEventArgs e)
        {
            CreatePCtime(startTime);
            Body.Child = dashboard;
        }
    }
}
