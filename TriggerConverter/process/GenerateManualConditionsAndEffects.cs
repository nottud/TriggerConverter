using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.process
{
    internal class GenerateManualConditionsAndEffects
    {

        private CloneParametersRelaxingTypes cloneParametersRelaxingTypes = new CloneParametersRelaxingTypes();

        private bool ShouldGenerate(TriggerParameter[] parameters, string[] manualTypes)
        {
            return parameters.Where(parameter => !parameter.DoNotRelax && manualTypes.Contains(parameter.VarType)).Count() >= 1;
        }

        private TriggerCondition[] GenerateConditions(TriggerCondition[] existingConditions, string[] manualTypes, string suffix, string[] toInclude)
        {
            List<TriggerCondition> conditions = new List<TriggerCondition>();
            foreach (TriggerCondition existingCondition in existingConditions)
            {
                if (ShouldGenerate(existingCondition.Params, manualTypes))
                {
                    TriggerCondition newCondition = new TriggerCondition(existingCondition.Name + " " + suffix,
                        cloneParametersRelaxingTypes.cloneRelaxing(existingCondition.Params, toInclude),
                        existingCondition.Commands,
                        existingCondition.Expression);
                    newCondition.DirectCode = existingCondition.DirectCode;
                    conditions.Add(newCondition);
                }
            }
            return conditions.ToArray();
        }

        private TriggerEffect[] GenerateEffects(TriggerEffect[] existingEffects, string[] manualTypes, string suffix, string[] toInclude)
        {
            List<TriggerEffect> effects = new List<TriggerEffect>();
            foreach (TriggerEffect existingEffect in existingEffects)
            {
                if (ShouldGenerate(existingEffect.Params, manualTypes))
                {
                    TriggerEffect newCondition = new TriggerEffect(existingEffect.Name + " " + suffix,
                        cloneParametersRelaxingTypes.cloneRelaxing(existingEffect.Params, toInclude),
                        existingEffect.Commands);
                    newCondition.DirectCode = existingEffect.DirectCode;
                    effects.Add(newCondition);
                }
            }
            return effects.ToArray();
        }

        public TriggerAll Generate(TriggerAll triggerAll, string[] manualTypes, string suffix, string[] includeButNotSufficient)
        {
            string[] toInclude = manualTypes.Concat(includeButNotSufficient).ToArray();
            TriggerAll byIdTriggerAll = new TriggerAll(
                GenerateConditions(triggerAll.Conditions, manualTypes, suffix, toInclude),
                GenerateEffects(triggerAll.Effects, manualTypes, suffix, toInclude));
            return TriggerAll.Concat(triggerAll, byIdTriggerAll);
        }
    }
}
