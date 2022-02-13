using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace ElementPeriodTable
{
    /// <summary>
    /// SelectWindow.xaml 的交互逻辑
    /// </summary>
    public partial class SelectWindow : Window
    {
        public SelectWindow()
        {
            InitializeComponent();
        }
        private void SetFontSize()
        {
            this.FontSize = this.ActualHeight / 15;
        }
        private int CountChar(char chr,string str)
        {
            int count=0;
            foreach(char c in str)
            {
                if (c == chr) count++;
            }
            return count;

        }
        private bool Check(string CheckText)
        {
            List<string> list=new();
            try
            {
                if (!string.IsNullOrWhiteSpace(CheckText))
                {
                    if (CheckText.Contains(','))
                    {
                        foreach (string s in CheckText.Split(","))
                        {
                            if ((!String.IsNullOrWhiteSpace(s)) && (CountChar('-', s) == 1|| CountChar('-', s) == 0) &&s[0]!='-') list.Add(s);
                            else return false;

                        }
                    }
                    else if (CheckText.Contains(' ')|| CountChar('-', CheckText) > 1 || CheckText[0] == '-') return false;
                    else list.Add(CheckText);

                    foreach (string s in list)
                    {
                        if ((!s.Contains('-')) && Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 120) return true;
                        else if (s.Contains('-') && s.Split("-").Length == 2 && Convert.ToInt32(s.Split("-")[0]) >= 1 && Convert.ToInt32(s.Split("-")[0]) <= 120 && Convert.ToInt32(s.Split("-")[1]) >= 1 && Convert.ToInt32(s.Split("-")[1]) <= 120&& Convert.ToInt32(s.Split("-")[0])< Convert.ToInt32(s.Split("-")[1])) return true;
                        else return false;
                    }
                    return false;
                }
                else return false;
            }
            catch
            {
                return false;
            }
        }
        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            if (Check(InputBox.Text) == true)
            {
                Properties.Settings.Default.Selected = InputBox.Text;
                this.Close();
            }
            else MessageBox.Show("请检查你的输入，只能包含1~120的数字、英文“-”和“,”，“-”左侧的数字必须比右侧小，一个范围内只能包含一个“-”，两个“,”间必须有内容","无效输入");
        }


        private void window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetFontSize();
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            SetFontSize();
        }

        private void InputBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter) SubmitButton_Click(sender, e);
        }
    }
}
