using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerConverter.trigger
{
    internal class TriggerEffect(string name, TriggerParameter[] triggerParameters, TriggerCommand[] commands)
    {

        public string Name { get; set; } = name;
        public bool DirectCode { get; set; }

        public TriggerParameter[] Params { get; set; } = triggerParameters;
        public TriggerCommand[] Commands { get; set; } = commands;
    }
}
