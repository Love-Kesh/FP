using System.Collections.Generic;

namespace Final_Project
{
    public class Pet
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public string Breed { get; set; }
        public List<Task> Tasks { get; set; } = new List<Task>();
        public List<Schedule> Schedule { get; set; } = new List<Schedule>();
    }
}
