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
    public partial class MainWindow : Window
    { /*
        Random Rnd = new Random();  
        int i = 0;
        int speed = 5; 
        bool gameOver = false;
        */
        public MainWindow()
        {
            InitializeComponent();
           // resetGame();


            Title.Content = "Sequence";
            Title.FontSize = 30;

            Start.Content = "Start";
            Start.FontSize = 20;
            Retry.Content = "Reset";
            Retry.FontSize = 20;
             

        }
        

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            /*
            int x = 1;
            Label.Content = $"Round {x}";
           // x++;
            // click on the buttons 

           // Button1.Background = Brushes.White;
            //Button1.Background = new SolidColorBrush(Color.FromArgb(255, 150, 196, 255));

            Button[] ButtonRange = new Button[9] { Button1, Button2, Button3, Button4, Button5, Button6, Button7, Button8, Button9 };
            Random rnd = new Random();
            List<Button> randomButtons = new List<Button>(5);
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
                   //System.Threading.Thread.Sleep(100);
                   button.Background = Brushes.Gray;
               }

               */ /*
            for (int i = 0; i < 3; ++i)
            {
                Button chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];
                //randomButtons.Add(chosenButton);

                chosenButton.Background = Brushes.Gray;
                System.Threading.Thread.Sleep(200);
                chosenButton.Background = new SolidColorBrush(Color.FromArgb(255, 150, 196, 255));
            }

            System.Threading.Thread.Sleep(500);
            for (int i = 0; i < 1; ++i)
            {
                Button chosenButton;
                chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];
                randomButtons.Add(chosenButton);

                chosenButton.Background = Brushes.Gray;
            }



            */

        //CHANGE - needs to do the ubttons one by one - check th echosenButton
    
        }
 

        private void Button1_Click(object sender, RoutedEventArgs e)
        { 
           /* Image img = new Image();
            img.Source = new BitmapImage(new Uri("foo.png"));

            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            stackPnl.Margin = new Thickness(10);
            stackPnl.Children.Add(img);

            Button btn = new Button();
            btn.Content = stackPnl;
            */
        }

       

        /*

            string userValue = Console.ReadLine();


            if (userValue == "1")
            {
                for (int i = 1; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
            }
*/


        //  Console.ReadLine();
        //     if statement chosenButton
    }
          
}
