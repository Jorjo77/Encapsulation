using System;
using System.Collections.Generic;
using System.Text;

namespace Encapsulation
{
    public class Car
    {
        public Engine Engine { get; set; }
        public SpeedStats SpeedStats { get; set; }
        public Tires Tires { get; set; }
        public void Start ()
        {
            Engine.Start();
            SpeedStats.StartWatching();
            Tires.IsRubbish();
            if (Tires.IsRubbish())
            {
            //Stats.Show("Change tires")
            }
        }
        public void Stop()
        {
            Engine.Stop();
            SpeedStats.StopWatching();
            Tires.IsRubbish();
            if (Tires.IsRubbish())
            {
                //Stats.Show("Change tires")
            }
        }

        public void PressPedal(int amount)
        {

        }
    }
}
