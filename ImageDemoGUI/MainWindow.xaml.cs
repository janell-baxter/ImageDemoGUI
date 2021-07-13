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

namespace ImageDemoGUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        string[] headImages = {"media/Head01.bmp", "media/Head02.bmp", "media/Head03.bmp" };
        int currentHead = 0;
        public MainWindow()
        {
            InitializeComponent();
            LoadInitialImages();
        }

        private void LoadInitialImages()
        {
            HeadImage.Source = new BitmapImage(new Uri(headImages[currentHead], UriKind.Relative));
            //load initial torso
            //load initial legs
        }
        private void NextButton_Click(object sender, RoutedEventArgs e)
        {
            currentHead++;
            if (currentHead >= headImages.Length)
            {
                currentHead=0;
            }
            HeadImage.Source = new BitmapImage(new Uri(headImages[currentHead], UriKind.Relative));
        }

        private void HeadPreviousButton_Click(object sender, RoutedEventArgs e)
        {
            currentHead--;
            if (currentHead < 0)
            {
                currentHead = headImages.Length-1;
            }
            HeadImage.Source = new BitmapImage(new Uri(headImages[currentHead], UriKind.Relative));
        }
    }
}
