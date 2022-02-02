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
            this.FontSize = this.ActualHeight / 40;
        }

        private void window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.FontSize = this.ActualHeight / 40;
        }


    }
}
