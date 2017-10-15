using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{

    public class ClockEventArgs : EventArgs
    {

        public readonly int _seconds;
        public readonly int _minutes;
        public readonly int _hours;

        public ClockEventArgs(int h, int m, int s)
        {
            this._hours = h;
            this._minutes = m;
            this._seconds = s;
        }
    }
    public class Clock
    {
        private int _seconds;
        private int _minutes;
        private int _hours;
        //Any anonymours object which want to subscribe this event is passed.
        public delegate void SecondChangeHandler(object obj, ClockEventArgs e);
        public event SecondChangeHandler secondEventHandler;

        public void DisplayClock()
        {
            for (; ; )
            {
                DateTime dt = DateTime.Now;
                if (dt.Second != _seconds)
                {
                    secondEventHandler(this, new ClockEventArgs(dt.Hour, dt.Minute, dt.Second));
                }
                _seconds = dt.Second;
                _minutes = dt.Minute;
                _hours = dt.Hour;
            }
        }

        //// The method which fires the Event
        //protected void OnsecondEventHandler(
        //   object clock,
        //   ClockEventArgs timeInformation
        //)
        //{
        //    // Check if there are any Subscribers
        //    if (secondEventHandler != null)
        //    {
        //        // Call the Event
        //        secondEventHandler(clock, timeInformation);
        //    }
        //}


    }


    public class ClockDisplaySubscriber
    {
        public void SubscribedFunction(object obj, ClockEventArgs e)
        {
            Console.WriteLine(" Hour {0}:Minutes : {1} :Seconds {2}", e._hours, e._minutes, e._seconds);
        }

        public void SubScribeTClockSecondChanges(Clock clock)
        {
            clock.secondEventHandler += new Clock.SecondChangeHandler(SubscribedFunction);
        }

    }

    public class ClockFileLogger
    {
        
        StreamWriter sw;
        public ClockFileLogger(string filePath)
        {
            
        }

    }

    public class TestClock
    {
        public static void Main()
        {
            Clock c = new Clock();
            ClockDisplaySubscriber obj = new ClockDisplaySubscriber();
            obj.SubScribeTClockSecondChanges(c);
            c.DisplayClock();
            Console.Read();
        }


    }

}




