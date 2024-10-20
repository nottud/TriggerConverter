using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.process
{
    internal class GenerateConditionalEffects
    {
        public TriggerAll Generate(TriggerAll triggerAll)
        {
            List<TriggerEffect> triggerEffects = new List<TriggerEffect>();
            foreach(TriggerCondition triggerCondition in triggerAll.Conditions)
            {
                List<TriggerParameter> parameters = new List<TriggerParameter>();
                parameters.AddRange(triggerCondition.Params);
                TriggerParameter parameter = new TriggerParameter("Not", "Not", VarType.BOOL, "false");
                parameter.DoNotRelax = true;
                parameters.Add(parameter);

                List<TriggerCommand> commands = new List<TriggerCommand>();
                commands.AddRange(triggerCondition.Commands);
                commands.Add(new TriggerCommand("if((" + triggerCondition.Expression.Expression + ") != %Not%){"));
                TriggerEffect triggerEffect = new TriggerEffect("If | " + triggerCondition.Name + " {",
                    parameters.ToArray(),
                    commands.ToArray());
                triggerEffects.Add(triggerEffect);
            }
            triggerEffects.Add(new TriggerEffect("If | End }", [], [new TriggerCommand("}")]));
            triggerEffects.Add(new TriggerEffect("If | } Else {", [], [new TriggerCommand("} else {")]));
            TriggerAll conditionalTriggerAll = new TriggerAll([], triggerEffects.ToArray());
            return TriggerAll.Concat(triggerAll, conditionalTriggerAll);
        }
    }
}
