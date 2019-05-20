using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Media;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Threading;



namespace RabbitWPF
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
            Rabbit.Explosion();
        }

        public class Rabbit
        {
            public static int Explosion( )
            {


                List<Rabbit> RabbitList = new List<Rabbit>();
                Rabbit r = new Rabbit();
                RabbitList.Add(r);
                Console.WriteLine(RabbitList.Count);

                TimeSpan Time = new TimeSpan();
                var s = new Stopwatch();

                s.Start();
                int Seconds = 0;
                while (RabbitList.Count <= 100)
                {
                    int j = RabbitList.Count;
                    if (Seconds ==  TextBox tb)
                    {
                        break;
                    }
                    else
                    {
                        for (int i = 1; i <= j; i++)
                        {
                            r = new Rabbit();
                            RabbitList.Add(r);
                        }

                    }
                    Seconds++;

                    Console.WriteLine(RabbitList.Count);
                    // Console.WriteLine("Num is " + Seconds);
                    while (Time.Seconds < Seconds)
                    {
                        Time = s.Elapsed;
                    }

                }
                s.Stop();
                Console.WriteLine(s.Elapsed);
                Time = s.Elapsed;
                return RabbitList.Count;





            }

        }
            }
}
