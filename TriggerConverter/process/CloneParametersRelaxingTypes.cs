using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.process
{
    internal class CloneParametersRelaxingTypes
    {
        public TriggerParameter[] cloneRelaxing(TriggerParameter[] existingParameters, params string[] relaxParameters) {
            List<TriggerParameter> parameters = new List<TriggerParameter>();
            foreach (TriggerParameter parameter in existingParameters)
            {
                if (!parameter.DoNotRelax && relaxParameters.Contains(parameter.VarType))
                {
                    parameters.Add(parameter.CloneChangingVarType(VarType.STRINGID));
                } else
                {
                    parameters.Add(parameter);
                }
            }
            return parameters.ToArray();
        }
    }
}
