using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ElementPeriodTable
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        System.Windows.Threading.DispatcherTimer timer;
        int timeleft = 0;
        List<Button> btns = new();
        public MainWindow()
        {
            InitializeComponent();
            //Properties.Settings.Default.Reset();
            Properties.Settings.Default.Reload();
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(1);

            foreach (var btn in MainGrid.Children)
            {
                if (btn is Button) btns.Add((Button)btn);
            }
        }
        private void RefreshContents()
        {
            switch (Properties.Settings.Default.Score)
            {
                case >= 0 and < 10:
                    ScoreProgressBar.Value = Properties.Settings.Default.Score * 1000;
                    Properties.Settings.Default.Level = 0;
                    lvLabel.Content = "🏆0|默默无闻";
                    break;
                case >= 10 and < 100:
                    ScoreProgressBar.Value = Properties.Settings.Default.Score * 100;
                    Properties.Settings.Default.Level = 1;
                    lvLabel.Content = "🏆1|努力向前";
                    break;
                case >= 100 and < 1000:
                    ScoreProgressBar.Value = Properties.Settings.Default.Score * 10;
                    Properties.Settings.Default.Level = 1;
                    lvLabel.Content = "🏆2|小有成就";
                    break;
                case >= 1000 and < 10000:
                    ScoreProgressBar.Value = Properties.Settings.Default.Score;
                    Properties.Settings.Default.Level = 2;
                    lvLabel.Content = "🏆3|聪明绝顶";
                    break;
                case >= 10000:
                    ScoreProgressBar.Value = 10000;
                    Properties.Settings.Default.Level = 3;
                    lvLabel.Content = "🏆4|顶级大师";
                    break;
                default:
                    break;
            }

            scrLabel.Content = "💎" + Properties.Settings.Default.Score.ToString();
        }
        private void GetNewElement()
        {
            string elementname = "Unknown";
            Random rnd = new();
            List<string> selected = new();
            List<Button> selected_btns = new();
            if (Properties.Settings.Default.Selected.Contains(','))
            {
                foreach (string str in Properties.Settings.Default.Selected.Split(","))
                {
                    selected.Add(str);
                }
            }
            else
            {
                selected.Add(Properties.Settings.Default.Selected);
            }
            foreach (string str in selected)
            {
                if (str.Contains('-'))
                {
                    for (int i = Convert.ToInt32(str.Split("-")[0].ToString()) - 1; i < Convert.ToInt32(str.Split("-")[1].ToString()); i++)
                    {
                        selected_btns.Add(btns[i]);
                    }

                }
                else
                {
                    selected_btns.Add(btns[Convert.ToInt32(str) - 1]);
                }
            }
            if (Properties.Settings.Default.Level == 4) elementname = selected_btns[rnd.Next(selected_btns.Count)].Tag.ToString().Split(",")[rnd.Next(3)];
            else elementname = selected_btns[rnd.Next(selected_btns.Count)].Tag.ToString().Split(",")[rnd.Next(2)];
            
            ElementNameBar.Content = elementname;

        }
        private void FillBtns()
        {
            for (int i=0;i<118;i++) 
            {
                btns[i].Content=(i+1).ToString();
            }
            btns[118].Content = "57~71";
            btns[119].Content = "89~103";
        }
        private void NewGame()
        {
            FillBtns();
            GetNewElement();
            switch (Properties.Settings.Default.Level)
            {
                case 0:
                    timeleft = 30;
                    timeleftProgressBar.Maximum = 30;
                    break;
                case 1:
                    timeleft = 25;
                    timeleftProgressBar.Maximum = 25;
                    break;
                case 2:
                    timeleft = 20;
                    timeleftProgressBar.Maximum = 20;
                    break;
                case 3:
                    timeleft = 15;
                    timeleftProgressBar.Maximum = 15;
                    break;
                case 4:
                    timeleft = 10;
                    timeleftProgressBar.Maximum = 10;
                    break;
                default:
                    break;
            }
            timer.Start();

        }
        private void SetFontSize()
        {
            this.FontSize = this.ActualHeight / 40;
            ElementNameBar.FontSize = this.FontSize * 4;
        }
        private void Timer_Tick(object? sender, EventArgs e)
        {
            timeleftProgressBar.Value = timeleft;
            timeleftLable.Content = "时间还剩" + timeleft.ToString() + "s";

            if (timeleft == 0)
            {
                Button rightBtn = new();
                timer.Stop();
                foreach (Button button in btns)
                {
                    if (button.Tag.ToString().Split(",")[0] == ElementNameBar.Content.ToString() || button.Tag.ToString().Split(",")[1] == ElementNameBar.Content.ToString() || button.Tag.ToString().Split(",")[2] == ElementNameBar.Content.ToString()) rightBtn = button;
                }
                MessageBox.Show("超时未答题\n以后手速要快啊！\n"+ElementNameBar.Content.ToString()+"是"+rightBtn.Content.ToString()+"号元素", "超时未答");
                NewGame();
            }
            else
            {
                timeleft--;
            }
            RefreshContents();
            
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {

            timer.Stop();
            Button btn = (Button)sender;

            if (btn.Tag.ToString().Split(",")[0]==ElementNameBar.Content.ToString() || btn.Tag.ToString().Split(",")[1] == ElementNameBar.Content.ToString() || btn.Tag.ToString().Split(",")[2] == ElementNameBar.Content.ToString())
            {
                
                Properties.Settings.Default.Score += 10;
                MessageBox.Show("恭喜你，答对了，积分+10!\n又记住了一个元素！", "回答正确");
                switch (Properties.Settings.Default.Score)
                {
                    case 10:
                        MessageBox.Show("恭喜！你已晋级LV1，获得“努力向前”称号！\n当前等级每题限时25s", "晋级提醒");
                        break;
                    case 100:
                        MessageBox.Show("恭喜！你已晋级LV2，获得“小有成就”称号！\n当前等级每题限时20s", "晋级提醒");
                        break;
                    case 1000:
                        MessageBox.Show("恭喜！你已晋级LV3，获得“聪明绝顶”称号！\n当前等级每题限时15s", "晋级提醒");
                        break;
                    case 10000:
                        MessageBox.Show("恭喜！你已晋级最高等级LV4，获得“顶级大师”称号！\n当前等级每题限时10s\n你解锁了原子量测试", "晋级提醒");
                        break;
                    default: break;
                }
            }
            else
            {
                Button rightBtn = new();
            foreach (Button button in  btns)
                {
                    if (button.Tag.ToString().Split(",")[0] == ElementNameBar.Content.ToString() || button.Tag.ToString().Split(",")[1] == ElementNameBar.Content.ToString() || button.Tag.ToString().Split(",")[2] == ElementNameBar.Content.ToString()) rightBtn=button ;
                }
            MessageBox.Show("很遗憾，答错了\n以后要多加巩固啊！\n" + ElementNameBar.Content.ToString() + "是" + rightBtn.Content.ToString() + "号元素", "回答错误");
                
            }


            RefreshContents();
            NewGame();
        }





        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
        }

        private void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetFontSize();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            RefreshContents();
            SetFontSize();
            FillBtns();
            NewGame();
        }



        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("重置游戏会导致等级和积分清零哦\n确定要重置吗？", "重置确认", button: MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                timer.Stop();
                Properties.Settings.Default.Reset();                lvLabel.Content = "🏆0|默默无闻";
                scrLabel.Content = "💎0";
                NewGame();
            }
            
        }

        private void window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
            if (!(MessageBox.Show("关闭程序后测试范围、等级和积分会自动保存\n确定要关闭吗？", "关闭确认", button: MessageBoxButton.OKCancel) == MessageBoxResult.OK)) e.Cancel = true; 
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            Process.Start("explorer.exe", "https://shiningyangyxn.github.io/ElementPeriodTable/");
            timer.Start();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            new AboutWindow().ShowDialog();
            timer.Start();

        }

        private void LearnButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            this.Hide();
            new LearnWindow().ShowDialog();
            this.Show();
            timer.Start();
        }

        private void Btn_RhtClick(object sender, MouseButtonEventArgs e)
        {
            Button btn = (Button)sender;
            MessageBox.Show("元素符号："+btn.Tag.ToString().Split(",")[0]+ "\n原子序数：" + btn.Content+ "\n中文名：" + btn.Tag.ToString().Split(",")[1]+ "\n原子量：" + btn.Tag.ToString().Split(",")[2], "翻开提示");
        }

        private void SelectButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            new SelectWindow().ShowDialog();
            timer.Start();
        }
    }
}