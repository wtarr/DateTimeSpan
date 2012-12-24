using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DateTimeProcessing;

namespace DateTimeSpans
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void dpickerToDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            bool isFortnight;
            ProcessDate pd = new ProcessDate();
            try
            {
                textBox1.Text = pd.CalculateSpanBetweenTwoDates((DateTime)dpickerStartDate.SelectedDate, (DateTime)dpickerToDate.SelectedDate, out isFortnight).ToString();
                textBox2.Text = isFortnight.ToString();
            }
            catch (Exception) {}

             
        }

        private void dpickerStartDate_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
