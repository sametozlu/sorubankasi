namespace sorubankasi
{
    partial class formsoruekleme
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
            this.cmbKonu = new System.Windows.Forms.ComboBox();
            this.ckGorsel = new System.Windows.Forms.CheckBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgorselurl = new System.Windows.Forms.TextBox();
            this.txtcevapyanlis1 = new System.Windows.Forms.TextBox();
            this.txtcevapyanlis2 = new System.Windows.Forms.TextBox();
            this.txtcevapyanlis3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnsoruekle = new System.Windows.Forms.Button();
            this.btngeri = new System.Windows.Forms.Button();
            this.txtrue = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmbKonu
            // 
            this.cmbKonu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cmbKonu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKonu.FormattingEnabled = true;
            this.cmbKonu.Location = new System.Drawing.Point(158, 47);
            this.cmbKonu.Name = "cmbKonu";
            this.cmbKonu.Size = new System.Drawing.Size(308, 24);
            this.cmbKonu.TabIndex = 0;
            this.cmbKonu.SelectedIndexChanged += new System.EventHandler(this.cmbKonu_SelectedIndexChanged);
            // 
            // ckGorsel
            // 
            this.ckGorsel.AutoSize = true;
            this.ckGorsel.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ckGorsel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.ckGorsel.Location = new System.Drawing.Point(52, 187);
            this.ckGorsel.Name = "ckGorsel";
            this.ckGorsel.Size = new System.Drawing.Size(205, 23);
            this.ckGorsel.TabIndex = 1;
            this.ckGorsel.Text = "Soru Görsel İçeriyor mu?";
            this.ckGorsel.UseVisualStyleBackColor = true;
            this.ckGorsel.CheckedChanged += new System.EventHandler(this.ckGorsel_CheckedChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(74, 85);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(392, 96);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label1.Location = new System.Drawing.Point(58, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "Konu Başlığı";
            // 
            // txtgorselurl
            // 
            this.txtgorselurl.Location = new System.Drawing.Point(255, 186);
            this.txtgorselurl.Name = "txtgorselurl";
            this.txtgorselurl.Size = new System.Drawing.Size(211, 22);
            this.txtgorselurl.TabIndex = 4;
            this.txtgorselurl.Visible = false;
            // 
            // txtcevapyanlis1
            // 
            this.txtcevapyanlis1.Location = new System.Drawing.Point(158, 252);
            this.txtcevapyanlis1.Name = "txtcevapyanlis1";
            this.txtcevapyanlis1.Size = new System.Drawing.Size(308, 22);
            this.txtcevapyanlis1.TabIndex = 6;
            // 
            // txtcevapyanlis2
            // 
            this.txtcevapyanlis2.Location = new System.Drawing.Point(158, 293);
            this.txtcevapyanlis2.Name = "txtcevapyanlis2";
            this.txtcevapyanlis2.Size = new System.Drawing.Size(308, 22);
            this.txtcevapyanlis2.TabIndex = 7;
            // 
            // txtcevapyanlis3
            // 
            this.txtcevapyanlis3.Location = new System.Drawing.Point(158, 335);
            this.txtcevapyanlis3.Name = "txtcevapyanlis3";
            this.txtcevapyanlis3.Size = new System.Drawing.Size(308, 22);
            this.txtcevapyanlis3.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(58, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "Doğru Cevap";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(58, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Yanlış Cevap";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(58, 295);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "Yanlış Cevap";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(58, 338);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "Yanlış Cevap";
            // 
            // btnsoruekle
            // 
            this.btnsoruekle.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnsoruekle.ForeColor = System.Drawing.Color.MidnightBlue;
            this.btnsoruekle.Location = new System.Drawing.Point(61, 381);
            this.btnsoruekle.Name = "btnsoruekle";
            this.btnsoruekle.Size = new System.Drawing.Size(405, 55);
            this.btnsoruekle.TabIndex = 13;
            this.btnsoruekle.Text = "Soru Ekle";
            this.btnsoruekle.UseVisualStyleBackColor = true;
            this.btnsoruekle.Click += new System.EventHandler(this.btnsoruekle_Click);
            // 
            // btngeri
            // 
            this.btngeri.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Bold);
            this.btngeri.ForeColor = System.Drawing.Color.Navy;
            this.btngeri.Location = new System.Drawing.Point(12, 460);
            this.btngeri.Name = "btngeri";
            this.btngeri.Size = new System.Drawing.Size(75, 33);
            this.btngeri.TabIndex = 14;
            this.btngeri.Text = "Geri";
            this.btngeri.UseVisualStyleBackColor = true;
            this.btngeri.Click += new System.EventHandler(this.btngeri_Click);
            // 
            // txtrue
            // 
            this.txtrue.Location = new System.Drawing.Point(158, 216);
            this.txtrue.Name = "txtrue";
            this.txtrue.Size = new System.Drawing.Size(308, 22);
            this.txtrue.TabIndex = 15;
            // 
            // formsoruekleme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Red;
            this.ClientSize = new System.Drawing.Size(498, 505);
            this.Controls.Add(this.txtrue);
            this.Controls.Add(this.btngeri);
            this.Controls.Add(this.btnsoruekle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcevapyanlis3);
            this.Controls.Add(this.txtcevapyanlis2);
            this.Controls.Add(this.txtcevapyanlis1);
            this.Controls.Add(this.txtgorselurl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.ckGorsel);
            this.Controls.Add(this.cmbKonu);
            this.Name = "formsoruekleme";
            this.Text = "Soru Ekleme";
            this.Load += new System.EventHandler(this.formsoruekleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKonu;
        private System.Windows.Forms.CheckBox ckGorsel;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgorselurl;
        private System.Windows.Forms.TextBox txtcevapyanlis1;
        private System.Windows.Forms.TextBox txtcevapyanlis2;
        private System.Windows.Forms.TextBox txtcevapyanlis3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnsoruekle;
        private System.Windows.Forms.Button btngeri;
        private System.Windows.Forms.TextBox txtrue;
    }
}