using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerConverter.trigger
{
    internal class TriggerCondition(string name, TriggerParameter[] parameters, TriggerCommand[] commands, TriggerExpression expression)
    {

        public string Name { get; set; } = name;
        public bool DirectCode { get; set; }

        public TriggerParameter[] Params { get; set; } = parameters;
        public TriggerCommand[] Commands { get; set; } = commands;

        public TriggerExpression Expression { get; set; } = expression;
    }
}
