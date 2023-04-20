using System;
using System.Windows;

namespace WpfApp3
{
    public partial class Third_Content : Window
    {
        public class SerchTime
        {
            public int SetSerchHour { get; } = DateTime.Now.Hour;
            public int SetSerchMin { get; } = DateTime.Now.Minute;
            public int SetSerchSec { get; } = DateTime.Now.Second;
        }

        private int startHour;
        private int startMin;
        private int startSec;

        public Third_Content(int setStartHour, int setStartMin, int setStartSec)
        {
            InitializeComponent();
            startHour = setStartHour;
            startMin = setStartMin;
            startSec = setStartSec;
            init(new SerchTime());
        }

        public void init(SerchTime serchTime)
        {
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