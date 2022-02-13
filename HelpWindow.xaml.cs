using System;
using System.Windows;

namespace ElementPeriodTable
{
    /// <summary>
    /// HelpWindow.xaml 的交互逻辑
    /// </summary>
    public partial class HelpWindow : Window
    {
        public HelpWindow()
        {
            InitializeComponent();
        }
        private void SetFontSize()
        {
            this.FontSize = this.ActualHeight / 30;
        }

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
            SetFontSize();
        }

        private void window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            SetFontSize();
        }

        private void WV2_Initialized(object sender, EventArgs e)
        {
            WV2.Source = new Uri(Properties.Settings.Default.URL);
        }
    }
}
