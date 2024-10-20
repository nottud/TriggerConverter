using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using TriggerConverter.trigger;

namespace TriggerConverter.io
{
    internal class Reader
    {
        private TriggerParameter[] ParseParameters(XmlNode node)
        {
            List<TriggerParameter> triggerParameters = new List<TriggerParameter>();
            foreach (XmlNode parameterNode in node.SelectNodes("param"))
            {
                TriggerParameter triggerParameter = new TriggerParameter(
                    parameterNode.Attributes.GetNamedItem("name").Value,
                    parameterNode.Attributes.GetNamedItem("dispname").Value,
                    parameterNode.Attributes.GetNamedItem("vartype").Value,
                    parameterNode.InnerText);
                if (parameterNode.Attributes.GetNamedItem("dispradius") != null)
                {
                    triggerParameter.DisplayRadius = true;
                }
                if (parameterNode.Attributes.GetNamedItem("donotrelax") != null)
                {
                    triggerParameter.DoNotRelax = true;
                }
                triggerParameters.Add(triggerParameter);
            }
            return triggerParameters.ToArray();
        }

        private TriggerCommand[] ParseCommands(XmlNode node)
        {
            List<TriggerCommand> triggerCommands = new List<TriggerCommand>();
            foreach (XmlNode commandNode in node.SelectNodes("command"))
            {
                TriggerCommand triggerCommand = new TriggerCommand(commandNode.InnerText);
                if (commandNode.Attributes.GetNamedItem("loop") != null)
                {
                    triggerCommand.Loop = true;
                }
                XmlNode loopParam = commandNode.Attributes.GetNamedItem("loopparm");
                if (loopParam != null)
                {
                    triggerCommand.LoopSourceObject = loopParam.Value;
                }
                triggerCommands.Add(triggerCommand);
            }
            return triggerCommands.ToArray();
        }

        private TriggerCondition[] ParseConditions(XmlNode conditionsNode)
        {
            List<TriggerCondition> conditions = new List<TriggerCondition>();
            foreach (XmlNode conditionNode in conditionsNode.SelectNodes("condition"))
            {
                TriggerCondition condition = new TriggerCondition(
                    conditionNode.Attributes.GetNamedItem("name").Value,
                    ParseParameters(conditionNode),
                    ParseCommands(conditionNode),
                    new TriggerExpression(conditionNode.SelectSingleNode("expression").InnerText));

                if (conditionNode.Attributes.GetNamedItem("directcode") != null)
                {
                    condition.DirectCode = true;
                }

                conditions.Add(condition);
            }
            return conditions.ToArray();
        }

        private TriggerEffect[] ParseEffects(XmlNode effectsNode)
        {
            List<TriggerEffect> effects = new List<TriggerEffect>();
            foreach (XmlNode effectNode in effectsNode.SelectNodes("effect"))
            {
                TriggerEffect effect = new TriggerEffect(
                    effectNode.Attributes.GetNamedItem("name").Value,
                    ParseParameters(effectNode),
                    ParseCommands(effectNode));

                if (effectNode.Attributes.GetNamedItem("directcode") != null)
                {
                    effect.DirectCode = true;
                }

                effects.Add(effect);
            }
            return effects.ToArray();
        }

        public TriggerAll Parse(string xmlString)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.LoadXml(xmlString);
            } catch (System.Xml.XmlException) {
                return new TriggerAll([], []);
            }
            XmlNode triggerNode = document.DocumentElement.SelectSingleNode("/trigger");
            if (triggerNode == null)
            {
                return new TriggerAll([], []);
            }
            TriggerCondition[] triggerConditions = ParseConditions(triggerNode.SelectSingleNode("conditions"));
            TriggerEffect[] triggerEffects = ParseEffects(triggerNode.SelectSingleNode("effects"));
            return new TriggerAll(triggerConditions, triggerEffects);
        }
    }
}
