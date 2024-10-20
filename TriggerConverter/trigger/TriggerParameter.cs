using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerConverter.trigger
{
    internal class TriggerParameter(string name, string display, string varType, string defaultValue)
    {
        public string Name { get; set; } = name;
        public string Display { get; set; } = display;
        public string VarType { get; set; } = varType;
        public string DefaultValue { get; set; } = defaultValue;
        public bool DisplayRadius { get; set; }
        public bool DoNotRelax { get; set; }

        public TriggerParameter CloneChangingVarType(string newVarType)
        {
            TriggerParameter newTriggerParameter = new TriggerParameter(Name, Display, newVarType, DefaultValue);
            newTriggerParameter.DisplayRadius = DisplayRadius;
            newTriggerParameter.DoNotRelax = DoNotRelax;
            return newTriggerParameter;
        }
    }
}
