using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.process
{
    internal class RemoveDuplicateTriggers
    {
        private static String HASH_SEPARATOR = ",";
        private static TriggerExpression DUMMY_EXPRESSION = new TriggerExpression("");

        private String HashTriggerData(TriggerParameter[] parameters, TriggerCommand[] commands, TriggerExpression expression)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach(TriggerParameter parameter in parameters)
            {
                stringBuilder.Append(parameter.Name);
                stringBuilder.Append(HASH_SEPARATOR);
                stringBuilder.Append(parameter.Display);
                stringBuilder.Append(HASH_SEPARATOR);
                stringBuilder.Append(parameter.VarType);
                stringBuilder.Append(HASH_SEPARATOR);
                stringBuilder.Append(parameter.DefaultValue);
                stringBuilder.Append(HASH_SEPARATOR);
            }          
            foreach(TriggerCommand command in commands)
            {
                stringBuilder.Append(command.Loop);
                stringBuilder.Append(HASH_SEPARATOR); 
                stringBuilder.Append(command.LoopSourceObject);
                stringBuilder.Append(HASH_SEPARATOR);    
                stringBuilder.Append(command.CommandCode);
                stringBuilder.Append(HASH_SEPARATOR);
            }
            stringBuilder.Append(expression.Expression);
            return stringBuilder.ToString();
        }

        private TriggerCondition[] RemoveConditions(TriggerCondition[] existingConditions)
        {
            HashSet<String> hashedConditions = new HashSet<String>();
            List<TriggerCondition> conditions = new List<TriggerCondition>();
            foreach (TriggerCondition existingCondition in existingConditions)
            {
                if (hashedConditions.Add(HashTriggerData(existingCondition.Params, existingCondition.Commands, existingCondition.Expression)))
                {
                    conditions.Add(existingCondition);
                }
            }
            return conditions.ToArray();
        }

        private TriggerEffect[] RemoveEffects(TriggerEffect[] existingEffects)
        {
            HashSet<String> hashedEffects = new HashSet<String>();
            List<TriggerEffect> effects = new List<TriggerEffect>();
            foreach (TriggerEffect existingEffect in existingEffects)
            {
                if (hashedEffects.Add(HashTriggerData(existingEffect.Params, existingEffect.Commands, DUMMY_EXPRESSION)))
                {
                    effects.Add(existingEffect);
                }
            }
            return effects.ToArray();
        }

        public TriggerAll Remove(TriggerAll triggerAll)
        {
            return new TriggerAll(
                RemoveConditions(triggerAll.Conditions),
                RemoveEffects(triggerAll.Effects));
        }

    }
}
