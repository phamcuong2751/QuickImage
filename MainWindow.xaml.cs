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

namespace QuickImage
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string contents = "Keep going. Everything you need will come to you at the perfect time.|You have to be at your strongest when you’re feeling at your weakest.|Never give up. Great things take time. Be patient.|It does not matter how slowly you go as long as you do not stop.|You have to be at your strongest when you’re feeling at your weakest.|Courage is one step ahead of fear.|If you feel like giving up, just look back on how far you are already.|Look in the mirror. That’s your competition.|Focus on your goal. Don’t look in any direction but ahead.|Everything you’ve ever wanted is on the other side of fear.|Pain is temporary. Quitting lasts forever.|The pain you feel today will be the strength you feel tomorrow.|We must embrace pain and burn it as fuel for our journey.";
            string SPACE = "|";
            string[] content = contents.Split(new string[] { SPACE }, StringSplitOptions.None);
            for (int i = 0; i < content.Length; i++)
            {
                Console.WriteLine($"[{i}] = {content[i]}");
            }

            Random AGR = new Random();
            int rd = AGR.Next(0, 12);
            textContent.Text = content[rd];
            textContent.FontSize = 24.75;
            var uri = new Uri("img/Slide"+rd+".png", UriKind.Relative);
            imageName.Source = new BitmapImage(uri);
        }
    }
}
