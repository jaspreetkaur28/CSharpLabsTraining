using System;
using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;


//what to research - switch +case, Eventhandler, how to make the randomtiles disappear again.
namespace WPF_game
{
    public partial class MainWindow : Window
    {
        private int time = 4;
        private DispatcherTimer Timer;
        private bool IsDisplaying; // maybe called a flag

        static Button[] ButtonRange;
        static Random rnd = new Random();
        static List<Button> randomButtons = new List<Button>();
        static List<Button> UserPickedButtons = new List<Button>();
        static int x = 1;

        public MainWindow()
        {
            InitializeComponent();
            initialize();
        }
        void initialize()
        {
            IsDisplaying = true;

            #region title semantics
            Title.Content = "      Pattern Matching";
            Title.FontSize = 50;
            Start.Content = "Start";
            Start.FontSize = 20;
            Retry.Content = "Reset";
            Retry.FontSize = 20;
            Label.FontSize = 20;
            #endregion

        }

        private void Start_Click(object sender, RoutedEventArgs e) 
        {
            UserPickedButtons.Clear();
            randomButtons.Clear();
            Start.IsEnabled = false;

            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            Timer.Tick += Timer_Tick;
            Timer.Start();

            Label.Text = $"Round {x}";

            RandomTiles();
            IsDisplaying = true;

        }
        void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 2)
            {
                    time--;
                    IsDisplaying = true;
            }
            else
            {
                    Timer.Stop();
                    resetbuttons();

                    IsDisplaying = false;
            }
             
        }
        private void Retry_Click(object sender, RoutedEventArgs e)
        {
            Label.Text = null;
            x = 1;
            UserPickedButtons.Clear();
            randomButtons.Clear();
            Start.IsEnabled = true;

            resetbuttons();
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
            ButtonRange = new Button[20]
                { Button01, Button02, Button03, Button04, Button05, Button06, Button07, Button08, Button09, Button10, Button11, Button12, Button13, Button14, Button15, Button16, Button17, Button18, Button19, Button20 };

            if (x <= 3)
            {
                 for (int i = 0; i < 5; ++i)
                {
                    Button chosenButton;
                    do
                    {
                        chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];

                    } while (randomButtons.Contains(chosenButton));

                    randomButtons.Add(chosenButton);
                }
                foreach (Button button in randomButtons) { button.Background = Brushes.Gray; }
            }

            if (x == 4 || x == 5 || x == 6)
            {
                
                for (int i = 0; i < 7; ++i)
                {
                    Button chosenButton;
                    do
                    {
                        chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];

                    } while (randomButtons.Contains(chosenButton));

                    randomButtons.Add(chosenButton);
                }
                foreach (Button button in randomButtons) { button.Background = Brushes.Gray; }
            }

            if (x >= 7  )
            {
               
                for (int i = 0; i < 11; ++i)
                {
                    Button chosenButton;
                    do
                    {
                        chosenButton = ButtonRange[rnd.Next(0, ButtonRange.Length)];

                    } while (randomButtons.Contains(chosenButton));

                    randomButtons.Add(chosenButton);
                }
                foreach (Button button in randomButtons) { button.Background = Brushes.Gray; }
            }

        }

         
        private void GameOver()
        {
            Label.Text = null;
            foreach (Button button in randomButtons) { button.Background = Brushes.Gray; } 

            MessageBoxResult result = MessageBox.Show($"Sorry that wasn't the right one.\nYou reached Round {x}. \nDo you want to play again?",
                                  "Game Over",
                                  MessageBoxButton.YesNo,
                                  MessageBoxImage.Question);

            if (result == MessageBoxResult.Yes)
            {
                Label.Text = null;
                x = 1;
                Start.IsEnabled = true;
                resetbuttons();
            }
            else Application.Current.Shutdown();
        }



        private void button_Click(object sender, EventArgs e)
        {
            if (IsDisplaying) {
                return;
            }

            Button current = (Button)sender;

            #region if current button is one of the chosen

            if (ButtonRange[0].Name == current.Name)
            {
                if (randomButtons.Contains(Button01) && !UserPickedButtons.Contains(Button01)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red;  GameOver();}
            }
            else if (ButtonRange[1].Name == current.Name)
            {
                if (randomButtons.Contains(Button02) && !UserPickedButtons.Contains(Button02)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[2].Name == current.Name)
            {
                if (randomButtons.Contains(Button03) && !UserPickedButtons.Contains(Button03)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[3].Name == current.Name)
            {
                if (randomButtons.Contains(Button04) && !UserPickedButtons.Contains(Button04)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[4].Name == current.Name)
            {
                if (randomButtons.Contains(Button05) && !UserPickedButtons.Contains(Button05)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[5].Name == current.Name)
            {
                if (randomButtons.Contains(Button06) && !UserPickedButtons.Contains(Button06)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[6].Name == current.Name)
            {
                if (randomButtons.Contains(Button07) && !UserPickedButtons.Contains(Button07)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[7].Name == current.Name)
            {
                if (randomButtons.Contains(Button08) && !UserPickedButtons.Contains(Button08)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[8].Name == current.Name)
            {
                if (randomButtons.Contains(Button09) && !UserPickedButtons.Contains(Button09)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[9].Name == current.Name)
            {
                if (randomButtons.Contains(Button10) && !UserPickedButtons.Contains(Button10)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[10].Name == current.Name)
            {
                if (randomButtons.Contains(Button11) && !UserPickedButtons.Contains(Button11)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[11].Name == current.Name)
            {
                if (randomButtons.Contains(Button12) && !UserPickedButtons.Contains(Button12)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[12].Name == current.Name)
            {
                if (randomButtons.Contains(Button13) && !UserPickedButtons.Contains(Button13)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[13].Name == current.Name)
            {
                if (randomButtons.Contains(Button14) && !UserPickedButtons.Contains(Button14)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[14].Name == current.Name)
            {
                if (randomButtons.Contains(Button15) && !UserPickedButtons.Contains(Button15)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[15].Name == current.Name)
            {
                if (randomButtons.Contains(Button16) && !UserPickedButtons.Contains(Button16)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[16].Name == current.Name)
            {
                if (randomButtons.Contains(Button17) && !UserPickedButtons.Contains(Button17)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[17].Name == current.Name)
            {
                if (randomButtons.Contains(Button18) && !UserPickedButtons.Contains(Button18)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[18].Name == current.Name)
            {
                if (randomButtons.Contains(Button19) && !UserPickedButtons.Contains(Button19)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }
            else if (ButtonRange[19].Name == current.Name)
            {
                if (randomButtons.Contains(Button20) && !UserPickedButtons.Contains(Button20)) { current.Background = Brushes.Blue; UserPickedButtons.Add(current); }
                else { current.Background = Brushes.Red; GameOver(); }
            }

            #endregion 
                
            if (UserPickedButtons.Count == randomButtons.Count)
            {
              //  Count.Content = $"Random {randomButtons.Count}. User Clicked {UserPickedButtons.Count}";
                x++;

                foreach (Button button in randomButtons) { button.Background = Brushes.Green; }

                MessageBox.Show("You picked the right boxes. Click OK for the next level");

                Start.IsEnabled = true;
                resetbuttons();
                Label.Text = $"Round {x}";
            }
        }

        #region commented code
        //Use this in Start clicked and gameover method if needed to test
        //  Count.Content = $"Random {randomButtons.Count}. User Clicked {UserPickedButtons.Count}"; 


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
