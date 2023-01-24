namespace CRC16ChecksumCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEPC = new System.Windows.Forms.TextBox();
            this.btnCalc = new System.Windows.Forms.Button();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChecksum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "TID:";
            // 
            // txtTID
            // 
            this.txtTID.Location = new System.Drawing.Point(53, 13);
            this.txtTID.Name = "txtTID";
            this.txtTID.Size = new System.Drawing.Size(227, 27);
            this.txtTID.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(286, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "EPC:";
            // 
            // txtEPC
            // 
            this.txtEPC.Location = new System.Drawing.Point(329, 13);
            this.txtEPC.Name = "txtEPC";
            this.txtEPC.Size = new System.Drawing.Size(287, 27);
            this.txtEPC.TabIndex = 1;
            // 
            // btnCalc
            // 
            this.btnCalc.Location = new System.Drawing.Point(622, 12);
            this.btnCalc.Name = "btnCalc";
            this.btnCalc.Size = new System.Drawing.Size(94, 29);
            this.btnCalc.TabIndex = 2;
            this.btnCalc.Text = "Calc";
            this.btnCalc.UseVisualStyleBackColor = true;
            this.btnCalc.Click += new System.EventHandler(this.btnCalc_Click);
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(79, 69);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(429, 27);
            this.txtResult.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "RESULT:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(523, 72);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "CHECKSUM:";
            // 
            // txtChecksum
            // 
            this.txtChecksum.Location = new System.Drawing.Point(618, 69);
            this.txtChecksum.Name = "txtChecksum";
            this.txtChecksum.Size = new System.Drawing.Size(98, 27);
            this.txtChecksum.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(740, 120);
            this.Controls.Add(this.btnCalc);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txtEPC);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtChecksum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTID);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CRC-16 Checksum Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox txtTID;
        private Label label2;
        private TextBox txtEPC;
        private Button btnCalc;
        private TextBox txtResult;
        private Label label3;
        private Label label4;
        private TextBox txtChecksum;
    }
}