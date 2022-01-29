using System;
using System.Collections.Generic;
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
            timer = new System.Windows.Threading.DispatcherTimer();
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Interval = TimeSpan.FromSeconds(1);

            foreach (var btn in MainGrid.Children)
            {
                if (btn is Button) btns.Add((Button)btn);
            }
            RefreshContents();
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
            string elementname="";
            Random rnd = new ();
            switch(Properties.Settings.Default.Level)
            {
                case 0 or 1:
                    switch(rnd.Next (2))
                    {
                        case 0:
                            elementname = btns[rnd.Next(0, 57)].Tag.ToString().Split(",")[rnd.Next(2)];
                            break;
                        case 1:
                            elementname = btns[rnd.Next(71, 89)].Tag.ToString().Split(",")[rnd.Next(2)];
                            break;
                        default:
                            break;
                    }
                    break;
                case 2 or 3:
                    elementname = btns[rnd.Next(120)].Tag.ToString().Split(",")[rnd.Next(2)];

                    break;
                case 4:
                    switch (rnd.Next(4))
                    {
                        case 0:
                            elementname = btns[rnd.Next(120)].Tag.ToString().Split(",")[rnd.Next(2)];
                            break;
                        case 1:
                            elementname = btns[rnd.Next(118)].Tag.ToString().Split(",")[2];

                            break;
                        default:
                            break;

                    }

                    break;
                default:break;
            }
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
                timer.Stop();
                MessageBox.Show("超时未答题，积分-10\n以后手速要快哦","超时未答");
                Properties.Settings.Default.Score -= 10;
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
            timer.Start();


            Button btn = (Button)sender;

            if (btn.Tag.ToString().Split(",")[0]==ElementNameBar.Content.ToString() || btn.Tag.ToString().Split(",")[1] == ElementNameBar.Content.ToString() || btn.Tag.ToString().Split(",")[2] == ElementNameBar.Content.ToString())
            {
                
                Properties.Settings.Default.Score += 10;
                MessageBox.Show("恭喜你，答对了，积分+10!\n又记住了一个元素！", "回答正确");
                switch (Properties.Settings.Default.Score)
                {
                    case 10 or 20:
                        MessageBox.Show("恭喜！你已晋级LV1，获得“努力向前”称号！\n当前等级每题限时25s\n测试范围：基础区（所有镧系、锕系以外的非人造元素）", "晋级提醒");
                        break;
                    case 100 or 110:
                        MessageBox.Show("恭喜！你已晋级LV2，获得“小有成就”称号！\n当前等级每题限时20s\n测试范围：全表", "晋级提醒");
                        break;
                    case 1000 or 1010:
                        MessageBox.Show("恭喜！你已晋级LV3，获得“聪明绝顶”称号！\n当前等级每题限时15s\n测试范围：全表", "晋级提醒");
                        break;
                    case 10000 or 10010:
                        MessageBox.Show("恭喜！你已晋级最高等级LV4，获得“顶级大师”称号！\n当前等级每题限时10s\n解锁原子量测试", "晋级提醒");
                        break;
                    default: break;
                }
            }
            else
            {
                Properties.Settings.Default.Score -= 20;
                MessageBox.Show("很遗憾，答错了，积分-20!\n以后要多加巩固啊！", "回答错误");
                switch (Properties.Settings.Default.Score)
                {
                    case  0 or 80 or 90 or 980 or 990 or 9980 or 9990:
                        MessageBox.Show("糟糕！掉级了\n要继续努力哦", "掉级提醒");
                           break;
                    default: break;
                }
            }

            if (Properties.Settings.Default.Score<0)
            {
                MessageBox.Show("积分扣光了，再来一局吧","游戏结束");
                Properties.Settings.Default.Score = 0;
                Properties.Settings.Default.Level = 0;
            }


            RefreshContents();
            FillBtns();
            NewGame();
        }





        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            btn.Content = ElementNameBar.Content;
        }

        private void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            FillBtns();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetFontSize();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            SetFontSize();
            GetNewElement();
            FillBtns();
            switch (Properties.Settings.Default.Level)
            {
                case 0:
                    timeleft = 30;
                    timeleftProgressBar.Maximum = 30;
                    timeleftProgressBar.Value = 30;
                    break;
                case 1:
                    timeleft = 25;
                    timeleftProgressBar.Maximum = 25;
                    timeleftProgressBar.Value = 25;
                    break;
                case 2:
                    timeleft = 20;
                    timeleftProgressBar.Maximum = 20;
                    timeleftProgressBar.Value = 20;
                    break;
                case 3:
                    timeleft = 15;
                    timeleftProgressBar.Maximum = 15;
                    timeleftProgressBar.Value = 15;
                    break;
                case 4:
                    timeleft = 10;
                    timeleftProgressBar.Maximum = 10;
                    timeleftProgressBar.Value = 10;
                    break;
                default:
                    break;
            }

            timer.Start();
        }



        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (MessageBox.Show("重置游戏会导致等级和积分清零哦\n确定要重置吗？", "重置确认", button: MessageBoxButton.OKCancel) == MessageBoxResult.OK)
            {
                Properties.Settings.Default.Score = 0;
                Properties.Settings.Default.Level = 0;
                lvLabel.Content = "🏆" + Properties.Settings.Default.Level.ToString();
                scrLabel.Content = "💎" + Properties.Settings.Default.Score.ToString();
            }
            else { }
        }

        private void window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            Properties.Settings.Default.Save();
            if (MessageBox.Show("关闭程序后等级和积分会自动保存\n确定要关闭吗？", "关闭确认", button: MessageBoxButton.OKCancel) == MessageBoxResult.OK) { }
            else { e.Cancel = true; }
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            timer.Stop();
            new HelpWindow().ShowDialog();
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
        }

    }
}