using System;
using System.Collections.Generic;

namespace PROG7312POE
{
    public class eventsAndCategories
    {
        public SortedDictionary<DateTime, string> events { get; private set; }
        public Dictionary<string, List<string>> categoryEventMapping { get; private set; }
        public HashSet<string> Categories { get; private set; }

        public eventsAndCategories()
        {
            events = new SortedDictionary<DateTime, string>();
            categoryEventMapping = new Dictionary<string, List<string>>(StringComparer.OrdinalIgnoreCase);
            Categories = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

            eventsSample();
            categoriesSample();
        }

        private void eventsSample()
        {
            
            events.Add(new DateTime(2024, 10, 15), "Sports Event");
            events.Add(new DateTime(2024, 12, 13), "Soccer Match");
            events.Add(new DateTime(2024, 11, 01), "Cultural Festival");
            events.Add(new DateTime(2024, 12, 10), "Music Concert");
            events.Add(new DateTime(2024, 12, 11), "Comedy Night");
            events.Add(new DateTime(2024, 11, 10), "Rugby Night");
            events.Add(new DateTime(2024, 12, 24), "Christmas Celebration");
            events.Add(new DateTime(2025, 01, 01), "New Year Party");
            events.Add(new DateTime(2024, 12, 26), "Fake Year Party");

            events.Add(new DateTime(2025, 11, 01), "African Workshop");
            events.Add(new DateTime(2025, 02, 14), "Valentine's Day Gala");
            events.Add(new DateTime(2025, 03, 17), "St. Patrick's Day Parade");
            events.Add(new DateTime(2025, 04, 01), "April Fool's Day Comedy Show");
            events.Add(new DateTime(2025, 05, 05), "Cinco de Mayo Festival");
            events.Add(new DateTime(2025, 07, 04), "Independence Day Fireworks");

           
            categoryEventMapping["Sports"] = new List<string> { "Soccer Match", "Rugby Night", "Sports Event" };
            categoryEventMapping["Cultural"] = new List<string> { "Cultural Festival", "African Workshop" };
            categoryEventMapping["Music"] = new List<string> { "Music Concert" };
            categoryEventMapping["Holiday"] = new List<string> { "Christmas Celebration", "Independence Day Fireworks", "New Year Party", "Valentine's Day Gala", "St. Patrick's Day Parade" };
            categoryEventMapping["Party"] = new List<string> { "New Year Party", "Valentine's Day Gala", "Cinco de Mayo Festival" };
            categoryEventMapping["Comedy"] = new List<string> { "Comedy Night", "April Fool's Day Comedy Show" };
            categoryEventMapping["Festival"] = new List<string> { "Cinco de Mayo Festival", "Cultural Festival" };
        }

        private void categoriesSample()
        {
            
            Categories.Add("Sports");
            Categories.Add("Cultural");
            Categories.Add("Music");
            Categories.Add("Holiday");
            Categories.Add("Party");
            Categories.Add("Comedy");
            Categories.Add("Festival");
        }
    }
}
