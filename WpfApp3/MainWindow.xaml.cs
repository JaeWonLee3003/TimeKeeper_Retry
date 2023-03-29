using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            StartApp(); // 이 App 을 실행 했을 때 첫번째로 실행 되는 함수 
        }

        /// <summary>
        /// TimeKeeper 앱을 켠 시간을 값을 저장하는 클래스
        /// </summary>
        public class StartTime
        {

            // 시,분,초 를 입력 받을 변수들을 전역 변수로 선언 한다.            
            public int SetStartHour, SetStartMin, SetStartSec;

            /// <summary>
            /// 시작 시 SetStartTime 메서드를 사용하여 각 값마다 시,분,초 를 입력 받는다.
            /// </summary>
            public void SetStartTime()
            {
                SetStartHour = int.Parse(DateTime.Now.ToString("HH"));
                SetStartMin = int.Parse(DateTime.Now.ToString("mm"));
                SetStartSec = int.Parse(DateTime.Now.ToString("ss"));
            }

        }
        /// <summary>
        /// TimeKeeper 앱 실행 시 시작 되는 메인 메서드
        /// </summary>
        public void StartApp()
        {
            StartTime startTime = new StartTime();
            startTime.SetStartTime();
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
            WpfApp3.Third_Content Main_Btn3_Click = new WpfApp3.Third_Content();
            Main_Btn3_Click.ShowDialog(); // 창을 닫기전에 이전 앱을 닫지 못함.
        }
    }
}
