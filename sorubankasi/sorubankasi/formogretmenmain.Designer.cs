﻿namespace sorubankasi
{
    partial class formogretmenmain
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblclock = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(30, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(272, 39);
            this.button1.TabIndex = 0;
            this.button1.Text = "Soru Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Hoşgeldiniz ";
            // 
            // lblclock
            // 
            this.lblclock.AutoSize = true;
            this.lblclock.Location = new System.Drawing.Point(177, 26);
            this.lblclock.Name = "lblclock";
            this.lblclock.Size = new System.Drawing.Size(44, 16);
            this.lblclock.TabIndex = 2;
            this.lblclock.Text = "label2";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // formogretmenmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 171);
            this.Controls.Add(this.lblclock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Name = "formogretmenmain";
            this.Text = "Öğretmen Ekranı";
            this.Load += new System.EventHandler(this.formogretmenmain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblclock;
        private System.Windows.Forms.Timer timer1;
    }
}