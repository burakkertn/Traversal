using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Traversal.CQRS.Commands.TeamCommands
{
    public class CreateTeamCommand : IRequest
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
