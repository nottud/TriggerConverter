using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using TriggerConverter.io;
using TriggerConverter.process;
using TriggerConverter.trigger;


namespace TriggerConverter
{
    public partial class Form1 : Form
    {
        XmlTools xmlTools = new XmlTools();
        RegexOptions regexOptions = RegexOptions.Multiline;

        private void CheckVarType(CheckedListBox checkedListBox, string varType)
        {
            int index = checkedListBox.Items.IndexOf(varType);
            if (index >= 0)
            {
                checkedListBox.SetItemChecked(index, true);
            }
        }

        private string[] GetCheckedVarTypes(CheckedListBox checkedListBox)
        {
            List<string> checkedItems = new List<string>();
            for (int i = 0; i < checkedListBox.Items.Count; i++)
            {
                if (checkedListBox.GetItemChecked(i))
                {
                    checkedItems.Add(checkedListBox.Items[i].ToString());
                }
            }
            return checkedItems.ToArray();
        }

        public Form1()
        {
            InitializeComponent();
            foreach (string varType in VarType.ALL)
            {
                checkedListBoxFreetext.Items.Add(varType);
                if (varType != VarType.SNIPPET && varType != VarType.SNIPPETSMALL && varType != VarType.STRINGID && varType != VarType.SOUND)
                {
                    CheckVarType(checkedListBoxFreetext, varType);
                }
                checkedListBoxRelax.Items.Add(varType);
            }
            CheckVarType(checkedListBoxRelax, VarType.FLOAT);
            CheckVarType(checkedListBoxRelax, VarType.LONG);
            CheckVarType(checkedListBoxRelax, VarType.PLAYER);
            CheckVarType(checkedListBoxRelax, VarType.STRING);
        }

        private void generateButton_Click(object sender, EventArgs e)
        {
            Reader reader = new Reader();
            TriggerAll originalTriggers = reader.Parse(textBoxOriginal.Text);
            TriggerAll customTriggers = reader.Parse(textBoxCustom.Text);
            TriggerAll combined = TriggerAll.Concat(originalTriggers, customTriggers);
            MainProcess mainProcess = new MainProcess();
            TriggerAll processed = mainProcess.ProcessTriggers(combined,
                checkBoxConditional.Checked,
                checkBoxStat.Checked,
                checkBoxById.Checked,
                checkBoxFreeproto.Checked,
                checkBoxFreetext.Checked,
                GetCheckedVarTypes(checkedListBoxFreetext),
                checkBoxRelax.Checked,
                GetCheckedVarTypes(checkedListBoxRelax),
                checkBoxRemoveDuplicates.Checked,
                checkBoxNotConditions.Checked);
            Writer writer = new Writer();
            textBoxResult.Text = writer.ToXml(TriggerAll.StripOriginal(processed, originalTriggers));
            tabControl1.SelectTab(tabPageResult);
        }

        private void convertToXmlButton_Click(object sender, EventArgs e)
        {
            string toConvertText = textBoxConvert.Text;
            string escapedText = xmlTools.EscapeXml(toConvertText);
            string[] lines = escapedText.Split("\r\n");
            for (int i = 0; i < lines.Length; i++)
            {
                lines[i] = "<command>" + lines[i] + "</command>";
            }
            textBoxConvert.Text = String.Join("\r\n", lines);
        }
    }
}
