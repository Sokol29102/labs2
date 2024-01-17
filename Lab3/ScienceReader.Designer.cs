namespace Lab3
{
    partial class FilusReader
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.searchResultsViewer = new System.Windows.Forms.RichTextBox();
			this.searchCriteriaGroup = new System.Windows.Forms.GroupBox();
			this.linqToXmlBtn = new System.Windows.Forms.RadioButton();
			this.saxBtn = new System.Windows.Forms.RadioButton();
			this.domBtn = new System.Windows.Forms.RadioButton();
			this.profDropList = new System.Windows.Forms.ComboBox();
			this.profCheckBox = new System.Windows.Forms.CheckBox();
			this.degreeList = new System.Windows.Forms.ComboBox();
			this.degreeCheckBox = new System.Windows.Forms.CheckBox();
			this.zdilDropList = new System.Windows.Forms.ComboBox();
			this.zdilCheckBox = new System.Windows.Forms.CheckBox();
			this.scienDropList = new System.Windows.Forms.ComboBox();
			this.scienCheckBox = new System.Windows.Forms.CheckBox();
			this.searchBtn = new System.Windows.Forms.Button();
			this.forgeHtmlBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.searchCriteriaGroup.SuspendLayout();
			this.SuspendLayout();
			// 
			// searchResultsViewer
			// 
			this.searchResultsViewer.Location = new System.Drawing.Point(421, 24);
			this.searchResultsViewer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchResultsViewer.Name = "searchResultsViewer";
			this.searchResultsViewer.Size = new System.Drawing.Size(452, 484);
			this.searchResultsViewer.TabIndex = 0;
			this.searchResultsViewer.Text = "";
			// 
			// searchCriteriaGroup
			// 
			this.searchCriteriaGroup.Controls.Add(this.linqToXmlBtn);
			this.searchCriteriaGroup.Controls.Add(this.saxBtn);
			this.searchCriteriaGroup.Controls.Add(this.domBtn);
			this.searchCriteriaGroup.Controls.Add(this.profDropList);
			this.searchCriteriaGroup.Controls.Add(this.profCheckBox);
			this.searchCriteriaGroup.Controls.Add(this.degreeList);
			this.searchCriteriaGroup.Controls.Add(this.degreeCheckBox);
			this.searchCriteriaGroup.Controls.Add(this.zdilDropList);
			this.searchCriteriaGroup.Controls.Add(this.zdilCheckBox);
			this.searchCriteriaGroup.Controls.Add(this.scienDropList);
			this.searchCriteriaGroup.Controls.Add(this.scienCheckBox);
			this.searchCriteriaGroup.Location = new System.Drawing.Point(113, 24);
			this.searchCriteriaGroup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchCriteriaGroup.Name = "searchCriteriaGroup";
			this.searchCriteriaGroup.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchCriteriaGroup.Size = new System.Drawing.Size(304, 191);
			this.searchCriteriaGroup.TabIndex = 1;
			this.searchCriteriaGroup.TabStop = false;
			this.searchCriteriaGroup.Text = "Критерії пошуку";
			// 
			// linqToXmlBtn
			// 
			this.linqToXmlBtn.AutoSize = true;
			this.linqToXmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.linqToXmlBtn.Location = new System.Drawing.Point(130, 145);
			this.linqToXmlBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.linqToXmlBtn.Name = "linqToXmlBtn";
			this.linqToXmlBtn.Size = new System.Drawing.Size(119, 24);
			this.linqToXmlBtn.TabIndex = 10;
			this.linqToXmlBtn.Text = "LINQ to XML";
			this.linqToXmlBtn.UseVisualStyleBackColor = true;
			// 
			// saxBtn
			// 
			this.saxBtn.AutoSize = true;
			this.saxBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.saxBtn.Location = new System.Drawing.Point(70, 145);
			this.saxBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.saxBtn.Name = "saxBtn";
			this.saxBtn.Size = new System.Drawing.Size(60, 24);
			this.saxBtn.TabIndex = 9;
			this.saxBtn.Text = "SAX";
			this.saxBtn.UseVisualStyleBackColor = true;
			// 
			// domBtn
			// 
			this.domBtn.AutoSize = true;
			this.domBtn.Checked = true;
			this.domBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.domBtn.Location = new System.Drawing.Point(5, 145);
			this.domBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.domBtn.Name = "domBtn";
			this.domBtn.Size = new System.Drawing.Size(64, 24);
			this.domBtn.TabIndex = 8;
			this.domBtn.TabStop = true;
			this.domBtn.Text = "DOM";
			this.domBtn.UseVisualStyleBackColor = true;
			// 
			// profDropList
			// 
			this.profDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.profDropList.Enabled = false;
			this.profDropList.FormattingEnabled = true;
			this.profDropList.Location = new System.Drawing.Point(160, 102);
			this.profDropList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.profDropList.Name = "profDropList";
			this.profDropList.Size = new System.Drawing.Size(140, 21);
			this.profDropList.Sorted = true;
			this.profDropList.TabIndex = 7;
			// 
			// profCheckBox
			// 
			this.profCheckBox.AutoSize = true;
			this.profCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.profCheckBox.Location = new System.Drawing.Point(4, 99);
			this.profCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.profCheckBox.Name = "profCheckBox";
			this.profCheckBox.Size = new System.Drawing.Size(147, 24);
			this.profCheckBox.TabIndex = 6;
			this.profCheckBox.Text = "Академ Звання";
			this.profCheckBox.UseVisualStyleBackColor = true;
			this.profCheckBox.CheckedChanged += new System.EventHandler(this.labelCheckBox_CheckedChanged);
			// 
			// degreeList
			// 
			this.degreeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.degreeList.Enabled = false;
			this.degreeList.FormattingEnabled = true;
			this.degreeList.Location = new System.Drawing.Point(160, 74);
			this.degreeList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.degreeList.Name = "degreeList";
			this.degreeList.Size = new System.Drawing.Size(140, 21);
			this.degreeList.Sorted = true;
			this.degreeList.TabIndex = 5;
			// 
			// degreeCheckBox
			// 
			this.degreeCheckBox.AutoSize = true;
			this.degreeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.degreeCheckBox.Location = new System.Drawing.Point(4, 74);
			this.degreeCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.degreeCheckBox.Name = "degreeCheckBox";
			this.degreeCheckBox.Size = new System.Drawing.Size(149, 24);
			this.degreeCheckBox.TabIndex = 4;
			this.degreeCheckBox.Text = "Наукова ступінь";
			this.degreeCheckBox.UseVisualStyleBackColor = true;
			this.degreeCheckBox.CheckedChanged += new System.EventHandler(this.yearCheckBox_CheckedChanged);
			// 
			// zdilDropList
			// 
			this.zdilDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.zdilDropList.Enabled = false;
			this.zdilDropList.FormattingEnabled = true;
			this.zdilDropList.Location = new System.Drawing.Point(160, 46);
			this.zdilDropList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.zdilDropList.Name = "zdilDropList";
			this.zdilDropList.Size = new System.Drawing.Size(140, 21);
			this.zdilDropList.Sorted = true;
			this.zdilDropList.TabIndex = 3;
			// 
			// zdilCheckBox
			// 
			this.zdilCheckBox.AutoSize = true;
			this.zdilCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.zdilCheckBox.Location = new System.Drawing.Point(4, 46);
			this.zdilCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.zdilCheckBox.Name = "zdilCheckBox";
			this.zdilCheckBox.Size = new System.Drawing.Size(104, 24);
			this.zdilCheckBox.TabIndex = 2;
			this.zdilCheckBox.Text = "Підрозділ";
			this.zdilCheckBox.UseVisualStyleBackColor = true;
			this.zdilCheckBox.CheckedChanged += new System.EventHandler(this.genreCheckBox_CheckedChanged);
			// 
			// scienDropList
			// 
			this.scienDropList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.scienDropList.Enabled = false;
			this.scienDropList.FormattingEnabled = true;
			this.scienDropList.Location = new System.Drawing.Point(160, 17);
			this.scienDropList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scienDropList.Name = "scienDropList";
			this.scienDropList.Size = new System.Drawing.Size(140, 21);
			this.scienDropList.Sorted = true;
			this.scienDropList.TabIndex = 1;
			// 
			// scienCheckBox
			// 
			this.scienCheckBox.AutoSize = true;
			this.scienCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.scienCheckBox.Location = new System.Drawing.Point(4, 17);
			this.scienCheckBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.scienCheckBox.Name = "scienCheckBox";
			this.scienCheckBox.Size = new System.Drawing.Size(73, 24);
			this.scienCheckBox.TabIndex = 0;
			this.scienCheckBox.Text = "Наука";
			this.scienCheckBox.UseVisualStyleBackColor = true;
			this.scienCheckBox.CheckedChanged += new System.EventHandler(this.artistCheckBox_CheckedChanged);
			// 
			// searchBtn
			// 
			this.searchBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.searchBtn.Location = new System.Drawing.Point(160, 219);
			this.searchBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.searchBtn.Name = "searchBtn";
			this.searchBtn.Size = new System.Drawing.Size(149, 49);
			this.searchBtn.TabIndex = 2;
			this.searchBtn.Text = "Пошук";
			this.searchBtn.UseVisualStyleBackColor = true;
			this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
			// 
			// forgeHtmlBtn
			// 
			this.forgeHtmlBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.forgeHtmlBtn.Location = new System.Drawing.Point(160, 284);
			this.forgeHtmlBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.forgeHtmlBtn.Name = "forgeHtmlBtn";
			this.forgeHtmlBtn.Size = new System.Drawing.Size(149, 47);
			this.forgeHtmlBtn.TabIndex = 3;
			this.forgeHtmlBtn.Text = "Завантажити HTML";
			this.forgeHtmlBtn.UseVisualStyleBackColor = true;
			this.forgeHtmlBtn.Click += new System.EventHandler(this.forgeHtmlBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(418, 7);
			this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(98, 13);
			this.label1.TabIndex = 4;
			this.label1.Text = "Результат пошуку";
			// 
			// FilusReader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(898, 533);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.forgeHtmlBtn);
			this.Controls.Add(this.searchBtn);
			this.Controls.Add(this.searchCriteriaGroup);
			this.Controls.Add(this.searchResultsViewer);
			this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
			this.Name = "FilusReader";
			this.Text = "XML Scientists";
			this.Load += new System.EventHandler(this.PlaylistReader_Load);
			this.searchCriteriaGroup.ResumeLayout(false);
			this.searchCriteriaGroup.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox searchResultsViewer;
        private System.Windows.Forms.GroupBox searchCriteriaGroup;
        private System.Windows.Forms.ComboBox scienDropList;
        private System.Windows.Forms.CheckBox scienCheckBox;
        private System.Windows.Forms.RadioButton linqToXmlBtn;
        private System.Windows.Forms.RadioButton saxBtn;
        private System.Windows.Forms.RadioButton domBtn;
        private System.Windows.Forms.ComboBox profDropList;
        private System.Windows.Forms.CheckBox profCheckBox;
        private System.Windows.Forms.ComboBox degreeList;
        private System.Windows.Forms.CheckBox degreeCheckBox;
        private System.Windows.Forms.ComboBox zdilDropList;
        private System.Windows.Forms.CheckBox zdilCheckBox;
        private System.Windows.Forms.Button searchBtn;
        private System.Windows.Forms.Button forgeHtmlBtn;
        private System.Windows.Forms.Label label1;
    }
}

