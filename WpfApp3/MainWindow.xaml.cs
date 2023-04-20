using System;
using System.Windows;


namespace WpfApp3
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int setStartHour;
        private int setStartMin;
        private int setStartSec;

        public MainWindow()
        {
            InitializeComponent();
            StartApp();

        }

        public void StartApp()
        {
            setStartHour = DateTime.Now.Hour;
            setStartMin = DateTime.Now.Minute;
            setStartSec = DateTime.Now.Second;
        }


        /// <summary>
        /// 메인 버튼 중 "앱 가이드" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn1_Click(object sender, RoutedEventArgs e)
        {
            WpfApp3.First_Content Main_Btn1_Click = new WpfApp3.First_Content();
            Main_Btn1_Click.ShowDialog(); // 창을 닫기전에 이전 앱을 닫지 못함.
        }

        /// <summary>
        /// 메인 버튼 중 "알림 대시보드" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn2_Click(object sender, RoutedEventArgs e)
        {
            WpfApp3.Second_Content Main_Btn2_Click = new WpfApp3.Second_Content();
            Main_Btn2_Click.ShowDialog(); // 창을 닫기전에 이전 앱을 닫지 못함.
        }

        /// <summary>
        /// 메인 버튼 중 "PC 사용 분석" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn3_Click(object sender, RoutedEventArgs e)
        {
            WpfApp3.Third_Content Main_Btn3_Click = new WpfApp3.Third_Content(setStartHour, setStartMin, setStartSec);
            Main_Btn3_Click.ShowDialog(); // 창을 닫기전에 이전 앱을 닫지 못함.

        }
    }
}
