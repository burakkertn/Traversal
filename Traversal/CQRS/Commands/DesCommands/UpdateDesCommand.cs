using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.CQRS.Commands.DesCommands
{
    public class UpdateDesCommand
    {
        public int ID { get; set; }
        public string City { get; set; }
        public string DayNight { get; set; }
        public string Price { get; set; }
    }
}
