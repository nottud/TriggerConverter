using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerConverter.trigger
{
    internal class TriggerCommand(string command)
    {
        public bool Loop { get; set; }
        public string? LoopSourceObject { get; set; }
        public string CommandCode { get; set; } = command;
    }
}
