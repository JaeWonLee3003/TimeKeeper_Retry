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

namespace WpfApp3.SideDisplay
{
    /// <summary>
    /// AlarmDashBoard.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AlramDashBoard : UserControl
    {

        public AlramDashBoard()
        {
            InitializeComponent();
            AddAlarmButton.Click += AddAlramPopup;
        }

        SideDisplay.AddAlramPopup addAlramPopup;

        private void AddAlramPopup(object sender, RoutedEventArgs e)
        {
            addAlramPopup = new SideDisplay.AddAlramPopup();
        }
    }
}
