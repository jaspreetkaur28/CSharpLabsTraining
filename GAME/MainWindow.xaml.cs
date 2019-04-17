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

namespace GAME
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Title.Content = "Sequence";
            Title.FontSize = 30;

            Start.Content = "Start";
            Start.FontSize = 20;
            Retry.Content = "Retry";
            Retry.FontSize = 20;
            
        }

        void Initialize()
        {
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            int i = 0;
            Label.Content = $"Round {i}";
            i++;
            // click on the buttons 

            Button1.Background = Brushes.White;
            Button1.Background = new SolidColorBrush(Color.FromArgb(255,150, 196, 255));
        }

        //if user input = start click  = next round  Label.Content = $"Round {i}";


        //System.Windows.Controls.DataGridSelectionUnit.FullRow.



    }
}
