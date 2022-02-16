using System.Collections.Generic;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace ElementPeriodTable
{
    /// <summary>
    /// LearnWindow.xaml 的交互逻辑
    /// </summary>
    public partial class LearnWindow : Window
    {
        List<Button> btns = new();
        public LearnWindow()
        {
            InitializeComponent();
            foreach (var btn in MainGrid.Children)
            {
                if (btn is Button) btns.Add((Button)btn);
            }

        }
        private void FillBtns()
        {
            for (int i = 0; i < 118; i++)
            {
                btns[i].Content = (i + 1).ToString();
            }
            btns[118].Content = "57~71";
            btns[119].Content = "89~103";
        }
        private void SetFontSize()
        {
            this.FontSize = this.ActualHeight / 40;
            ElementNameBar.FontSize = this.FontSize * 4;
        }
        private void Btn_MouseEnter(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            ElementNameBar.Content=btn.Tag.ToString().Split(",")[0];
            SNLable.Content = "原子序数："+btn.Content;
            ChNameLable.Content = "中文名：" + btn.Tag.ToString().Split(",")[1];
            MassLable.Content = "原子量：" + btn.Tag.ToString().Split(",")[2];

        }

        private void Btn_MouseLeave(object sender, MouseEventArgs e)
        {
            FillBtns();
        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetFontSize();
        }

        private void AboutButton_Click(object sender, RoutedEventArgs e)
        {
            new AboutWindow().ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            FillBtns();
            SetFontSize();
        }

        private void HelpButton_Click(object sender, RoutedEventArgs e)
        {
            Process.Start("explorer.exe", "https://shiningyangyxn.github.io/ElementPeriodTable/");
        }

        private void ReturnButton_Click(object sender, RoutedEventArgs e)
        {
            
            this.Close();
        }

        private void Btn_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;

            MessageBox.Show("元素符号："+btn.Tag.ToString().Split(",")[0]+ "\n原子序数：" + btn.Content+ "\n中文名：" + btn.Tag.ToString().Split(",")[1]+ "\n原子量：" + btn.Tag.ToString().Split(",")[2], "元素介绍",MessageBoxButton.OK,MessageBoxImage.Information);
        }

        private void Btn_RhtClick(object sender, MouseButtonEventArgs e)
        {

        }
    }
}
