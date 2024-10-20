namespace TriggerConverter
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            textBoxOriginal = new TextBox();
            groupBox2 = new GroupBox();
            textBoxCustom = new TextBox();
            tabControl1 = new TabControl();
            tabPageSource = new TabPage();
            splitContainer3 = new SplitContainer();
            tabPageOptions = new TabPage();
            optionsBox = new GroupBox();
            splitContainer1 = new SplitContainer();
            groupBox3 = new GroupBox();
            checkedListBoxFreetext = new CheckedListBox();
            groupBox5 = new GroupBox();
            checkedListBoxRelax = new CheckedListBox();
            groupBox4 = new GroupBox();
            checkBoxStat = new CheckBox();
            checkBoxRemoveDuplicates = new CheckBox();
            checkBoxFreeproto = new CheckBox();
            checkBoxConditional = new CheckBox();
            checkBoxFreetext = new CheckBox();
            checkBoxById = new CheckBox();
            checkBoxRelax = new CheckBox();
            tabPageResult = new TabPage();
            resultBox = new GroupBox();
            textBoxResult = new TextBox();
            generateButton = new Button();
            panel2 = new Panel();
            tabControl2 = new TabControl();
            tabPageMain = new TabPage();
            tabPageTools = new TabPage();
            groupBox6 = new GroupBox();
            textBoxConvert = new TextBox();
            panel1 = new Panel();
            convertToXmlButton = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPageSource.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            tabPageOptions.SuspendLayout();
            optionsBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox5.SuspendLayout();
            groupBox4.SuspendLayout();
            tabPageResult.SuspendLayout();
            resultBox.SuspendLayout();
            panel2.SuspendLayout();
            tabControl2.SuspendLayout();
            tabPageMain.SuspendLayout();
            tabPageTools.SuspendLayout();
            groupBox6.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBoxOriginal);
            groupBox1.Dock = DockStyle.Fill;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(623, 719);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Original Triggers";
            // 
            // textBoxOriginal
            // 
            textBoxOriginal.Dock = DockStyle.Fill;
            textBoxOriginal.Font = new Font("Consolas", 9F);
            textBoxOriginal.Location = new Point(3, 27);
            textBoxOriginal.MaxLength = 0;
            textBoxOriginal.Multiline = true;
            textBoxOriginal.Name = "textBoxOriginal";
            textBoxOriginal.ScrollBars = ScrollBars.Both;
            textBoxOriginal.Size = new Size(617, 689);
            textBoxOriginal.TabIndex = 0;
            textBoxOriginal.WordWrap = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxCustom);
            groupBox2.Dock = DockStyle.Fill;
            groupBox2.Location = new Point(0, 0);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(632, 719);
            groupBox2.TabIndex = 0;
            groupBox2.TabStop = false;
            groupBox2.Text = "Custom Triggers";
            // 
            // textBoxCustom
            // 
            textBoxCustom.Dock = DockStyle.Fill;
            textBoxCustom.Font = new Font("Consolas", 9F);
            textBoxCustom.Location = new Point(3, 27);
            textBoxCustom.MaxLength = 0;
            textBoxCustom.Multiline = true;
            textBoxCustom.Name = "textBoxCustom";
            textBoxCustom.ScrollBars = ScrollBars.Both;
            textBoxCustom.Size = new Size(626, 689);
            textBoxCustom.TabIndex = 0;
            textBoxCustom.WordWrap = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPageSource);
            tabControl1.Controls.Add(tabPageOptions);
            tabControl1.Controls.Add(tabPageResult);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(3, 3);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(1273, 763);
            tabControl1.TabIndex = 1;
            // 
            // tabPageSource
            // 
            tabPageSource.Controls.Add(splitContainer3);
            tabPageSource.Location = new Point(4, 34);
            tabPageSource.Name = "tabPageSource";
            tabPageSource.Padding = new Padding(3);
            tabPageSource.Size = new Size(1265, 725);
            tabPageSource.TabIndex = 0;
            tabPageSource.Text = "Source";
            tabPageSource.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 3);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(groupBox1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(groupBox2);
            splitContainer3.Size = new Size(1259, 719);
            splitContainer3.SplitterDistance = 623;
            splitContainer3.TabIndex = 1;
            // 
            // tabPageOptions
            // 
            tabPageOptions.Controls.Add(optionsBox);
            tabPageOptions.Location = new Point(4, 34);
            tabPageOptions.Name = "tabPageOptions";
            tabPageOptions.Size = new Size(1265, 725);
            tabPageOptions.TabIndex = 2;
            tabPageOptions.Text = "Options";
            tabPageOptions.UseVisualStyleBackColor = true;
            // 
            // optionsBox
            // 
            optionsBox.Controls.Add(splitContainer1);
            optionsBox.Controls.Add(groupBox4);
            optionsBox.Dock = DockStyle.Fill;
            optionsBox.Location = new Point(0, 0);
            optionsBox.Name = "optionsBox";
            optionsBox.Size = new Size(1265, 725);
            optionsBox.TabIndex = 2;
            optionsBox.TabStop = false;
            optionsBox.Text = "Options";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(228, 27);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(groupBox3);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(groupBox5);
            splitContainer1.Size = new Size(1034, 695);
            splitContainer1.SplitterDistance = 508;
            splitContainer1.TabIndex = 8;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(checkedListBoxFreetext);
            groupBox3.Dock = DockStyle.Fill;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(508, 695);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Freetext Parameters";
            // 
            // checkedListBoxFreetext
            // 
            checkedListBoxFreetext.Dock = DockStyle.Fill;
            checkedListBoxFreetext.FormattingEnabled = true;
            checkedListBoxFreetext.Location = new Point(3, 27);
            checkedListBoxFreetext.Name = "checkedListBoxFreetext";
            checkedListBoxFreetext.Size = new Size(502, 665);
            checkedListBoxFreetext.TabIndex = 0;
            // 
            // groupBox5
            // 
            groupBox5.Controls.Add(checkedListBoxRelax);
            groupBox5.Dock = DockStyle.Fill;
            groupBox5.Location = new Point(0, 0);
            groupBox5.Name = "groupBox5";
            groupBox5.Size = new Size(522, 695);
            groupBox5.TabIndex = 7;
            groupBox5.TabStop = false;
            groupBox5.Text = "Relax Parameters";
            // 
            // checkedListBoxRelax
            // 
            checkedListBoxRelax.Dock = DockStyle.Fill;
            checkedListBoxRelax.FormattingEnabled = true;
            checkedListBoxRelax.Location = new Point(3, 27);
            checkedListBoxRelax.Name = "checkedListBoxRelax";
            checkedListBoxRelax.Size = new Size(516, 665);
            checkedListBoxRelax.TabIndex = 0;
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(checkBoxStat);
            groupBox4.Controls.Add(checkBoxRemoveDuplicates);
            groupBox4.Controls.Add(checkBoxFreeproto);
            groupBox4.Controls.Add(checkBoxConditional);
            groupBox4.Controls.Add(checkBoxFreetext);
            groupBox4.Controls.Add(checkBoxById);
            groupBox4.Controls.Add(checkBoxRelax);
            groupBox4.Dock = DockStyle.Left;
            groupBox4.Location = new Point(3, 27);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(225, 695);
            groupBox4.TabIndex = 5;
            groupBox4.TabStop = false;
            groupBox4.Text = "Processes";
            // 
            // checkBoxStat
            // 
            checkBoxStat.AutoSize = true;
            checkBoxStat.Checked = true;
            checkBoxStat.CheckState = CheckState.Checked;
            checkBoxStat.Location = new Point(6, 65);
            checkBoxStat.Name = "checkBoxStat";
            checkBoxStat.Size = new Size(125, 29);
            checkBoxStat.TabIndex = 7;
            checkBoxStat.Text = "Stat Effects";
            checkBoxStat.UseVisualStyleBackColor = true;
            // 
            // checkBoxRemoveDuplicates
            // 
            checkBoxRemoveDuplicates.AutoSize = true;
            checkBoxRemoveDuplicates.Location = new Point(6, 240);
            checkBoxRemoveDuplicates.Name = "checkBoxRemoveDuplicates";
            checkBoxRemoveDuplicates.Size = new Size(189, 29);
            checkBoxRemoveDuplicates.TabIndex = 6;
            checkBoxRemoveDuplicates.Text = "Remove Duplicates";
            checkBoxRemoveDuplicates.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreeproto
            // 
            checkBoxFreeproto.AutoSize = true;
            checkBoxFreeproto.Checked = true;
            checkBoxFreeproto.CheckState = CheckState.Checked;
            checkBoxFreeproto.Location = new Point(6, 135);
            checkBoxFreeproto.Name = "checkBoxFreeproto";
            checkBoxFreeproto.Size = new Size(116, 29);
            checkBoxFreeproto.TabIndex = 5;
            checkBoxFreeproto.Text = "Freeproto";
            checkBoxFreeproto.UseVisualStyleBackColor = true;
            // 
            // checkBoxConditional
            // 
            checkBoxConditional.AutoSize = true;
            checkBoxConditional.Checked = true;
            checkBoxConditional.CheckState = CheckState.Checked;
            checkBoxConditional.Location = new Point(6, 30);
            checkBoxConditional.Name = "checkBoxConditional";
            checkBoxConditional.Size = new Size(186, 29);
            checkBoxConditional.TabIndex = 0;
            checkBoxConditional.Text = "Conditional Effects";
            checkBoxConditional.UseVisualStyleBackColor = true;
            // 
            // checkBoxFreetext
            // 
            checkBoxFreetext.AutoSize = true;
            checkBoxFreetext.Checked = true;
            checkBoxFreetext.CheckState = CheckState.Checked;
            checkBoxFreetext.Location = new Point(6, 170);
            checkBoxFreetext.Name = "checkBoxFreetext";
            checkBoxFreetext.Size = new Size(100, 29);
            checkBoxFreetext.TabIndex = 4;
            checkBoxFreetext.Text = "Freetext";
            checkBoxFreetext.UseVisualStyleBackColor = true;
            // 
            // checkBoxById
            // 
            checkBoxById.AutoSize = true;
            checkBoxById.Checked = true;
            checkBoxById.CheckState = CheckState.Checked;
            checkBoxById.Location = new Point(6, 100);
            checkBoxById.Name = "checkBoxById";
            checkBoxById.Size = new Size(80, 29);
            checkBoxById.TabIndex = 1;
            checkBoxById.Text = "By ID";
            checkBoxById.UseVisualStyleBackColor = true;
            // 
            // checkBoxRelax
            // 
            checkBoxRelax.AutoSize = true;
            checkBoxRelax.Checked = true;
            checkBoxRelax.CheckState = CheckState.Checked;
            checkBoxRelax.Location = new Point(6, 205);
            checkBoxRelax.Name = "checkBoxRelax";
            checkBoxRelax.Size = new Size(162, 29);
            checkBoxRelax.TabIndex = 2;
            checkBoxRelax.Text = "Parameter Relax";
            checkBoxRelax.UseVisualStyleBackColor = true;
            // 
            // tabPageResult
            // 
            tabPageResult.Controls.Add(resultBox);
            tabPageResult.Location = new Point(4, 34);
            tabPageResult.Name = "tabPageResult";
            tabPageResult.Padding = new Padding(3);
            tabPageResult.Size = new Size(1265, 725);
            tabPageResult.TabIndex = 1;
            tabPageResult.Text = "Result";
            tabPageResult.UseVisualStyleBackColor = true;
            // 
            // resultBox
            // 
            resultBox.Controls.Add(textBoxResult);
            resultBox.Dock = DockStyle.Fill;
            resultBox.Location = new Point(3, 3);
            resultBox.Name = "resultBox";
            resultBox.Size = new Size(1259, 719);
            resultBox.TabIndex = 0;
            resultBox.TabStop = false;
            resultBox.Text = "Result";
            // 
            // textBoxResult
            // 
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Font = new Font("Consolas", 9F);
            textBoxResult.Location = new Point(3, 27);
            textBoxResult.MaxLength = 0;
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ScrollBars = ScrollBars.Both;
            textBoxResult.Size = new Size(1253, 689);
            textBoxResult.TabIndex = 0;
            textBoxResult.WordWrap = false;
            // 
            // generateButton
            // 
            generateButton.Dock = DockStyle.Right;
            generateButton.Location = new Point(1161, 0);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(112, 56);
            generateButton.TabIndex = 1;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = true;
            generateButton.Click += generateButton_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(generateButton);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(3, 766);
            panel2.Name = "panel2";
            panel2.Size = new Size(1273, 56);
            panel2.TabIndex = 2;
            // 
            // tabControl2
            // 
            tabControl2.Controls.Add(tabPageMain);
            tabControl2.Controls.Add(tabPageTools);
            tabControl2.Dock = DockStyle.Fill;
            tabControl2.Location = new Point(0, 0);
            tabControl2.Name = "tabControl2";
            tabControl2.SelectedIndex = 0;
            tabControl2.Size = new Size(1287, 863);
            tabControl2.TabIndex = 3;
            // 
            // tabPageMain
            // 
            tabPageMain.Controls.Add(tabControl1);
            tabPageMain.Controls.Add(panel2);
            tabPageMain.Location = new Point(4, 34);
            tabPageMain.Name = "tabPageMain";
            tabPageMain.Padding = new Padding(3);
            tabPageMain.Size = new Size(1279, 825);
            tabPageMain.TabIndex = 0;
            tabPageMain.Text = "Main";
            tabPageMain.UseVisualStyleBackColor = true;
            // 
            // tabPageTools
            // 
            tabPageTools.Controls.Add(groupBox6);
            tabPageTools.Controls.Add(panel1);
            tabPageTools.Location = new Point(4, 34);
            tabPageTools.Name = "tabPageTools";
            tabPageTools.Padding = new Padding(3);
            tabPageTools.Size = new Size(1279, 825);
            tabPageTools.TabIndex = 1;
            tabPageTools.Text = "Tools";
            tabPageTools.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            groupBox6.Controls.Add(textBoxConvert);
            groupBox6.Dock = DockStyle.Fill;
            groupBox6.Location = new Point(3, 3);
            groupBox6.Name = "groupBox6";
            groupBox6.Size = new Size(1273, 761);
            groupBox6.TabIndex = 0;
            groupBox6.TabStop = false;
            groupBox6.Text = "Input Box";
            // 
            // textBoxConvert
            // 
            textBoxConvert.Dock = DockStyle.Fill;
            textBoxConvert.Font = new Font("Consolas", 9F);
            textBoxConvert.Location = new Point(3, 27);
            textBoxConvert.MaxLength = 0;
            textBoxConvert.Multiline = true;
            textBoxConvert.Name = "textBoxConvert";
            textBoxConvert.ScrollBars = ScrollBars.Both;
            textBoxConvert.Size = new Size(1267, 731);
            textBoxConvert.TabIndex = 1;
            textBoxConvert.WordWrap = false;
            // 
            // panel1
            // 
            panel1.Controls.Add(convertToXmlButton);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(3, 764);
            panel1.Name = "panel1";
            panel1.Size = new Size(1273, 58);
            panel1.TabIndex = 1;
            // 
            // convertToXmlButton
            // 
            convertToXmlButton.Dock = DockStyle.Right;
            convertToXmlButton.Location = new Point(970, 0);
            convertToXmlButton.Name = "convertToXmlButton";
            convertToXmlButton.Size = new Size(303, 58);
            convertToXmlButton.TabIndex = 0;
            convertToXmlButton.Text = "Convert code to XML commands";
            convertToXmlButton.UseVisualStyleBackColor = true;
            convertToXmlButton.Click += convertToXmlButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1287, 863);
            Controls.Add(tabControl2);
            Name = "Form1";
            Text = "Trigger Converter";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPageSource.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            tabPageOptions.ResumeLayout(false);
            optionsBox.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            groupBox5.ResumeLayout(false);
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            tabPageResult.ResumeLayout(false);
            resultBox.ResumeLayout(false);
            resultBox.PerformLayout();
            panel2.ResumeLayout(false);
            tabControl2.ResumeLayout(false);
            tabPageMain.ResumeLayout(false);
            tabPageTools.ResumeLayout(false);
            groupBox6.ResumeLayout(false);
            groupBox6.PerformLayout();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TabControl tabControl1;
        private TabPage tabPageSource;
        private TabPage tabPageResult;
        private GroupBox resultBox;
        private SplitContainer splitContainer3;
        private TextBox textBoxOriginal;
        private TextBox textBoxCustom;
        private GroupBox optionsBox;
        private Button generateButton;
        private TextBox textBoxResult;
        private CheckBox checkBoxRelax;
        private CheckBox checkBoxById;
        private CheckBox checkBoxConditional;
        private TabPage tabPageOptions;
        private Panel panel2;
        private GroupBox groupBox3;
        private CheckBox checkBoxFreetext;
        private GroupBox groupBox5;
        private GroupBox groupBox4;
        private SplitContainer splitContainer1;
        private CheckedListBox checkedListBoxFreetext;
        private CheckedListBox checkedListBoxRelax;
        private TabControl tabControl2;
        private TabPage tabPageMain;
        private TabPage tabPageTools;
        private GroupBox groupBox6;
        private TextBox textBoxConvert;
        private Panel panel1;
        private Button convertToXmlButton;
        private CheckBox checkBoxFreeproto;
        private CheckBox checkBoxRemoveDuplicates;
        private CheckBox checkBoxStat;
    }
}
