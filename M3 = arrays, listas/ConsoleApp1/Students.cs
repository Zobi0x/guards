using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Students
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public int Room { get; set; }

        public Students(string name, string email, int room)
        {
            Name = name;
            Email = email;
            this.Room = room;
        }

       
    }
}
