namespace Assigment_TWO_Part2
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
            this.LstResult = new System.Windows.Forms.ListBox();
            this.BtnExit = new System.Windows.Forms.Button();
            this.BtnClear = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkTravelInsurance = new System.Windows.Forms.CheckBox();
            this.GrpRoomType = new System.Windows.Forms.GroupBox();
            this.RdoBusinessClass = new System.Windows.Forms.RadioButton();
            this.RdoNormalClass = new System.Windows.Forms.RadioButton();
            this.RdoFirstclass = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.txtBaggageWeight = new System.Windows.Forms.TextBox();
            this.txtPassengerAge = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumberOfTickets = new System.Windows.Forms.TextBox();
            this.LblHeaderName = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.GrpRoomType.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LstResult
            // 
            this.LstResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstResult.FormattingEnabled = true;
            this.LstResult.ItemHeight = 18;
            this.LstResult.Items.AddRange(new object[] {
            "Airline Booking",
            "____________________________________________________________________________"});
            this.LstResult.Location = new System.Drawing.Point(634, 81);
            this.LstResult.Name = "LstResult";
            this.LstResult.Size = new System.Drawing.Size(423, 508);
            this.LstResult.TabIndex = 29;
            // 
            // BtnExit
            // 
            this.BtnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnExit.Location = new System.Drawing.Point(508, 539);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(112, 50);
            this.BtnExit.TabIndex = 28;
            this.BtnExit.Text = "Exit";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // BtnClear
            // 
            this.BtnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClear.Location = new System.Drawing.Point(373, 539);
            this.BtnClear.Name = "BtnClear";
            this.BtnClear.Size = new System.Drawing.Size(129, 50);
            this.BtnClear.TabIndex = 27;
            this.BtnClear.Text = "Clear";
            this.BtnClear.UseVisualStyleBackColor = true;
            this.BtnClear.Click += new System.EventHandler(this.BtnClear_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCalculate.Location = new System.Drawing.Point(26, 539);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(341, 50);
            this.BtnCalculate.TabIndex = 26;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chkTravelInsurance);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(26, 428);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(594, 105);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Aditional Option";
            // 
            // chkTravelInsurance
            // 
            this.chkTravelInsurance.AutoSize = true;
            this.chkTravelInsurance.Location = new System.Drawing.Point(37, 48);
            this.chkTravelInsurance.Name = "chkTravelInsurance";
            this.chkTravelInsurance.Size = new System.Drawing.Size(398, 29);
            this.chkTravelInsurance.TabIndex = 1;
            this.chkTravelInsurance.Text = "Add Travel Insurance( $25 Per Tiket )";
            this.chkTravelInsurance.UseVisualStyleBackColor = true;
            // 
            // GrpRoomType
            // 
            this.GrpRoomType.Controls.Add(this.RdoBusinessClass);
            this.GrpRoomType.Controls.Add(this.RdoNormalClass);
            this.GrpRoomType.Controls.Add(this.RdoFirstclass);
            this.GrpRoomType.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpRoomType.Location = new System.Drawing.Point(26, 310);
            this.GrpRoomType.Name = "GrpRoomType";
            this.GrpRoomType.Size = new System.Drawing.Size(594, 97);
            this.GrpRoomType.TabIndex = 24;
            this.GrpRoomType.TabStop = false;
            this.GrpRoomType.Text = "Room Type";
            // 
            // RdoBusinessClass
            // 
            this.RdoBusinessClass.AutoSize = true;
            this.RdoBusinessClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoBusinessClass.Location = new System.Drawing.Point(396, 45);
            this.RdoBusinessClass.Name = "RdoBusinessClass";
            this.RdoBusinessClass.Size = new System.Drawing.Size(182, 29);
            this.RdoBusinessClass.TabIndex = 17;
            this.RdoBusinessClass.TabStop = true;
            this.RdoBusinessClass.Text = "Business Class";
            this.RdoBusinessClass.UseVisualStyleBackColor = true;
            // 
            // RdoNormalClass
            // 
            this.RdoNormalClass.AutoSize = true;
            this.RdoNormalClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoNormalClass.Location = new System.Drawing.Point(207, 45);
            this.RdoNormalClass.Name = "RdoNormalClass";
            this.RdoNormalClass.Size = new System.Drawing.Size(162, 29);
            this.RdoNormalClass.TabIndex = 1;
            this.RdoNormalClass.TabStop = true;
            this.RdoNormalClass.Text = "Normal Class";
            this.RdoNormalClass.UseVisualStyleBackColor = true;
            // 
            // RdoFirstclass
            // 
            this.RdoFirstclass.AutoSize = true;
            this.RdoFirstclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdoFirstclass.Location = new System.Drawing.Point(37, 45);
            this.RdoFirstclass.Name = "RdoFirstclass";
            this.RdoFirstclass.Size = new System.Drawing.Size(136, 29);
            this.RdoFirstclass.TabIndex = 0;
            this.RdoFirstclass.TabStop = true;
            this.RdoFirstclass.Text = "First Class";
            this.RdoFirstclass.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightBlue;
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.TxtName);
            this.groupBox1.Controls.Add(this.txtBaggageWeight);
            this.groupBox1.Controls.Add(this.txtPassengerAge);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtNumberOfTickets);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(25, 86);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(595, 207);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Information";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(184, 25);
            this.label2.TabIndex = 15;
            this.label2.Text = "Passanger Name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(75, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 25);
            this.label3.TabIndex = 14;
            this.label3.Text = "Passanger Age:";
            // 
            // TxtName
            // 
            this.TxtName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtName.Location = new System.Drawing.Point(263, 42);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(314, 30);
            this.TxtName.TabIndex = 5;
            // 
            // txtBaggageWeight
            // 
            this.txtBaggageWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBaggageWeight.Location = new System.Drawing.Point(263, 157);
            this.txtBaggageWeight.Name = "txtBaggageWeight";
            this.txtBaggageWeight.Size = new System.Drawing.Size(314, 30);
            this.txtBaggageWeight.TabIndex = 11;
            // 
            // txtPassengerAge
            // 
            this.txtPassengerAge.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassengerAge.Location = new System.Drawing.Point(263, 81);
            this.txtPassengerAge.Name = "txtPassengerAge";
            this.txtPassengerAge.Size = new System.Drawing.Size(314, 30);
            this.txtPassengerAge.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 25);
            this.label5.TabIndex = 10;
            this.label5.Text = "Baggage Weight(KG):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(48, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(194, 25);
            this.label4.TabIndex = 8;
            this.label4.Text = "Number of Tickets:";
            // 
            // txtNumberOfTickets
            // 
            this.txtNumberOfTickets.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumberOfTickets.Location = new System.Drawing.Point(263, 119);
            this.txtNumberOfTickets.Name = "txtNumberOfTickets";
            this.txtNumberOfTickets.Size = new System.Drawing.Size(314, 30);
            this.txtNumberOfTickets.TabIndex = 9;
            // 
            // LblHeaderName
            // 
            this.LblHeaderName.BackColor = System.Drawing.Color.MediumBlue;
            this.LblHeaderName.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHeaderName.ForeColor = System.Drawing.Color.White;
            this.LblHeaderName.Location = new System.Drawing.Point(10, 9);
            this.LblHeaderName.Name = "LblHeaderName";
            this.LblHeaderName.Size = new System.Drawing.Size(1047, 54);
            this.LblHeaderName.TabIndex = 22;
            this.LblHeaderName.Text = "Airline Ticket Booking System";
            this.LblHeaderName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 619);
            this.Controls.Add(this.LstResult);
            this.Controls.Add(this.BtnExit);
            this.Controls.Add(this.BtnClear);
            this.Controls.Add(this.BtnCalculate);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.GrpRoomType);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.LblHeaderName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.GrpRoomType.ResumeLayout(false);
            this.GrpRoomType.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstResult;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Button BtnClear;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chkTravelInsurance;
        private System.Windows.Forms.GroupBox GrpRoomType;
        private System.Windows.Forms.RadioButton RdoBusinessClass;
        private System.Windows.Forms.RadioButton RdoNormalClass;
        private System.Windows.Forms.RadioButton RdoFirstclass;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.TextBox txtBaggageWeight;
        private System.Windows.Forms.TextBox txtPassengerAge;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNumberOfTickets;
        private System.Windows.Forms.Label LblHeaderName;
        private System.Windows.Forms.Label label3;
    }
}

