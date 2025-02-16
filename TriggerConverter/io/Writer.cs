using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.io
{


    internal class Writer
    {
        private XmlTools xmlTools = new XmlTools();

        private void Write(List<string> lines, int indent, string content)
        {
            lines.Add(content.PadLeft(content.Length + indent * 2, ' '));
        }

        private void WriteHeader(List<string> lines)
        {
            Write(lines, 0, "<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            Write(lines, 0, "<triggermods>");
        }

        private void WriteParameters(List<string> lines, TriggerParameter[] triggerParameters)
        {
            foreach (TriggerParameter parameter in triggerParameters)
            {
                Write(lines, 3, "<Param name=\"" + parameter.Name + "\" dispname=\"" + xmlTools.EscapeXmlAttribute(parameter.Display) + "\" vartype=\"" + parameter.VarType + "\"" + (parameter.DisplayRadius ? " dispradius=\"\"" : "") + (parameter.DoNotRelax ? " donotrelax=\"\"" : "") + ">" + xmlTools.EscapeXml(parameter.DefaultValue) + "</Param>");
            }
        }

        private void WriteCommands(List<string> lines, TriggerCommand[] triggerCommands, bool directCode)
        {
            foreach (TriggerCommand parameter in triggerCommands)
            {
                string commandCode = xmlTools.EscapeXml(parameter.CommandCode);
                if(!directCode && commandCode.StartsWith("%"))
                {
                    commandCode = "/**/" + commandCode;
                }
                Write(lines, 3, "<Command" + (parameter.Loop ? " loop=\"\"" : "") + (parameter.LoopSourceObject != null ? " loopparm=\""+ parameter.LoopSourceObject + "\"" : "") + ">" + commandCode + "</Command>");
            }
        }

        private void WriteConditions(List<string> lines, TriggerCondition[] conditions)
        {
            Write(lines, 1, "<Conditions>");
            foreach (TriggerCondition condition in conditions)
            {
                Write(lines, 2, "<Condition name=\"" + condition.Name + "\"" + (condition.DirectCode ? " directcode=\"\"" : "") + ">");
                WriteParameters(lines, condition.Params);
                WriteCommands(lines, condition.Commands, condition.DirectCode);
                Write(lines, 3, "<Expression>" + xmlTools.EscapeXml(condition.Expression.Expression) + "</Expression>");
                Write(lines, 2, "</Condition>");
            }
            Write(lines, 1, "</Conditions>");
        }

        private void WriteEffects(List<string> lines, TriggerEffect[] effects)
        {
            Write(lines, 1, "<Effects>");
            foreach (TriggerEffect effect in effects)
            {
                Write(lines, 2, "<Effect name=\"" + effect.Name + "\"" + (effect.DirectCode ? " directcode=\"\"" : "") + ">");
                WriteParameters(lines, effect.Params);
                WriteCommands(lines, effect.Commands, effect.DirectCode);
                Write(lines, 2, "</Effect>");
            }
            Write(lines, 1, "</Effects>");
        }

        private void WriteFooter(List<string> lines)
        {
            Write(lines, 0, "</triggermods>");
        }
        public string ToXml(TriggerAll triggerAll)
        {
            List<string> lines = new List<string>();
            WriteHeader(lines);
            WriteConditions(lines, triggerAll.Conditions);
            WriteEffects(lines, triggerAll.Effects);
            WriteFooter(lines);
            return String.Join("\r\n", lines);
        }
    }
}
