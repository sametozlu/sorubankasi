namespace sorubankasi
{
    partial class formogrencimain
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
            this.components = new System.ComponentModel.Container();
            this.grpCevaplar = new System.Windows.Forms.GroupBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.rdD = new System.Windows.Forms.RadioButton();
            this.rdC = new System.Windows.Forms.RadioButton();
            this.rdB = new System.Windows.Forms.RadioButton();
            this.rdA = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblLeft = new System.Windows.Forms.Label();
            this.grpProgres = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblCurr = new System.Windows.Forms.Label();
            this.grpCevaplar.SuspendLayout();
            this.grpProgres.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpCevaplar
            // 
            this.grpCevaplar.Controls.Add(this.btnNext);
            this.grpCevaplar.Controls.Add(this.rdD);
            this.grpCevaplar.Controls.Add(this.rdC);
            this.grpCevaplar.Controls.Add(this.rdB);
            this.grpCevaplar.Controls.Add(this.rdA);
            this.grpCevaplar.Location = new System.Drawing.Point(12, 218);
            this.grpCevaplar.Name = "grpCevaplar";
            this.grpCevaplar.Size = new System.Drawing.Size(761, 220);
            this.grpCevaplar.TabIndex = 4;
            this.grpCevaplar.TabStop = false;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(545, 177);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(210, 37);
            this.btnNext.TabIndex = 4;
            this.btnNext.Text = "Sonraki";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // rdD
            // 
            this.rdD.AutoSize = true;
            this.rdD.Location = new System.Drawing.Point(18, 154);
            this.rdD.Name = "rdD";
            this.rdD.Size = new System.Drawing.Size(103, 20);
            this.rdD.TabIndex = 3;
            this.rdD.TabStop = true;
            this.rdD.Text = "radioButton4";
            this.rdD.UseVisualStyleBackColor = true;
            // 
            // rdC
            // 
            this.rdC.AutoSize = true;
            this.rdC.Location = new System.Drawing.Point(18, 117);
            this.rdC.Name = "rdC";
            this.rdC.Size = new System.Drawing.Size(103, 20);
            this.rdC.TabIndex = 2;
            this.rdC.TabStop = true;
            this.rdC.Text = "radioButton3";
            this.rdC.UseVisualStyleBackColor = true;
            // 
            // rdB
            // 
            this.rdB.AutoSize = true;
            this.rdB.Location = new System.Drawing.Point(18, 77);
            this.rdB.Name = "rdB";
            this.rdB.Size = new System.Drawing.Size(103, 20);
            this.rdB.TabIndex = 1;
            this.rdB.TabStop = true;
            this.rdB.Text = "radioButton2";
            this.rdB.UseVisualStyleBackColor = true;
            // 
            // rdA
            // 
            this.rdA.AutoSize = true;
            this.rdA.Location = new System.Drawing.Point(18, 34);
            this.rdA.Name = "rdA";
            this.rdA.Size = new System.Drawing.Size(103, 20);
            this.rdA.TabIndex = 0;
            this.rdA.TabStop = true;
            this.rdA.Text = "radioButton1";
            this.rdA.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(23, 37);
            this.progressBar1.Maximum = 600;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(726, 30);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 5;
            this.progressBar1.Value = 600;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // lblLeft
            // 
            this.lblLeft.AutoSize = true;
            this.lblLeft.Location = new System.Drawing.Point(328, 17);
            this.lblLeft.Name = "lblLeft";
            this.lblLeft.Size = new System.Drawing.Size(44, 16);
            this.lblLeft.TabIndex = 6;
            this.lblLeft.Text = "label1";
            // 
            // grpProgres
            // 
            this.grpProgres.Controls.Add(this.progressBar1);
            this.grpProgres.Controls.Add(this.lblLeft);
            this.grpProgres.Location = new System.Drawing.Point(12, 438);
            this.grpProgres.Name = "grpProgres";
            this.grpProgres.Size = new System.Drawing.Size(761, 74);
            this.grpProgres.TabIndex = 7;
            this.grpProgres.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.richTextBox1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 26);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(761, 186);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(18, 21);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(348, 147);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(389, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(360, 147);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // lblCurr
            // 
            this.lblCurr.AutoSize = true;
            this.lblCurr.Location = new System.Drawing.Point(14, 9);
            this.lblCurr.Name = "lblCurr";
            this.lblCurr.Size = new System.Drawing.Size(44, 16);
            this.lblCurr.TabIndex = 7;
            this.lblCurr.Text = "label1";
            // 
            // formogrencimain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 518);
            this.Controls.Add(this.lblCurr);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grpProgres);
            this.Controls.Add(this.grpCevaplar);
            this.Name = "formogrencimain";
            this.Text = "Quiz Bölümü";
            this.Load += new System.EventHandler(this.formogrencimain_Load);
            this.grpCevaplar.ResumeLayout(false);
            this.grpCevaplar.PerformLayout();
            this.grpProgres.ResumeLayout(false);
            this.grpProgres.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpCevaplar;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.RadioButton rdD;
        private System.Windows.Forms.RadioButton rdC;
        private System.Windows.Forms.RadioButton rdB;
        private System.Windows.Forms.RadioButton rdA;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblLeft;
        private System.Windows.Forms.GroupBox grpProgres;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label lblCurr;
    }
}