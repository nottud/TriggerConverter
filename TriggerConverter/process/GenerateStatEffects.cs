using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.process
{
    internal class GenerateStatEffects
    {
        public TriggerAll Generate(TriggerAll triggerAll)
        {
            List<TriggerEffect> triggerEffects = new List<TriggerEffect>();
            foreach(TriggerCondition triggerCondition in triggerAll.Conditions)
            {
                TriggerParameter? operatorParameter = null;
                foreach (TriggerParameter triggerParameter in triggerCondition.Params)
                {
                    if (triggerParameter.VarType == VarType.OPERATOR)
                    {
                        operatorParameter = triggerParameter;
                    }
                }
                if (operatorParameter == null)
                {
                    continue;
                }

                TriggerExpression triggerExpression = triggerCondition.Expression;
                string[] parts = triggerExpression.Expression.Split(" %"+operatorParameter.Name+"% ");
                if (parts.Length != 2)
                {
                    continue;
                }

                TriggerParameter? comparisonParameter = null;
                foreach (TriggerParameter triggerParameter in triggerCondition.Params)
                {
                    if ((triggerParameter.VarType == VarType.LONG || triggerParameter.VarType == VarType.FLOAT) && parts[1] == "%"+triggerParameter.Name+"%")
                    {
                        comparisonParameter = triggerParameter;
                    }
                }
                if (comparisonParameter == null)
                {
                    continue;
                }


                List<TriggerParameter> parameters = new List<TriggerParameter>();
                if (comparisonParameter.VarType == VarType.LONG)
                {
                    parameters.Add(new TriggerParameter("Variable", "Variable", VarType.STRINGID, "intVariable"));
                } else
                {
                    parameters.Add(new TriggerParameter("Variable", "Variable", VarType.STRINGID, "floatVariable"));
                }
                parameters.AddRange(triggerCondition.Params);
                parameters.Remove(operatorParameter);
                parameters.Remove(comparisonParameter);

                List<TriggerCommand> declareVersionCommands = new List<TriggerCommand>();
                declareVersionCommands.AddRange(triggerCondition.Commands);
                if (comparisonParameter.VarType == VarType.LONG)
                {
                    declareVersionCommands.Add(new TriggerCommand("int %Variable% = " + parts[0] + ";"));
                    TriggerEffect triggerEffect = new TriggerEffect("Variable Int | " + triggerCondition.Name + " Declared",
                    parameters.ToArray(),
                    declareVersionCommands.ToArray());
                    triggerEffects.Add(triggerEffect);
                } else
                {
                    declareVersionCommands.Add(new TriggerCommand("float %Variable% = " + parts[0] + ";"));
                    TriggerEffect triggerEffect = new TriggerEffect("Variable Float | " + triggerCondition.Name + " Declared",
                    parameters.ToArray(),
                    declareVersionCommands.ToArray());
                    triggerEffects.Add(triggerEffect);
                }

                List<TriggerCommand> setVersionCommands = new List<TriggerCommand>();
                setVersionCommands.AddRange(triggerCondition.Commands);
                setVersionCommands.Add(new TriggerCommand("/**/%Variable% = " + parts[0] + ";"));
                if (comparisonParameter.VarType == VarType.LONG)
                {
                    TriggerEffect triggerEffect = new TriggerEffect("Variable Int | " + triggerCondition.Name + " Set",
                    parameters.ToArray(),
                    setVersionCommands.ToArray());
                    triggerEffects.Add(triggerEffect);
                } else
                {
                    TriggerEffect triggerEffect = new TriggerEffect("Variable Float | " + triggerCondition.Name + " Set",
                    parameters.ToArray(),
                    setVersionCommands.ToArray());
                    triggerEffects.Add(triggerEffect);
                }
            }
            TriggerAll statsTriggerAll = new TriggerAll([], triggerEffects.ToArray());
            return TriggerAll.Concat(triggerAll, statsTriggerAll);
        }
    }
}
