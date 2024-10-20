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
            Write(lines, 0, "<trigger version=\"2\">");
        }

        private void WriteParameters(List<string> lines, TriggerParameter[] triggerParameters)
        {
            foreach (TriggerParameter parameter in triggerParameters)
            {
                Write(lines, 3, "<param name=\"" + parameter.Name + "\" dispname=\"" + parameter.Display + "\" vartype=\"" + parameter.VarType + "\"" + (parameter.DisplayRadius ? " dispradius=\"\"" : "") + (parameter.DoNotRelax ? " donotrelax=\"\"" : "") + ">" + xmlTools.EscapeXml(parameter.DefaultValue) + "</param>");
            }
        }

        private void WriteCommands(List<string> lines, TriggerCommand[] triggerCommands)
        {
            foreach (TriggerCommand parameter in triggerCommands)
            {
                Write(lines, 3, "<command" + (parameter.Loop ? " loop=\"\"" : "") + (parameter.LoopSourceObject != null ? " loopparm=\""+ parameter.LoopSourceObject + "\"" : "") + ">" + xmlTools.EscapeXml(parameter.CommandCode) + "</command>");
            }
        }

        private void WriteConditions(List<string> lines, TriggerCondition[] conditions)
        {
            Write(lines, 1, "<conditions>");
            foreach (TriggerCondition condition in conditions)
            {
                Write(lines, 2, "<condition name=\"" + condition.Name + "\"" + (condition.DirectCode ? " directcode=\"\"" : "") + ">");
                WriteParameters(lines, condition.Params);
                WriteCommands(lines, condition.Commands);
                Write(lines, 3, "<expression>" + xmlTools.EscapeXml(condition.Expression.Expression) + "</expression>");
                Write(lines, 2, "</condition>");
            }
            Write(lines, 1, "</conditions>");
        }

        private void WriteEffects(List<string> lines, TriggerEffect[] effects)
        {
            Write(lines, 1, "<effects>");
            foreach (TriggerEffect effect in effects)
            {
                Write(lines, 2, "<effect name=\"" + effect.Name + "\"" + (effect.DirectCode ? " directcode=\"\"" : "") + ">");
                WriteParameters(lines, effect.Params);
                WriteCommands(lines, effect.Commands);
                Write(lines, 2, "</effect>");
            }
            Write(lines, 1, "</effects>");
        }

        private void WriteFooter(List<string> lines)
        {
            Write(lines, 0, "</trigger>");
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
