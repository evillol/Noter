using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EventManager
{
    public static class EventManager
    {
        public static List<Event> events = new List<Event>();

        public static void Remove(int index)
        {
            EventManager.events.RemoveAt(index);
        }

        public static void Remove(Event ev)
        {
            EventManager.events.Remove(ev);
        }
    }
}
