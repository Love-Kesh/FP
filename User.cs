using System.Collections.Generic;
using System.Drawing;

namespace Final_Project
{
    public class User
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public List<Pet> Pets { get; set; } = new List<Pet>();
    }
}
