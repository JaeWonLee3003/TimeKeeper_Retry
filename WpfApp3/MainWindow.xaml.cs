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

        }

        public void HandleAlarmButtonClick()
        {
            AddAlramPopup();
        }
        public void AddAlramPopup()
        {
            AddAlramPopup addAlramPopup = new AddAlramPopup();
            EffectPanel.Children.Clear();
            EffectPanel.Children.Add(addAlramPopup);
        }
    }
}
