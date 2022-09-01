namespace roulette
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
            this.btnPlay = new System.Windows.Forms.Button();
            this.cbRed = new System.Windows.Forms.CheckBox();
            this.cbBlack = new System.Windows.Forms.CheckBox();
            this.lblResult = new System.Windows.Forms.Label();
            this.nudNumber = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.nudPara = new System.Windows.Forms.NumericUpDown();
            this.cbGreen = new System.Windows.Forms.CheckBox();
            this.cbNumberCnt = new System.Windows.Forms.CheckBox();
            this.gbRenk = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPara)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(90, 196);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(132, 25);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.Text = "Oyna";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // cbRed
            // 
            this.cbRed.AutoSize = true;
            this.cbRed.Location = new System.Drawing.Point(50, 161);
            this.cbRed.Name = "cbRed";
            this.cbRed.Size = new System.Drawing.Size(62, 19);
            this.cbRed.TabIndex = 1;
            this.cbRed.Text = "Kırmızı";
            this.cbRed.UseVisualStyleBackColor = true;
            // 
            // cbBlack
            // 
            this.cbBlack.AutoSize = true;
            this.cbBlack.Location = new System.Drawing.Point(50, 136);
            this.cbBlack.Name = "cbBlack";
            this.cbBlack.Size = new System.Drawing.Size(54, 19);
            this.cbBlack.TabIndex = 2;
            this.cbBlack.Text = "Siyah";
            this.cbBlack.UseVisualStyleBackColor = true;
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblResult.Location = new System.Drawing.Point(12, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 37);
            this.lblResult.TabIndex = 3;
            // 
            // nudNumber
            // 
            this.nudNumber.Location = new System.Drawing.Point(137, 98);
            this.nudNumber.Maximum = new decimal(new int[] {
            40,
            0,
            0,
            0});
            this.nudNumber.Name = "nudNumber";
            this.nudNumber.Size = new System.Drawing.Size(45, 23);
            this.nudNumber.TabIndex = 4;
            this.nudNumber.ValueChanged += new System.EventHandler(this.nudNumber_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(306, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 37);
            this.label2.TabIndex = 5;
            this.label2.Text = "Bakiye: ";
            // 
            // lblBakiye
            // 
            this.lblBakiye.AutoSize = true;
            this.lblBakiye.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBakiye.Location = new System.Drawing.Point(398, 9);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(0, 37);
            this.lblBakiye.TabIndex = 6;
            // 
            // nudPara
            // 
            this.nudPara.Location = new System.Drawing.Point(39, 196);
            this.nudPara.Name = "nudPara";
            this.nudPara.Size = new System.Drawing.Size(45, 23);
            this.nudPara.TabIndex = 7;
            // 
            // cbGreen
            // 
            this.cbGreen.AutoSize = true;
            this.cbGreen.Location = new System.Drawing.Point(50, 111);
            this.cbGreen.Name = "cbGreen";
            this.cbGreen.Size = new System.Drawing.Size(49, 19);
            this.cbGreen.TabIndex = 8;
            this.cbGreen.Text = "Yeşil";
            this.cbGreen.UseVisualStyleBackColor = true;
            // 
            // cbNumberCnt
            // 
            this.cbNumberCnt.AutoSize = true;
            this.cbNumberCnt.Location = new System.Drawing.Point(137, 136);
            this.cbNumberCnt.Name = "cbNumberCnt";
            this.cbNumberCnt.Size = new System.Drawing.Size(107, 19);
            this.cbNumberCnt.TabIndex = 9;
            this.cbNumberCnt.Text = "Sayı Seçtin Mi ?";
            this.cbNumberCnt.UseVisualStyleBackColor = true;
            this.cbNumberCnt.CheckedChanged += new System.EventHandler(this.cbNumberCnt_CheckedChanged);
            // 
            // gbRenk
            // 
            this.gbRenk.Location = new System.Drawing.Point(39, 88);
            this.gbRenk.Name = "gbRenk";
            this.gbRenk.Size = new System.Drawing.Size(90, 100);
            this.gbRenk.TabIndex = 10;
            this.gbRenk.TabStop = false;
            this.gbRenk.Text = "Renk Seçimi";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 280);
            this.Controls.Add(this.cbNumberCnt);
            this.Controls.Add(this.cbGreen);
            this.Controls.Add(this.nudPara);
            this.Controls.Add(this.lblBakiye);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nudNumber);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.cbBlack);
            this.Controls.Add(this.cbRed);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.gbRenk);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPara)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.CheckBox cbRed;
        private System.Windows.Forms.CheckBox cbBlack;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.NumericUpDown nudNumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.NumericUpDown nudPara;
        private System.Windows.Forms.CheckBox cbGreen;
        private System.Windows.Forms.CheckBox cbNumberCnt;
        private System.Windows.Forms.GroupBox gbRenk;
    }
}
