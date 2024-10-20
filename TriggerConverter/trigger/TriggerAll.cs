using System;
using System.Collections.Generic;
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
    }
}
