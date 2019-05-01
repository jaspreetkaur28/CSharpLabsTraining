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


//what to research - switch +case, Eventhandler, how to make the randomtiles disappear again.
namespace WPF_game
{
    public partial class MainWindow : Window
    {
        private int time = 5;
        private DispatcherTimer Timer;


        static Button[] ButtonRange;
        static Random rnd = new Random();
        static List<Button> randomButtons = new List<Button>();
        static List<Button> UserPickedButtons = new List<Button>();

        //add gameover function where it says you failed in a messagebox  plus show what was the chosenbutton and change the wrong button to red
        //and opens a new window when they click restart on the messagebox? 
        public MainWindow()
        {
            InitializeComponent();
            #region title semantics
            Title.Content = "    Pattern Matching";
            Title.FontSize = 60;

            Start.Content = "Start";
            Start.FontSize = 20;
            Retry.Content = "Reset";
            Retry.FontSize = 20;
            #endregion
          
        }

        private void Start_Click(object sender, RoutedEventArgs e)
        {
            Start.IsEnabled = false;
            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();

            RandomTiles();
        }
        void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 3)
            {
                time--;
                lblTime.Content = DateTime.Now.ToLongTimeString();
            }
            else
            {
                Timer.Stop();

                resetbuttons();
            }
        }
        private void Retry_Click(object sender, RoutedEventArgs e)
        {
            Label.Content = null;
            resetbuttons();

            Timer.Stop();
        }
        private void resetbuttons()
        {
          var bc = new BrushConverter();
            foreach (var item in ButtonRange)
            {
                item.Background = (Brush)bc.ConvertFrom("#96c4ff");
            }

        }


        public void RandomTiles()
        { 
           int x = 1;
           Label.Content = $"Round {x}";
            ButtonRange = new Button[15]
        { Button01, Button02, Button03, Button04, Button05, Button06, Button07, Button08, Button09, Button10, Button11, Button12, Button13, Button14, Button15 };


            for (int i = 0; i < 5; ++i)
            {
                Button chosenButton;
                do
                {
                    chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];

                } while (randomButtons.Contains(chosenButton));

                randomButtons.Add(chosenButton);
            } 
            foreach (Button button in randomButtons) {  button.Background = Brushes.Gray; }
        
        }
        //  foreach button clicked which != randomButtons - game over else change buttonBackGround = Brushes.Gray
        private void GameOver()
        {

            foreach (Button button in randomButtons) { button.Background = Brushes.Gray; }
            

            MessageBoxResult result = MessageBox.Show("Sorry that wasn't the right one. Do you want to play again?",
                                  "Game Over",
                                  MessageBoxButton.YesNo,
                                  MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                MainWindow WPF = new MainWindow();
                WPF.ShowDialog();
            }
            else Application.Current.Shutdown();
        }


        private void button_Click(object sender, EventArgs e)
        { 
            Button current = (Button)sender;

            #region if current button is one of the chosen

            if (ButtonRange[0].Name == current.Name)
            {
                if (randomButtons.Contains(Button01)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[1].Name == current.Name )
            {
                if (randomButtons.Contains(Button02)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[2].Name == current.Name)
            {
                if (randomButtons.Contains(Button03)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[3].Name == current.Name)
            {
                if (randomButtons.Contains(Button04)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[4].Name == current.Name)
            {
                if (randomButtons.Contains(Button05)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[5].Name == current.Name)
            {
                if (randomButtons.Contains(Button06)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[6].Name == current.Name)
            {
                if (randomButtons.Contains(Button07)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[8].Name == current.Name)
            {
                if (randomButtons.Contains(Button09)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[9].Name == current.Name)
            {
                if (randomButtons.Contains(Button10)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[10].Name == current.Name)
            {
                if (randomButtons.Contains(Button11)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[11].Name == current.Name)
            {
                if (randomButtons.Contains(Button12)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[12].Name == current.Name)
            {
                if (randomButtons.Contains(Button13)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[13].Name == current.Name)
            {
                if (randomButtons.Contains(Button14)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            }
            else if (ButtonRange[14].Name == current.Name)
            {
                if (randomButtons.Contains(Button15)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else GameOver();
            } 

            /*
        MessageBox.Show(UserPickedButtons.Count);
            #endregion
            if (UserPickedButtons.Length =5)
            {
                MessageBox.Show("Yes");
            }
            }

            */
        



            /*
        private void UserAnswer(object sender , RoutedEventHandler e)
        {

            #region switch case code

            /*
            switch ((sender as Button).Name)
            {
                case "button1":
                    //actions 
                    MessageBox.Show("hi");
                    break;
                case "button2":
                    //actions
                    break;
                default:
                    break;
            }*/

            #endregion


            #region button event handler


            /*
            button.Click += new RoutedEventHandler(button_Click);
            if (UserAnswer = chosenButton)
            {
               
            }
            chosenButton ;
            Control src = e.Source as Control;

            if (src != null)
            {
                switch (e.ChangedButton)
                {
                    
                    case MouseButton.XButton1:
                        src.Background = Brushes.Brown;
                        break;
                    case MouseButton.XButton2:
                        src.Background = Brushes.Purple;
                        break;
                    default:
                        break;
                }
            }


            
            Button1.Click += new EventHandler(ButtonClick);
            Button2.Click += new EventHandler(ButtonClick);
            Button3.Click += new EventHandler(ButtonClick);
            Button4.Click += new EventHandler(ButtonClick);
            Button5.Click += new EventHandler(ButtonClick);
            Button6.Click += new EventHandler(ButtonClick);

            void ButtonClick(object sender, MouseButtonEventArgs e)
            {
                switch ((sender as Button).Name)
                {
                    case "button1":
                        //actions
                        break;
                    case "button2":
                        //actions
                        break;
                    default:
                        break;
                }
            } */
            #endregion
        }

        #region commented code

        /* Random button generator original code
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


        //Color.PreviousColor;
        #endregion


    }
}
