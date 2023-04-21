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
            this.TextBoxCategory = new System.Windows.Forms.TextBox();
            this.TextBoxDefinition = new System.Windows.Forms.TextBox();
            this.TextBoxSearch = new System.Windows.Forms.TextBox();
            this.ButtonOpen = new System.Windows.Forms.Button();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TextBoxStructure = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
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
            this.ListViewProperties.TabIndex = 11;
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
            // 
            // TextBoxCategory
            // 
            this.TextBoxCategory.Location = new System.Drawing.Point(477, 220);
            this.TextBoxCategory.Name = "TextBoxCategory";
            this.TextBoxCategory.Size = new System.Drawing.Size(155, 23);
            this.TextBoxCategory.TabIndex = 6;
            // 
            // TextBoxDefinition
            // 
            this.TextBoxDefinition.Location = new System.Drawing.Point(33, 238);
            this.TextBoxDefinition.Multiline = true;
            this.TextBoxDefinition.Name = "TextBoxDefinition";
            this.TextBoxDefinition.Size = new System.Drawing.Size(216, 171);
            this.TextBoxDefinition.TabIndex = 8;
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
            this.ButtonOpen.TabIndex = 9;
            this.ButtonOpen.Text = "Open";
            this.ButtonOpen.UseVisualStyleBackColor = true;
            this.ButtonOpen.Click += new System.EventHandler(this.ButtonOpen_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Enabled = false;
            this.ButtonSave.Location = new System.Drawing.Point(174, 415);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 10;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(458, 423);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 15);
            this.label5.TabIndex = 17;
            this.label5.Text = "Structure";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(33, 134);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Structure";
            // 
            // TextBoxStructure
            // 
            this.TextBoxStructure.Location = new System.Drawing.Point(447, 289);
            this.TextBoxStructure.Name = "TextBoxStructure";
            this.TextBoxStructure.Size = new System.Drawing.Size(155, 23);
            this.TextBoxStructure.TabIndex = 7;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(18, 36);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 19);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Linear";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(107, 36);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(85, 19);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Non-Linear";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(94, 105);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 23);
            this.comboBox1.TabIndex = 19;
            // 
            // FormCITEWiki2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.TextBoxStructure);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonOpen);
            this.Controls.Add(this.TextBoxSearch);
            this.Controls.Add(this.TextBoxDefinition);
            this.Controls.Add(this.TextBoxCategory);
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
        private TextBox TextBoxCategory;
        private TextBox TextBoxDefinition;
        private TextBox TextBoxSearch;
        private Button ButtonOpen;
        private Button ButtonSave;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private GroupBox groupBox1;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
        private TextBox TextBoxStructure;
        private ComboBox comboBox1;
    }
}