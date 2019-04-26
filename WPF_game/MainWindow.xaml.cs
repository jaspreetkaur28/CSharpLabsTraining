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

namespace WPF_game
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
            Retry.Content = "Reset";
            Retry.FontSize = 20;
        }
        private void Start_Click(object sender, RoutedEventArgs e)
        {
            RandomTiles();

        }

        private void RandomTiles()
        {
           int x = 1;
           Label.Content = $"Round {x}";
         
           Button[] ButtonRange = new Button[9] { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9 };
           Random rnd = new Random();
           List<Button> randomButtons = new List<Button>(5);

            for (int i = 0; i < 1; i++)
            {
                Button chosenButton;
                do
                {
                    chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];

                    chosenButton.Background = Brushes.Gray;

                } while (randomButtons.Contains(chosenButton));

               // System.Threading.Thread.Sleep(500);

            }

            
            
            
            
            /*
              for (int i = 0; i < 5; ++i)
              {
                  Button chosenButton;               
                  do
                  {           
                      chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];

                  } while (randomButtons.Contains(chosenButton));

                  randomButtons.Add(chosenButton);

              }

              foreach (Button button in randomButtons)
              {
                 
                  button.Background = Brushes.Gray;
              }
              */
             
           
        }
        private void UserAnswer()
        {

        }
    }
}
