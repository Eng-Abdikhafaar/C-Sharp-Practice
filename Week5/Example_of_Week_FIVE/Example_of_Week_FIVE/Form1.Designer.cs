namespace Example_of_Week_FIVE
{
    partial class Form1
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
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtSalary = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chckShareca = new System.Windows.Forms.CheckBox();
            this.ChckIt = new System.Windows.Forms.CheckBox();
            this.ChckComputer = new System.Windows.Forms.CheckBox();
            this.RdoFemale = new System.Windows.Forms.RadioButton();
            this.RdoMale = new System.Windows.Forms.RadioButton();
            this.LstResult = new System.Windows.Forms.ListBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.RMVATBtn = new System.Windows.Forms.Button();
            this.RemoveBtn = new System.Windows.Forms.Button();
            this.BtnSelect = new System.Windows.Forms.Button();
            this.BtnCount = new System.Windows.Forms.Button();
            this.SlectBtn = new System.Windows.Forms.Button();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.ValidationBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(373, 71);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(463, 34);
            this.TxtName.TabIndex = 0;
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(373, 122);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(463, 34);
            this.TxtAge.TabIndex = 1;
            // 
            // TxtSalary
            // 
            this.TxtSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtSalary.Location = new System.Drawing.Point(373, 175);
            this.TxtSalary.Name = "TxtSalary";
            this.TxtSalary.Size = new System.Drawing.Size(463, 34);
            this.TxtSalary.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 38);
            this.label1.TabIndex = 3;
            this.label1.Text = "Enter Name:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(168, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 38);
            this.label2.TabIndex = 4;
            this.label2.Text = "Enter Age:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(128, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 38);
            this.label3.TabIndex = 5;
            this.label3.Text = "Enter Salary:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chckShareca);
            this.groupBox1.Controls.Add(this.ChckIt);
            this.groupBox1.Controls.Add(this.ChckComputer);
            this.groupBox1.Controls.Add(this.RdoFemale);
            this.groupBox1.Controls.Add(this.RdoMale);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(143, 234);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(693, 147);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // chckShareca
            // 
            this.chckShareca.AutoSize = true;
            this.chckShareca.Location = new System.Drawing.Point(457, 90);
            this.chckShareca.Name = "chckShareca";
            this.chckShareca.Size = new System.Drawing.Size(166, 36);
            this.chckShareca.TabIndex = 4;
            this.chckShareca.Text = "Shareeca";
            this.chckShareca.UseVisualStyleBackColor = true;
            // 
            // ChckIt
            // 
            this.ChckIt.AutoSize = true;
            this.ChckIt.Location = new System.Drawing.Point(299, 90);
            this.ChckIt.Name = "ChckIt";
            this.ChckIt.Size = new System.Drawing.Size(62, 36);
            this.ChckIt.TabIndex = 3;
            this.ChckIt.Text = "IT";
            this.ChckIt.UseVisualStyleBackColor = true;
            // 
            // ChckComputer
            // 
            this.ChckComputer.AutoSize = true;
            this.ChckComputer.Location = new System.Drawing.Point(31, 90);
            this.ChckComputer.Name = "ChckComputer";
            this.ChckComputer.Size = new System.Drawing.Size(168, 36);
            this.ChckComputer.TabIndex = 2;
            this.ChckComputer.Text = "Computer";
            this.ChckComputer.UseVisualStyleBackColor = true;
            // 
            // RdoFemale
            // 
            this.RdoFemale.AutoSize = true;
            this.RdoFemale.Location = new System.Drawing.Point(299, 37);
            this.RdoFemale.Name = "RdoFemale";
            this.RdoFemale.Size = new System.Drawing.Size(136, 36);
            this.RdoFemale.TabIndex = 1;
            this.RdoFemale.TabStop = true;
            this.RdoFemale.Text = "Female";
            this.RdoFemale.UseVisualStyleBackColor = true;
            // 
            // RdoMale
            // 
            this.RdoMale.AutoSize = true;
            this.RdoMale.Location = new System.Drawing.Point(29, 37);
            this.RdoMale.Name = "RdoMale";
            this.RdoMale.Size = new System.Drawing.Size(101, 36);
            this.RdoMale.TabIndex = 0;
            this.RdoMale.TabStop = true;
            this.RdoMale.Text = "Male";
            this.RdoMale.UseVisualStyleBackColor = true;
            // 
            // LstResult
            // 
            this.LstResult.FormattingEnabled = true;
            this.LstResult.ItemHeight = 16;
            this.LstResult.Items.AddRange(new object[] {
            "List of items"});
            this.LstResult.Location = new System.Drawing.Point(860, 71);
            this.LstResult.Name = "LstResult";
            this.LstResult.Size = new System.Drawing.Size(438, 564);
            this.LstResult.TabIndex = 7;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.RMVATBtn);
            this.groupBox2.Controls.Add(this.RemoveBtn);
            this.groupBox2.Controls.Add(this.BtnSelect);
            this.groupBox2.Controls.Add(this.BtnCount);
            this.groupBox2.Controls.Add(this.SlectBtn);
            this.groupBox2.Controls.Add(this.ClearBtn);
            this.groupBox2.Controls.Add(this.ValidationBtn);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(143, 393);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(693, 238);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Action";
            // 
            // RMVATBtn
            // 
            this.RMVATBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RMVATBtn.Location = new System.Drawing.Point(531, 141);
            this.RMVATBtn.Name = "RMVATBtn";
            this.RMVATBtn.Size = new System.Drawing.Size(136, 62);
            this.RMVATBtn.TabIndex = 8;
            this.RMVATBtn.Text = "Remove At";
            this.RMVATBtn.UseVisualStyleBackColor = true;
            this.RMVATBtn.Click += new System.EventHandler(this.RMVATBtn_Click);
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemoveBtn.Location = new System.Drawing.Point(368, 141);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.Size = new System.Drawing.Size(157, 62);
            this.RemoveBtn.TabIndex = 7;
            this.RemoveBtn.Text = "Action";
            this.RemoveBtn.UseVisualStyleBackColor = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // BtnSelect
            // 
            this.BtnSelect.Location = new System.Drawing.Point(205, 141);
            this.BtnSelect.Name = "BtnSelect";
            this.BtnSelect.Size = new System.Drawing.Size(157, 62);
            this.BtnSelect.TabIndex = 6;
            this.BtnSelect.Text = "Select Index";
            this.BtnSelect.UseVisualStyleBackColor = true;
            this.BtnSelect.Click += new System.EventHandler(this.BtnSelect_Click);
            // 
            // BtnCount
            // 
            this.BtnCount.Location = new System.Drawing.Point(38, 141);
            this.BtnCount.Name = "BtnCount";
            this.BtnCount.Size = new System.Drawing.Size(161, 62);
            this.BtnCount.TabIndex = 5;
            this.BtnCount.Text = "Count";
            this.BtnCount.UseVisualStyleBackColor = true;
            this.BtnCount.Click += new System.EventHandler(this.BtnCount_Click);
            // 
            // SlectBtn
            // 
            this.SlectBtn.Location = new System.Drawing.Point(421, 54);
            this.SlectBtn.Name = "SlectBtn";
            this.SlectBtn.Size = new System.Drawing.Size(246, 68);
            this.SlectBtn.TabIndex = 4;
            this.SlectBtn.Text = "Current Select Item";
            this.SlectBtn.UseVisualStyleBackColor = true;
            this.SlectBtn.Click += new System.EventHandler(this.SlectBtn_Click);
            // 
            // ClearBtn
            // 
            this.ClearBtn.Location = new System.Drawing.Point(205, 54);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(210, 68);
            this.ClearBtn.TabIndex = 3;
            this.ClearBtn.Text = "Clear";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // ValidationBtn
            // 
            this.ValidationBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValidationBtn.Location = new System.Drawing.Point(38, 54);
            this.ValidationBtn.Name = "ValidationBtn";
            this.ValidationBtn.Size = new System.Drawing.Size(161, 68);
            this.ValidationBtn.TabIndex = 0;
            this.ValidationBtn.Text = "Validation";
            this.ValidationBtn.UseVisualStyleBackColor = true;
            this.ValidationBtn.Click += new System.EventHandler(this.ValidationBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(1384, 655);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.LstResult);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSalary);
            this.Controls.Add(this.TxtAge);
            this.Controls.Add(this.TxtName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox LstResult;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button SlectBtn;
        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Button ValidationBtn;
        private System.Windows.Forms.CheckBox chckShareca;
        private System.Windows.Forms.CheckBox ChckIt;
        private System.Windows.Forms.CheckBox ChckComputer;
        private System.Windows.Forms.RadioButton RdoFemale;
        private System.Windows.Forms.RadioButton RdoMale;
        private System.Windows.Forms.Button BtnCount;
        private System.Windows.Forms.Button BtnSelect;
        private System.Windows.Forms.Button RemoveBtn;
        private System.Windows.Forms.Button RMVATBtn;
    }
}

