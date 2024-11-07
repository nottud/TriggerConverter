using System;
using System.Collections.Generic;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerConverter.trigger
{
    internal class TriggerAll(TriggerCondition[] conditions, TriggerEffect[] effects)
    {
        public TriggerCondition[] Conditions { get; set; } = conditions;
        public TriggerEffect[] Effects { get; set; } = effects;

        public static TriggerAll Concat(TriggerAll first, TriggerAll second)
        {
            TriggerAll combined = new TriggerAll(
                    first.Conditions.Concat(second.Conditions).ToArray(),
                    first.Effects.Concat(second.Effects).ToArray());
            return combined;
        }

        public static TriggerAll StripOriginal(TriggerAll triggerAll, TriggerAll original)
        {
            HashSet<TriggerCondition> originalConditions = new HashSet<TriggerCondition>(original.Conditions);
            HashSet<TriggerEffect> originalEffects = new HashSet<TriggerEffect>(original.Effects);
            TriggerAll removed = new TriggerAll(
                    triggerAll.Conditions.Where(condition => !originalConditions.Contains(condition)).ToArray(),
                    triggerAll.Effects.Where(effect => !originalEffects.Contains(effect)).ToArray());
            return removed;
        }
    }
}
