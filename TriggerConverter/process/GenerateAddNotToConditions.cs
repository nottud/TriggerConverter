using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.process
{
    internal class GenerateAddNotToConditions
    {
        public TriggerAll Generate(TriggerAll triggerAll)
        {
            List<TriggerCondition> triggerConditions = new List<TriggerCondition>();
            foreach (TriggerCondition triggerCondition in triggerAll.Conditions)
            {
                if (!triggerCondition.DirectCode && triggerCondition.Name != "Always")
                {
                    List<TriggerParameter> parameters = new List<TriggerParameter>();
                    parameters.AddRange(triggerCondition.Params);
                    TriggerParameter parameter = new TriggerParameter("Not", "Not", VarType.BOOL, "false");
                    parameter.DoNotRelax = true;
                    parameters.Add(parameter);
                    triggerConditions.Add(new TriggerCondition(triggerCondition.Name, parameters.ToArray(), triggerCondition.Commands, new TriggerExpression("(" + triggerCondition.Expression.Expression + ") != %Not%")));
                }
                else
                {
                    triggerConditions.Add(triggerCondition);
                }
            }
            return new TriggerAll(triggerConditions.ToArray(), triggerAll.Effects);
        }
    }
}
