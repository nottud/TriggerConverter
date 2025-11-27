using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TriggerConverter.trigger;

namespace TriggerConverter.process
{
    internal class MainProcess
    {
        private static string[] ID_TYPES = new string[] { VarType.UNIT };
        private static string[] ID_INCLUDE = new string[] { VarType.PROTOACTION, VarType.ANIMNAME, VarType.ANIMVARIATION };
        private static string[] FREE_PROTO_TYPES = new string[] { VarType.PROTOUNIT, VarType.UNITTYPE, VarType.ABSTRACTUNITTYPE, VarType.PROTOACTION, VarType.ONHITEFFECTPROTOUNIT, VarType.PROTOUNITNOFILTER };
        private static string[] FREE_PROTO_INCLUDE = new string[] { VarType.PROTOACTION, VarType.ANIMNAME, VarType.ANIMVARIATION };

        private GenerateManualConditionsAndEffects generator = new GenerateManualConditionsAndEffects();
        private RemoveDuplicateTriggers removeDuplicateTriggers = new RemoveDuplicateTriggers();

        public TriggerAll ProcessTriggers(TriggerAll triggerAll, bool conditional, bool stat, bool byId, bool freeProto, bool manual, string[] manualTypes, bool relax, string[] relaxTypes, bool removeDuplicates, bool addNotToConditions)
        {
            TriggerAll workingTriggerAll = triggerAll;
            if (stat)
            {
                GenerateStatEffects generateStatsEffects = new GenerateStatEffects();
                workingTriggerAll = generateStatsEffects.Generate(workingTriggerAll);
            }
            if (byId)
            {
                workingTriggerAll = generator.Generate(workingTriggerAll, ID_TYPES, "By ID", ID_INCLUDE);
            }      
            if (freeProto)
            {
                workingTriggerAll = generator.Generate(workingTriggerAll, FREE_PROTO_TYPES, "Freeproto", FREE_PROTO_INCLUDE);
            }
            if (relax && relaxTypes.Length > 0)
            {
                // Game doesn't like relaxing of existing parameters it seems - instead use manual for now
                //RelaxParameters relaxParameters = new RelaxParameters();
                //relaxParameters.RelaxDestructively(workingTriggerAll, relaxTypes);
                workingTriggerAll = generator.Generate(workingTriggerAll, relaxTypes, "Relaxed", []);
            }
            if (manual && manualTypes.Length > 0)
            {
                workingTriggerAll = generator.Generate(workingTriggerAll, manualTypes, "Freetext", []);
            }
            if (conditional)
            {
                GenerateConditionalEffects generateConditionalEffects = new GenerateConditionalEffects();
                workingTriggerAll = generateConditionalEffects.Generate(workingTriggerAll);
            }
            if (addNotToConditions)
            {
                GenerateAddNotToConditions generateAddNotToConditions = new GenerateAddNotToConditions();
                workingTriggerAll = generateAddNotToConditions.Generate(workingTriggerAll);
            }
            if (removeDuplicates)
            {
                workingTriggerAll = removeDuplicateTriggers.Remove(workingTriggerAll);
            }
            return workingTriggerAll;
        }
    }
}
