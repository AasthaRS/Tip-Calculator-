
namespace TipCalculatorSample
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBill = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTipPP = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTotalPP = new System.Windows.Forms.Label();
            this.lblVertical = new System.Windows.Forms.Label();
            this.btnTipInc = new System.Windows.Forms.Button();
            this.btnNOPInc = new System.Windows.Forms.Button();
            this.btnTipDec = new System.Windows.Forms.Button();
            this.btnNOPDec = new System.Windows.Forms.Button();
            this.txtNumOfPeo = new System.Windows.Forms.TextBox();
            this.txtTipPercent = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(47, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bill";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(43, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tip %";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(45, 309);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Number of People";
            // 
            // txtBill
            // 
            this.txtBill.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBill.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtBill.Location = new System.Drawing.Point(51, 80);
            this.txtBill.Name = "txtBill";
            this.txtBill.Size = new System.Drawing.Size(266, 33);
            this.txtBill.TabIndex = 3;
            this.txtBill.Text = "0.00";
            this.txtBill.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBill.Enter += new System.EventHandler(this.txtBill_Enter);
            this.txtBill.Leave += new System.EventHandler(this.textBill_Leave);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(595, 366);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "Calculate";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(452, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 36);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tip";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Calibri", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label5.Location = new System.Drawing.Point(453, 233);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 36);
            this.label5.TabIndex = 8;
            this.label5.Text = "Total";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label6.Location = new System.Drawing.Point(453, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 26);
            this.label6.TabIndex = 9;
            this.label6.Text = "per person";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(454, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 26);
            this.label7.TabIndex = 10;
            this.label7.Text = "per person";
            // 
            // lblTipPP
            // 
            this.lblTipPP.AutoSize = true;
            this.lblTipPP.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipPP.Location = new System.Drawing.Point(621, 110);
            this.lblTipPP.Name = "lblTipPP";
            this.lblTipPP.Size = new System.Drawing.Size(0, 42);
            this.lblTipPP.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(621, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 42);
            this.label8.TabIndex = 12;
            // 
            // lblTotalPP
            // 
            this.lblTotalPP.AutoSize = true;
            this.lblTotalPP.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalPP.Location = new System.Drawing.Point(615, 242);
            this.lblTotalPP.Name = "lblTotalPP";
            this.lblTotalPP.Size = new System.Drawing.Size(0, 42);
            this.lblTotalPP.TabIndex = 13;
            // 
            // lblVertical
            // 
            this.lblVertical.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblVertical.Location = new System.Drawing.Point(401, 0);
            this.lblVertical.Name = "lblVertical";
            this.lblVertical.Size = new System.Drawing.Size(1, 478);
            this.lblVertical.TabIndex = 14;
            // 
            // btnTipInc
            // 
            this.btnTipInc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipInc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTipInc.Location = new System.Drawing.Point(284, 208);
            this.btnTipInc.Name = "btnTipInc";
            this.btnTipInc.Size = new System.Drawing.Size(35, 35);
            this.btnTipInc.TabIndex = 15;
            this.btnTipInc.Text = "+";
            this.btnTipInc.UseVisualStyleBackColor = true;
            this.btnTipInc.Click += new System.EventHandler(this.btnTipInc_Click);
            // 
            // btnNOPInc
            // 
            this.btnNOPInc.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOPInc.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNOPInc.Location = new System.Drawing.Point(284, 348);
            this.btnNOPInc.Name = "btnNOPInc";
            this.btnNOPInc.Size = new System.Drawing.Size(35, 35);
            this.btnNOPInc.TabIndex = 16;
            this.btnNOPInc.Text = "+";
            this.btnNOPInc.UseVisualStyleBackColor = true;
            this.btnNOPInc.Click += new System.EventHandler(this.btnNOPInc_Click);
            // 
            // btnTipDec
            // 
            this.btnTipDec.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTipDec.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnTipDec.Location = new System.Drawing.Point(50, 208);
            this.btnTipDec.Name = "btnTipDec";
            this.btnTipDec.Size = new System.Drawing.Size(35, 35);
            this.btnTipDec.TabIndex = 17;
            this.btnTipDec.Text = "-";
            this.btnTipDec.UseVisualStyleBackColor = true;
            this.btnTipDec.Click += new System.EventHandler(this.btnTipDec_Click);
            // 
            // btnNOPDec
            // 
            this.btnNOPDec.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNOPDec.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnNOPDec.Location = new System.Drawing.Point(50, 348);
            this.btnNOPDec.Name = "btnNOPDec";
            this.btnNOPDec.Size = new System.Drawing.Size(35, 35);
            this.btnNOPDec.TabIndex = 18;
            this.btnNOPDec.Text = "-";
            this.btnNOPDec.UseVisualStyleBackColor = true;
            this.btnNOPDec.Click += new System.EventHandler(this.btnNOPDec_Click);
            // 
            // txtNumOfPeo
            // 
            this.txtNumOfPeo.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumOfPeo.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtNumOfPeo.Location = new System.Drawing.Point(85, 349);
            this.txtNumOfPeo.Name = "txtNumOfPeo";
            this.txtNumOfPeo.Size = new System.Drawing.Size(199, 33);
            this.txtNumOfPeo.TabIndex = 19;
            this.txtNumOfPeo.Text = "0";
            this.txtNumOfPeo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumOfPeo.Enter += new System.EventHandler(this.txtNOP_Enter);
            this.txtNumOfPeo.Leave += new System.EventHandler(this.txtNOP_Leave);
            // 
            // txtTipPercent
            // 
            this.txtTipPercent.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTipPercent.ForeColor = System.Drawing.SystemColors.InactiveCaption;
            this.txtTipPercent.Location = new System.Drawing.Point(85, 209);
            this.txtTipPercent.Name = "txtTipPercent";
            this.txtTipPercent.Size = new System.Drawing.Size(199, 33);
            this.txtTipPercent.TabIndex = 4;
            this.txtTipPercent.Text = "0%";
            this.txtTipPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTipPercent.Enter += new System.EventHandler(this.txtTip_Enter);
            this.txtTipPercent.Leave += new System.EventHandler(this.txtTipPercent_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(901, 474);
            this.Controls.Add(this.txtNumOfPeo);
            this.Controls.Add(this.btnNOPDec);
            this.Controls.Add(this.btnTipDec);
            this.Controls.Add(this.btnNOPInc);
            this.Controls.Add(this.btnTipInc);
            this.Controls.Add(this.lblVertical);
            this.Controls.Add(this.lblTotalPP);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTipPP);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtTipPercent);
            this.Controls.Add(this.txtBill);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tip Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBill;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblTipPP;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTotalPP;
        private System.Windows.Forms.Label lblVertical;
        private System.Windows.Forms.Button btnTipInc;
        private System.Windows.Forms.Button btnNOPInc;
        private System.Windows.Forms.Button btnTipDec;
        private System.Windows.Forms.Button btnNOPDec;
        private System.Windows.Forms.TextBox txtNumOfPeo;
        private System.Windows.Forms.TextBox txtTipPercent;
    }
}

