namespace ModbusSlave
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
            this.btnStart = new System.Windows.Forms.Button();
            this.labStatus = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSetVal = new System.Windows.Forms.Button();
            this.textReqVal = new System.Windows.Forms.TextBox();
            this.textRegAdr = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbRegType = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnStart.Location = new System.Drawing.Point(1, 3);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(312, 51);
            this.btnStart.TabIndex = 0;
            this.btnStart.Text = "START";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // labStatus
            // 
            this.labStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labStatus.AutoSize = true;
            this.labStatus.Location = new System.Drawing.Point(12, 361);
            this.labStatus.Name = "labStatus";
            this.labStatus.Size = new System.Drawing.Size(40, 13);
            this.labStatus.TabIndex = 1;
            this.labStatus.Text = "Status:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnSetVal);
            this.groupBox1.Controls.Add(this.textReqVal);
            this.groupBox1.Controls.Add(this.textRegAdr);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cmbRegType);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 279);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Change Data";
            // 
            // btnSetVal
            // 
            this.btnSetVal.Location = new System.Drawing.Point(101, 135);
            this.btnSetVal.Name = "btnSetVal";
            this.btnSetVal.Size = new System.Drawing.Size(170, 35);
            this.btnSetVal.TabIndex = 3;
            this.btnSetVal.Text = "Set";
            this.btnSetVal.UseVisualStyleBackColor = true;
            this.btnSetVal.Click += new System.EventHandler(this.btnSetVal_Click);
            // 
            // textReqVal
            // 
            this.textReqVal.Location = new System.Drawing.Point(101, 96);
            this.textReqVal.Name = "textReqVal";
            this.textReqVal.Size = new System.Drawing.Size(190, 20);
            this.textReqVal.TabIndex = 2;
            // 
            // textRegAdr
            // 
            this.textRegAdr.Location = new System.Drawing.Point(101, 67);
            this.textRegAdr.Name = "textRegAdr";
            this.textRegAdr.Size = new System.Drawing.Size(190, 20);
            this.textRegAdr.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "New Value";
            // 
            // cmbRegType
            // 
            this.cmbRegType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRegType.FormattingEnabled = true;
            this.cmbRegType.Items.AddRange(new object[] {
            "Holding Register ( 400 000 )",
            "Input Register      ( 300 000 )",
            "Digital Input        ( 100 000 )",
            "Coil Output         ( 000 000 )"});
            this.cmbRegType.Location = new System.Drawing.Point(101, 34);
            this.cmbRegType.Name = "cmbRegType";
            this.cmbRegType.Size = new System.Drawing.Size(170, 21);
            this.cmbRegType.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Register Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Register Type";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 386);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labStatus);
            this.Controls.Add(this.btnStart);
            this.Name = "Form1";
            this.Text = "Modbus TCP Server";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label labStatus;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbRegType;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSetVal;
        private System.Windows.Forms.TextBox textReqVal;
        private System.Windows.Forms.TextBox textRegAdr;
        private System.Windows.Forms.Label label3;
    }
}

