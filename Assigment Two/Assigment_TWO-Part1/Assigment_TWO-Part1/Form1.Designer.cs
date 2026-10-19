namespace Assigment_TWO_Part1
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
            this.LblHeaderName = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.TxtAge = new System.Windows.Forms.TextBox();
            this.TxtNumOfNights = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtNumOfGuest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpRoomType = new System.Windows.Forms.GroupBox();
            this.RdoHight = new System.Windows.Forms.RadioButton();
            this.RdoNormal = new System.Windows.Forms.RadioButton();
            this.RdoStandard = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ChckBreak = new System.Windows.Forms.CheckBox();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnExit = new System.Windows.Forms.Button();
            this.LblBookingDetails = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.GrpRoomType.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblHeaderName
            // 
            this.LblHeaderName.BackColor = System.Drawing.Color.MediumBlue;
            this.LblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderName.ForeColor = System.Drawing.Color.White;
            this.LblHeaderName.Location = new System.Drawing.Point(-3, 9);
            this.LblHeaderName.Name = "LblHeaderName";
            this.LblHeaderName.Size = new System.Drawing.Size(1028, 54);
            this.LblHeaderName.TabIndex = 0;
            this.LblHeaderName.Text = "Hotel Room Booking System";
            this.LblHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(263, 42);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(270, 30);
            this.TxtName.TabIndex = 5;
            // 
            // TxtAge
            // 
            this.TxtAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtAge.Location = new System.Drawing.Point(263, 81);
            this.TxtAge.Name = "TxtAge";
            this.TxtAge.Size = new System.Drawing.Size(270, 30);
            this.TxtAge.TabIndex = 7;
            // 
            // TxtNumOfNights
            // 
            this.TxtNumOfNights.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumOfNights.Location = new System.Drawing.Point(263, 119);
            this.TxtNumOfNights.Name = "TxtNumOfNights";
            this.TxtNumOfNights.Size = new System.Drawing.Size(270, 30);
            this.TxtNumOfNights.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Nights:";
            // 
            // TxtNumOfGuest
            // 
            this.TxtNumOfGuest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtNumOfGuest.Location = new System.Drawing.Point(263, 157);
            this.TxtNumOfGuest.Name = "TxtNumOfGuest";
            this.TxtNumOfGuest.Size = new System.Drawing.Size(270, 30);
            this.TxtNumOfGuest.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(61, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(181, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Number of Guest:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(125, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(121, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Guest Age:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.TxtNumOfGuest);
            this.groupBox1.Controls.Add(this.TxtAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtNumOfNights);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(565, 207);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(110, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Guest Name:";
            // 
            // GrpRoomType
            // 
            this.GrpRoomType.Controls.Add(this.RdoHight);
            this.GrpRoomType.Controls.Add(this.RdoNormal);
            this.GrpRoomType.Controls.Add(this.RdoStandard);
            this.GrpRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRoomType.Location = new System.Drawing.Point(13, 310);
            this.GrpRoomType.Name = "GrpRoomType";
            this.GrpRoomType.Size = new System.Drawing.Size(564, 97);
            this.GrpRoomType.TabIndex = 16;
            this.GrpRoomType.TabStop = false;
            this.GrpRoomType.Text = "Room Type";
            // 
            // RdoHight
            // 
            this.RdoHight.AutoSize = true;
            this.RdoHight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoHight.Location = new System.Drawing.Point(449, 45);
            this.RdoHight.Name = "RdoHight";
            this.RdoHight.Size = new System.Drawing.Size(83, 29);
            this.RdoHight.TabIndex = 17;
            this.RdoHight.TabStop = true;
            this.RdoHight.Text = "Hight";
            this.RdoHight.UseVisualStyleBackColor = true;
            // 
            // RdoNormal
            // 
            this.RdoNormal.AutoSize = true;
            this.RdoNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoNormal.Location = new System.Drawing.Point(249, 45);
            this.RdoNormal.Name = "RdoNormal";
            this.RdoNormal.Size = new System.Drawing.Size(101, 29);
            this.RdoNormal.TabIndex = 1;
            this.RdoNormal.TabStop = true;
            this.RdoNormal.Text = "Normal";
            this.RdoNormal.UseVisualStyleBackColor = true;
            // 
            // RdoStandard
            // 
            this.RdoStandard.AutoSize = true;
            this.RdoStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoStandard.Location = new System.Drawing.Point(37, 45);
            this.RdoStandard.Name = "RdoStandard";
            this.RdoStandard.Size = new System.Drawing.Size(121, 29);
            this.RdoStandard.TabIndex = 0;
            this.RdoStandard.TabStop = true;
            this.RdoStandard.Text = "Standard";
            this.RdoStandard.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.ChckBreak);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(13, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(564, 80);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Option";
            // 
            // ChckBreak
            // 
            this.ChckBreak.AutoSize = true;
            this.ChckBreak.Location = new System.Drawing.Point(38, 36);
            this.ChckBreak.Name = "ChckBreak";
            this.ChckBreak.Size = new System.Drawing.Size(345, 29);
            this.ChckBreak.TabIndex = 1;
            this.ChckBreak.Text = "BreakFast (10 Guest per Nights)";
            this.ChckBreak.UseVisualStyleBackColor = true;
            this.ChckBreak.CheckedChanged += new System.EventHandler(this.ChckBreak_CheckedChanged);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(13, 539);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(321, 50);
            this.BtnCalculate.TabIndex = 18;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(340, 539);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(129, 50);
            this.BtnClear.TabIndex = 19;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(475, 539);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(102, 50);
            this.BtnExit.TabIndex = 20;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // LblBookingDetails
            // 
            this.LblBookingDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblBookingDetails.FormattingEnabled = true;
            this.LblBookingDetails.ItemHeight = 20;
            this.LblBookingDetails.Items.AddRange(new object[] {
            "Booking Details",
            "---------------------------------------------------------------------------------" +
                "---"});
            this.LblBookingDetails.Location = new System.Drawing.Point(602, 81);
            this.LblBookingDetails.Name = "LblBookingDetails";
            this.LblBookingDetails.Size = new System.Drawing.Size(423, 504);
            this.LblBookingDetails.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1040, 623);
            this.Controls.Add(this.LblBookingDetails);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpRoomType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblHeaderName);
            this.Name = "Form1";
            this.Text = "ASSIGMENT TWO PART ONE";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.GrpRoomType.ResumeLayout(false);
            this.GrpRoomType.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblHeaderName;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox TxtAge;
        private System.Windows.Forms.TextBox TxtNumOfNights;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtNumOfGuest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox GrpRoomType;
        private System.Windows.Forms.RadioButton RdoHight;
        private System.Windows.Forms.RadioButton RdoNormal;
        private System.Windows.Forms.RadioButton RdoStandard;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.ListBox LblBookingDetails;
        private System.Windows.Forms.CheckBox ChckBreak;
        private System.Windows.Forms.Label label2;
    }
}

