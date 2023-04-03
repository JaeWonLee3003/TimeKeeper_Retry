using System;
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
using static WpfApp3.MainWindow;

namespace WpfApp3
{
    /// <summary>
    /// Third_Content.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class Third_Content : Window
    {

        private int startHour;
        private int startMin;
        private int startSec;

        public Third_Content(int setStartHour, int setStartMin, int setStartSec)
        {
            InitializeComponent();
            startHour = setStartHour;
            startMin = setStartMin;
            startSec = setStartSec;
            init();
        }

        public class SerchTime
        {
            // 처음 입력한 시간과 비교할 현재의 시,분,초 를 입력 받을 변수들을 전역 변수로 선언 한다.            
            public int SetSerchHour = DateTime.Now.Hour;
            public int SetSerchMin = DateTime.Now.Minute;
            public int SetSerchSec = DateTime.Now.Second;

            public void CalculateElapsed(int startHour, int startMin, int startSec)
            {
                // 시작 시 분 초 에서 현재 시 분 초를 뺀다.
                int ResultHour = SetSerchHour - startHour;
                int ResultMin = SetSerchMin - startMin;
                int ResultSec = SetSerchSec - startSec;


            }
        }

        public void init()
        {
            SerchTime serchTime = new SerchTime();

            // 시작 시 분 초 에서 현재 시 분 초를 뺀다.
            // 10 : 43 : 10
            // 10 : 43 : 20
            int ResultHour = serchTime.SetSerchHour - startHour;
            int ResultMin = serchTime.SetSerchMin - startMin;
            int ResultSec = serchTime.SetSerchSec - startSec;

            // 시작 시간
            PcPlusTime.Text = startHour.ToString();
            PcPlusTime2.Text = startMin.ToString();
            PcPlusTime3.Text = startSec.ToString();
            // 현재 시간
            PcPlusTime11.Text = serchTime.SetSerchHour.ToString();
            PcPlusTime22.Text = serchTime.SetSerchMin.ToString();
            PcPlusTime33.Text = serchTime.SetSerchSec.ToString();
        }
    }
}