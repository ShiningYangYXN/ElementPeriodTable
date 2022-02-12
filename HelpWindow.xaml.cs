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

        private void window_Loaded(object sender, RoutedEventArgs e)
        {
        }

        private void window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
        }

        private void WV2_Initialized(object sender, EventArgs e)
        {
            WV2.Source = new Uri(Properties.Settings.Default.URL);
        }
    }
}
