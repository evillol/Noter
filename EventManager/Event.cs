using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager
{
    public class Event
    {
        private string name, details;
        private int id;
        private DateTime time;

        public Event(string name, DateTime time, string details, int id)
        {
            this.details = details;
            this.name = name;
            this.time = time;
            this.id = id;
        }

        public DateTime Check()
        {
            DateTime dt;
            dt = DateTime.Now;
            long ticks;
            ticks = (this.time - dt).Ticks;
            return new DateTime(ticks);
        }
       
    }
}
