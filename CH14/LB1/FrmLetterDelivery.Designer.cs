namespace CH14LB1
{
    partial class FrmLetterDelivery
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRecipient = new System.Windows.Forms.TextBox();
            this.TxtSentDate = new System.Windows.Forms.TextBox();
            this.TxtTrackingNumber = new System.Windows.Forms.TextBox();
            this.LblOutput = new System.Windows.Forms.Label();
            this.BtnSend = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Recipient";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sent Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tracking Number";
            // 
            // TxtRecipient
            // 
            this.TxtRecipient.Location = new System.Drawing.Point(124, 36);
            this.TxtRecipient.Name = "TxtRecipient";
            this.TxtRecipient.Size = new System.Drawing.Size(100, 20);
            this.TxtRecipient.TabIndex = 3;
            // 
            // TxtSentDate
            // 
            this.TxtSentDate.Location = new System.Drawing.Point(124, 106);
            this.TxtSentDate.Name = "TxtSentDate";
            this.TxtSentDate.Size = new System.Drawing.Size(100, 20);
            this.TxtSentDate.TabIndex = 4;
            // 
            // TxtTrackingNumber
            // 
            this.TxtTrackingNumber.Location = new System.Drawing.Point(124, 160);
            this.TxtTrackingNumber.Name = "TxtTrackingNumber";
            this.TxtTrackingNumber.Size = new System.Drawing.Size(100, 20);
            this.TxtTrackingNumber.TabIndex = 5;
            // 
            // LblOutput
            // 
            this.LblOutput.AutoSize = true;
            this.LblOutput.Location = new System.Drawing.Point(15, 5);
            this.LblOutput.Name = "LblOutput";
            this.LblOutput.Size = new System.Drawing.Size(0, 13);
            this.LblOutput.TabIndex = 6;
            // 
            // BtnSend
            // 
            this.BtnSend.Location = new System.Drawing.Point(149, 218);
            this.BtnSend.Name = "BtnSend";
            this.BtnSend.Size = new System.Drawing.Size(75, 23);
            this.BtnSend.TabIndex = 7;
            this.BtnSend.Text = "Send";
            this.BtnSend.UseVisualStyleBackColor = true;
            this.BtnSend.Click += new System.EventHandler(this.BtnSend_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "(Additional fee for certified letter)";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.LblOutput);
            this.panel1.Location = new System.Drawing.Point(265, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 228);
            this.panel1.TabIndex = 9;
            // 
            // FrmLetterDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 293);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.BtnSend);
            this.Controls.Add(this.TxtTrackingNumber);
            this.Controls.Add(this.TxtSentDate);
            this.Controls.Add(this.TxtRecipient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmLetterDelivery";
            this.Text = "Letter Delivery";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRecipient;
        private System.Windows.Forms.TextBox TxtSentDate;
        private System.Windows.Forms.TextBox TxtTrackingNumber;
        private System.Windows.Forms.Label LblOutput;
        private System.Windows.Forms.Button BtnSend;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
    }
}

