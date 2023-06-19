using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.CQRS.Commands.DesCommands
{
    public class RemoveDesCommand
    {
        public RemoveDesCommand(int id)
        {
            Id = id;
        }

        public int Id { get; set; }
    }
}
