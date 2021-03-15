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

namespace Controls_2
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

        private void FirstOption_Click(object sender, RoutedEventArgs e)
        {
        }

        private void AnotherButton_Click(object sender, RoutedEventArgs e)
        {
            MyTab.SelectedIndex = 4;
        }

        private void DialogWindow_Click(object sender, RoutedEventArgs e)
        {
            DialogWindow dialog_window = new DialogWindow();
            if(dialog_window.ShowDialog() == true)
            {
                if (dialog_window.BoxString == "123")
                {
                    MessageBox.Show("Success");
                }
                else
                {
                    MessageBox.Show("Fail");
                }
            }
            else
            {
                MessageBox.Show("Fail");
            }
        }

        private void SliderValue_Changed(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            SliderValue.Text = MySlider.Value.ToString();
        }

        private void Progress_Click(object sender, RoutedEventArgs e)
        {
            MyProgressBar.Value = MyProgressBar.Value + 5;
        }
    }
}
