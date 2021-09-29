using Mediator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandsAndHandlers
{
    public class CreateProduct : IRequest<int>
    {
        public string Name { get; set; }
    }
}
