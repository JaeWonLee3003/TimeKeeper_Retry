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
            public int SetSerchHour, SetSerchMin, SetSerchSec;

            /// <summary>
            /// 시작 시 SetStartTime 메서드를 사용하여 각 값마다 시,분,초 를 입력 받는다.
            /// </summary>
            public void SetSerchTime()
            {
                SetSerchHour = int.Parse(DateTime.Now.ToString("HH"));
                SetSerchMin = int.Parse(DateTime.Now.ToString("mm"));
                SetSerchSec = int.Parse(DateTime.Now.ToString("ss"));
            }

        }

        public static void init()
        {

            SerchTime serchTime = new SerchTime();
            StartTime startTime = new StartTime();

            serchTime.SetSerchTime();

            // 시작 시 분 초 에서 현재 시 분 초를 뺀다.
            // 10 : 43 : 10
            // 10 : 43 : 20
            int ResultHour = serchTime.SetSerchHour - startTime.SetStartHour;
            Console.WriteLine(startTime.SetStartHour);
            int ResultMin = serchTime.SetSerchMin - startTime.SetStartMin;
            Console.WriteLine(startTime.SetStartMin);
            int ResultSec = serchTime.SetSerchSec - startTime.SetStartSec;
            Console.WriteLine(startTime.SetStartSec);


            // 
            if (ResultSec < 0)
            {
                ResultMin -= 1;
                if(ResultMin < 0)
                {
                    ResultHour -= 1;
                    if(ResultHour < 0)
                    {
                        ResultHour -= 1;
                    }
                }
            }



        }
    }
}
