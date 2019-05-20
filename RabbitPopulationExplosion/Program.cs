using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RabbitPopulationExplosion
{
    class Program
    {
        static void Main(string[] args)
        {
            Rabbit.Explosion(1000000);


        }
    }

    public class Rabbit
    {
        public static int Explosion(int X)
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
                if (Seconds == X)
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
