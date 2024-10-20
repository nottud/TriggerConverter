using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriggerConverter.trigger
{
    internal class VarType
    {

        private static string Add(List<string> list, string value)
        {
            list.Add(value);
            return value;
        }

        public static List<string> ALL = new List<string>();
        public static string ABILITY = Add(ALL, "ability");
        public static string ABSTRACTUNITTYPE = Add(ALL, "abstractunittype");
        public static string ALLIANCE = Add(ALL, "alliance");
        public static string ANIMNAME = Add(ALL, "animname");
        public static string ANIMVARIATION = Add(ALL, "animvariation");
        public static string AREA = Add(ALL, "area");
        public static string ARITHMETICOPERATOR = Add(ALL, "arithmeticoperator");
        public static string BOOL = Add(ALL, "bool");
        public static string CAMERAINFO = Add(ALL, "camerainfo");
        public static string CAMSTATE = Add(ALL, "camstate");
        public static string CAMTRACK = Add(ALL, "camtrack");
        public static string CIVILIZATION = Add(ALL, "civilization");
        public static string CULTURE = Add(ALL, "culture");
        public static string DAMAGETYPE = Add(ALL, "damagetype");
        public static string DIFFICULTY = Add(ALL, "difficulty");
        public static string EVENT = Add(ALL, "event");
        public static string FAKEPLAYERID = Add(ALL, "fakeplayerid");
        public static string FLOAT = Add(ALL, "float");
        public static string FREEZETYPE = Add(ALL, "freezetype");
        public static string GODPOWER = Add(ALL, "godpower");
        public static string GROUP = Add(ALL, "group");
        public static string INPUTCONTEXT = Add(ALL, "inputcontext");
        public static string KBSTAT = Add(ALL, "kbstat");
        public static string LONG = Add(ALL, "long");
        public static string MODIFYTYPE = Add(ALL, "modifytype");
        public static string MOVEMENTTYPE = Add(ALL, "movementtype");
        public static string MUSICMOOD = Add(ALL, "musicmood");
        public static string MUSICTRACKID = Add(ALL, "musictrackid");
        public static string OBJECTIVE = Add(ALL, "objective");
        public static string ONHITEFFECTALL = Add(ALL, "onhiteffectall");
        public static string ONHITEFFECTDURATION = Add(ALL, "onhiteffectduration");
        public static string ONHITEFFECTMODIFY = Add(ALL, "onhiteffectmodify");
        public static string ONHITEFFECTPROTOUNIT = Add(ALL, "onhiteffectprotounit");
        public static string ONHITEFFECTSIMPLE = Add(ALL, "onhiteffectsimple");
        public static string OPERATOR = Add(ALL, "operator");
        public static string PLAYER = Add(ALL, "player");
        public static string PLAYERTYPE = Add(ALL, "playerType");
        public static string PLAYERCOLORTYPE = Add(ALL, "playercolortype");
        public static string PLAYERDATAFIELD = Add(ALL, "playerdatafield");
        public static string PLAYERRESOURCEDATA = Add(ALL, "playerresourcedata");
        public static string POPUPTYPE = Add(ALL, "popuptype");
        public static string PROTOACTION = Add(ALL, "protoaction");
        public static string PROTOUNIT = Add(ALL, "protounit");
        public static string PROTOUNITCOMMAND = Add(ALL, "protounitcommand");
        public static string PROTOUNITFLAG = Add(ALL, "protounitflag");
        public static string PROTOUNITNOFILTER = Add(ALL, "protounitnofilter");
        public static string PUACTIONFIELD = Add(ALL, "puactionfield");
        public static string PUACTIONUNITTYPEFIELD = Add(ALL, "puactionunittypefield");
        public static string PUDATAFIELD = Add(ALL, "pudatafield");
        public static string PURELATIVITY = Add(ALL, "purelativity");
        public static string PURESOURCEFIELD = Add(ALL, "puresourcefield");
        public static string RECTAREA = Add(ALL, "rectarea");
        public static string RELIC = Add(ALL, "relic");
        public static string RESOURCE = Add(ALL, "resource");
        public static string RESOURCEID = Add(ALL, "resourceid");
        public static string SHADINGTYPE = Add(ALL, "shadingtype");
        public static string SKYBOX = Add(ALL, "skybox");
        public static string SNIPPET = Add(ALL, "snippet");
        public static string SNIPPETSMALL = Add(ALL, "snippetsmall");
        public static string SOUND = Add(ALL, "sound");
        public static string SOUNDSET = Add(ALL, "soundset");
        public static string STRING = Add(ALL, "string");
        public static string STRINGID = Add(ALL, "stringid");
        public static string TECH = Add(ALL, "tech");
        public static string TECHSTATUS = Add(ALL, "techstatus");
        public static string TECHSTRINGFIELD = Add(ALL, "techstringfield");
        public static string TERRAINSUBTYPE = Add(ALL, "terrainsubtype");
        public static string UNIT = Add(ALL, "unit");
        public static string UNITEFFECT = Add(ALL, "uniteffect");
        public static string UNITEFFECTDAMAGE = Add(ALL, "uniteffectdamage");
        public static string UNITEFFECTPROTOUNIT = Add(ALL, "uniteffectprotounit");
        public static string UNITSTANCE = Add(ALL, "unitstance");
        public static string UNITTYPE = Add(ALL, "unittype");
        public static string VPPRESET = Add(ALL, "vppreset");
        public static string WATER = Add(ALL, "water");
        public static string WPFDIALOG = Add(ALL, "wpfdialog");
        public static string WPFGAMEPADPROMPT = Add(ALL, "wpfgamepadprompt");
        public static string WPFIDLEBANNER = Add(ALL, "wpfidlebanner");
        public static string WPFPANEL = Add(ALL, "wpfpanel");
        public static string WPFRADIALMENU = Add(ALL, "wpfradialmenu");
        public static string WPFRESOURCEENTRY = Add(ALL, "wpfresourceentry");
        public static string WPFVPBUTTON = Add(ALL, "wpfvpbutton");
    }

}
