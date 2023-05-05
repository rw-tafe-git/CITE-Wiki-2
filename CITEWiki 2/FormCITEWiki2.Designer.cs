namespace CITEWiki
{
    partial class FormCITEWiki2
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
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.NameLabel = new System.Windows.Forms.ColumnHeader();
            this.CategoryLabel = new System.Windows.Forms.ColumnHeader();
            this.ListViewProperties = new System.Windows.Forms.ListView();
            this.ButtonEdit = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.ButtonSearch = new System.Windows.Forms.Button();
            this.TextBoxName = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RbNonLinear = new System.Windows.Forms.RadioButton();
            this.RbLinear = new System.Windows.Forms.RadioButton();
            this.ComboBoxCategory = new System.Windows.Forms.ComboBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Msg = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonAdd_Click);
            // 
            // NameLabel
            // 
            this.NameLabel.Text = "Name";
            this.NameLabel.Width = 100;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.Text = "Category";
            this.CategoryLabel.Width = 100;
            // 
            // ListViewProperties
            // 
            this.ListViewProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameLabel,
            this.CategoryLabel});
            this.ListViewProperties.Location = new System.Drawing.Point(277, 58);
            this.ListViewProperties.Name = "ListViewProperties";
            this.ListViewProperties.Size = new System.Drawing.Size(245, 351);
            this.ListViewProperties.TabIndex = 13;
            this.ListViewProperties.UseCompatibleStateImageBehavior = false;
            this.ListViewProperties.View = System.Windows.Forms.View.Details;
            this.ListViewProperties.Click += new System.EventHandler(this.ListViewProperties_Click);
            // 
            // ButtonEdit
            // 
            this.ButtonEdit.Enabled = false;
            this.ButtonEdit.Location = new System.Drawing.Point(93, 12);
            this.ButtonEdit.Name = "ButtonEdit";
            this.ButtonEdit.Size = new System.Drawing.Size(75, 23);
            this.ButtonEdit.TabIndex = 1;
            this.ButtonEdit.Text = "Edit";
            this.ButtonEdit.UseVisualStyleBackColor = true;
            this.ButtonEdit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonEdit_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Enabled = false;
            this.ButtonDelete.Location = new System.Drawing.Point(174, 12);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(75, 23);
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSearch
            // 
            this.ButtonSearch.Location = new System.Drawing.Point(447, 11);
            this.ButtonSearch.Name = "ButtonSearch";
            this.ButtonSearch.Size = new System.Drawing.Size(75, 23);
            this.ButtonSearch.TabIndex = 4;
            this.ButtonSearch.Text = "Search";
            this.ButtonSearch.UseVisualStyleBackColor = true;
            this.ButtonSearch.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ButtonSearch_Click);
            // 
            // TextBoxName
            // 
            this.TextBoxName.Location = new System.Drawing.Point(94, 67);
            this.TextBoxName.Name = "TextBoxName";
            this.TextBoxName.Size = new System.Drawing.Size(155, 23);
            this.TextBoxName.TabIndex = 5;
            this.TextBoxName.DoubleClick += new System.EventHandler(this.TextBoxName_DoubleClick);
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(33, 238);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(216, 171);
            this.TextBoxDefinition.TabIndex = 10;
            // 
            // TextBoxSearch
            // 
            this.TextBoxSearch.Location = new System.Drawing.Point(277, 11);
            this.TextBoxSearch.Name = "TextBoxSearch";
            this.TextBoxSearch.Size = new System.Drawing.Size(164, 23);
            this.TextBoxSearch.TabIndex = 3;
            // 
            // ButtonOpen
            // 
            this.ButtonOpen.Location = new System.Drawing.Point(33, 415);
            this.ButtonOpen.Name = "ButtonOpen";
            this.ButtonOpen.Size = new System.Drawing.Size(75, 23);
            this.ButtonOpen.TabIndex = 11;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(174, 415);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 12;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 15);
            this.label3.TabIndex = 14;
            this.label3.Text = "Definition";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Category";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RbNonLinear);
            this.groupBox1.Controls.Add(this.RbLinear);
            this.groupBox1.Location = new System.Drawing.Point(33, 146);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 59);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Structure";
            // 
            // RbNonLinear
            // 
            this.RbNonLinear.AutoSize = true;
            this.RbNonLinear.Location = new System.Drawing.Point(108, 26);
            this.RbNonLinear.Name = "RbNonLinear";
            this.RbNonLinear.Size = new System.Drawing.Size(85, 19);
            this.RbNonLinear.TabIndex = 9;
            this.RbNonLinear.TabStop = true;
            this.RbNonLinear.Text = "Non-Linear";
            this.RbNonLinear.UseVisualStyleBackColor = true;
            // 
            // RbLinear
            // 
            this.RbLinear.AutoSize = true;
            this.RbLinear.Location = new System.Drawing.Point(19, 26);
            this.RbLinear.Name = "RbLinear";
            this.RbLinear.Size = new System.Drawing.Size(57, 19);
            this.RbLinear.TabIndex = 8;
            this.RbLinear.TabStop = true;
            this.RbLinear.Text = "Linear";
            this.RbLinear.UseVisualStyleBackColor = true;
            // 
            // ComboBoxCategory
            // 
            this.ComboBoxCategory.FormattingEnabled = true;
            this.ComboBoxCategory.Location = new System.Drawing.Point(94, 105);
            this.ComboBoxCategory.Name = "ComboBoxCategory";
            this.ComboBoxCategory.Size = new System.Drawing.Size(155, 23);
            this.ComboBoxCategory.TabIndex = 6;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Msg});
            this.statusStrip1.Location = new System.Drawing.Point(0, 448);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(552, 22);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Msg
            // 
            this.Msg.Name = "Msg";
            this.Msg.Size = new System.Drawing.Size(39, 17);
            this.Msg.Text = "Ready";
            // 
            // FormCITEWiki2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 470);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ComboBoxCategory);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxName);
            this.Controls.Add(this.ButtonSearch);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonEdit);
            this.Controls.Add(this.ListViewProperties);
            this.Controls.Add(this.ButtonAdd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormCITEWiki2";
            this.Text = "Wiki Lookup";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WikiForm_FormClosing);
            this.Load += new System.EventHandler(this.FormCITEWiki2_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button ButtonAdd;
        private ColumnHeader NameLabel;
        private ColumnHeader CategoryLabel;
        private ListView ListViewProperties;
        private Button ButtonEdit;
        private Button ButtonDelete;
        private Button ButtonSearch;
        private TextBox TextBoxName;
        private TextBox TextBoxDefinition;
        private TextBox TextBoxSearch;
        private Button ButtonOpen;
        private Button ButtonSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private GroupBox groupBox1;
        private RadioButton RbNonLinear;
        private RadioButton RbLinear;
        private ComboBox ComboBoxCategory;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel Msg;
    }
}