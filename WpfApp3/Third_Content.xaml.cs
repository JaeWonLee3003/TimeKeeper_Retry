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
        public Third_Content()
        {
            InitializeComponent();
            init();
        }

        public class SerchTime
        {
            // 처음 입력한 시간과 비교할 현재의 시,분,초 를 입력 받을 변수들을 전역 변수로 선언 한다.            
            public int SetSerchHour = int.Parse(DateTime.Now.ToString("HH"));
            public int SetSerchMin = int.Parse(DateTime.Now.ToString("mm"));
            public int SetSerchSec = int.Parse(DateTime.Now.ToString("ss"));
        }
        public void init()
        {
            SerchTime serchTime = new SerchTime();

            // 시작 시 분 초 에서 현재 시 분 초를 뺀다.
            // 10 : 43 : 10
            // 10 : 43 : 20
            /*int ResultHour = serchTime.SetSerchHour - setTime.SetStartHour;
            int ResultMin = serchTime.SetSerchMin - setTime.SetStartMin;
            int ResultSec = serchTime.SetSerchSec - setTime.SetStartSec;

            // 시작 시간
            PcPlusTime.Text = setTime.SetStartHour.ToString();
            PcPlusTime2.Text = setTime.SetStartMin.ToString();
            PcPlusTime3.Text = setTime.SetStartSec.ToString();
            // 현재 시간
            PcPlusTime11.Text = serchTime.SetSerchHour.ToString();
            PcPlusTime22.Text = serchTime.SetSerchMin.ToString();
            PcPlusTime33.Text = serchTime.SetSerchSec.ToString();*/
        }

        
    }
}
