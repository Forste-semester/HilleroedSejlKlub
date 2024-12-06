using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HillerødSejlKlub.Models;

namespace HillerødSejlKlub.Data
{
    public class EventCollection
    {
        private static Dictionary<string, Event> _eventData = new Dictionary<string, Event>()
        {
            {"Julefrokost", new Event("Julefrokost", "Den bedste julefrokost.", "21-12-2024", "14:00", "Klubhuset", "Jeppe", 150) },
            {"Kapsejlads", new Event("Kapsejlads", "Årets vigtigste konkurrence.", "01-04-2025", "09:00", "Esrum Sø", "Hanne", 100) },
            {"Generealforsamling", new Event("Generalforsamling", "Vi skal have en ny bestyrelse.", "10-10-2024", "18:00", "Klubhuset", "Jytte", 0) },
            {"Bingoaften", new Event("Bingoaften", "Sidegevinsterne er også gode.", "16-02-2025", "14:00", "Forsamlingshus på Dronningens Kovang", "Amalie", 50) },
            {"Afslutningsfest", new Event("Afslutningsfest", "Sæsonafslutning med kæmpe fest for alle medlemmer.", "30-05-2025", "14:00", "Klubhuset", "Ebbe", 200) }
        };

        public static Dictionary<string, Event> EventData
        {
            get { return _eventData; }
        }

    }
}
