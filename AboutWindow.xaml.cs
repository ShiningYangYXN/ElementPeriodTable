using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;

namespace ElementPeriodTable
{
    /// <summary>
    /// AboutWindow.xaml 的交互逻辑
    /// </summary>
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            this.FontSize = this.ActualHeight / 20;

        }

        private void Window_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            this.FontSize = this.ActualHeight / 20;

        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
