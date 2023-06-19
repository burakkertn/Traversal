using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.CQRS.Commands.DesCommands
{
    public class CreateDesCommand
    {
        public string City { get; set; }
        public string DayNight { get; set; }
        public string Price { get; set; }
        public int Capacity { get; set; }
    }
}
