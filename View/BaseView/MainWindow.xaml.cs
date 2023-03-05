using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace WpfIHelper
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            GetDate();
        }
        #region Лого даты
        /// <summary>
        /// Получить дату
        /// </summary>
        private void GetDate()
        {
            DispatcherTimer LiveTime = new DispatcherTimer();
            LiveTime.Interval = TimeSpan.FromSeconds(1);
            LiveTime.Tick += timer_Tick;
            LiveTime.Start();
        }
        void timer_Tick(object sender, EventArgs e)
        {
            LiveYear.Content = DateTime.Now.ToString("yyyy", new System.Globalization.CultureInfo("En-en"));
            LiveDate.Content = DateTime.Now.ToString("ddd, ", new System.Globalization.CultureInfo("En-en")) + DateTime.Now.ToString("M", new System.Globalization.CultureInfo("En-en"));
        }
        #endregion
    }
}
