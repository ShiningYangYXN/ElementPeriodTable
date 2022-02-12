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
        private bool Check(string CheckText)
        {
            List<string> list=new();
            try
            {
                if (!string.IsNullOrEmpty(CheckText))
                {
                    if (CheckText.Contains(','))
                    {
                        foreach (string s in CheckText.Split(","))
                        {
                            list.Add(s);
                        }
                    }
                    else list.Add(CheckText);

                    foreach (string s in list)
                    {
                        if (!s.Contains("-") && Convert.ToInt32(s) >= 1 && Convert.ToInt32(s) <= 120) return true;
                        else if (s.Contains("-") && s.Split("-").Length == 2 && Convert.ToInt32(s.Split("-")[0]) >= 1 && Convert.ToInt32(s.Split("-")[0]) <= 120 && Convert.ToInt32(s.Split("-")[1]) >= 1 && Convert.ToInt32(s.Split("-")[1]) <= 120&& Convert.ToInt32(s.Split("-")[0])< Convert.ToInt32(s.Split("-")[1])) return true;
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
            else MessageBox.Show("请检查你的输入，只能包含1~120的数字、英文“-”和“,”","错误");
        }


        private void window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetFontSize();
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            SetFontSize();
        }
    }
}
