﻿using System;
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
            EventManager.events.RemoveAt(index);            //Удаление по номеру
        }           

        public static void Remove(Event ev)                 //Удаление по элементу
        {
            EventManager.events.Remove(ev);
        }                   

        public static Event Check_first()                   //Поиск ближайшего события
        {
            DateTime dt = events[0].time;
            int number = 0;
            for(int i=1;i<events.Count;i++)
            {
                if(events[i].Check() < dt)
                {
                    number = i;
                    dt = events[i].time;
                } 
            }
                return events[number];
        }

        public static void Add(int id, string name, DateTime time, string description)
        {
            events.Add(new Event( name,  time,  description, id));
        }
        public static void Remove(int id)
        {
            for (int i = 0; i < events.Count; i++)
            {
                if (events[i].id == id) { events.RemoveAt(i); break; } 
            }
        }
            }
           
        }

