using FBLeagueTimer.API;
using FBLeagueTimer.Features;
using System.Linq;
using System.Windows;

namespace FBLeagueTimer
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

        //TODO move out to viewmodel
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var name = "QLerin";
            var count = new FirstBloodsCounter().GetFirstBloodCount(name);
        }
    }
}
