﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Collections.Generic;


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

        private DateTime startTime;

        private Grid dashboard; // dashboard 필드 추가

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
            textBlock.Margin = new Thickness(20, 20, 0, 0);
            textBlock.VerticalAlignment = VerticalAlignment.Top;
            textBlock.HorizontalAlignment = HorizontalAlignment.Left;
            dashboard.Children.Add(textBlock);

            // 그리드에 리스트박스 추가
            var listBox = new ListBox();
            listBox.Margin = new Thickness(10, 60, 20, 20);
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
            var dashboard = new Grid();

            // 그리드에 텍스트블록 추가
            var textBlock = new TextBlock();
            textBlock.Text = "PC 사용 분석";
            textBlock.FontSize = 20;
            textBlock.Margin = new Thickness(20, 20, 0, 0);
            textBlock.VerticalAlignment = VerticalAlignment.Top;
            textBlock.HorizontalAlignment = HorizontalAlignment.Left;
            dashboard.Children.Add(textBlock);

            // 알림 목록 생성
            var listView = new ListView();
            listView.Margin = new Thickness(20, 60, 20, 20);
            dashboard.Children.Add(listView);

            // 알림 목록 아이템 추가
            listView.Items.Add("알림 1");
            listView.Items.Add("알림 2");
            listView.Items.Add("알림 3");

            // 시간확인하기 버튼 생성
            var checkTimeButton = new Button();
            checkTimeButton.Content = "시간확인하기";
            checkTimeButton.Margin = new Thickness(20, 180, 0, 0);
            checkTimeButton.Click += (sender, e) =>
            {
                TimeSpan pcUsageTime = DateTime.Now - startTime;
                MessageBox.Show($"PC 사용 시간: {pcUsageTime.Hours}시간 {pcUsageTime.Minutes}분 {pcUsageTime.Seconds}초");
            };
            dashboard.Children.Add(checkTimeButton);

            // Border에 그리드 추가
            if (Body != null)
            {
                Body.Child = dashboard;
            }
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
            //WpfApp3.Second_Content Main_Btn2_Click = new WpfApp3.Second_Content();
            //Main_Btn2_Click.ShowDialog(); // 창을 닫기전에 이전 앱을 닫지 못함.
        }

        /// <summary>
        /// 메인 버튼 중 "PC 사용 분석" 창으로 넘어가는 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Main_Btn3_Click(object sender, RoutedEventArgs e)
        {


            CreatePCtime(startTime = DateTime.Now;);
            Body.Child = dashboard;
            //WpfApp3.Third_Content Main_Btn3_Click = new WpfApp3.Third_Content(setStartHour, setStartMin, setStartSec);
            //Main_Btn3_Click.ShowDialog(); // 창을 닫기전에 이전 앱을 닫지 못함.

        }
    }
}
