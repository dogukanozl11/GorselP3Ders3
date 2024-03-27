namespace GorselP3Ders3
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
            this.btnKelimeGetir = new System.Windows.Forms.Button();
            this.checkBoxEN = new System.Windows.Forms.CheckBox();
            this.lblKelime = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDene = new System.Windows.Forms.Button();
            this.lblHak = new System.Windows.Forms.Label();
            this.txtHarf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnTahmin = new System.Windows.Forms.Button();
            this.txtTahmin = new System.Windows.Forms.TextBox();
            this.btnÇıkıs = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnKelimeGetir
            // 
            this.btnKelimeGetir.BackColor = System.Drawing.SystemColors.Info;
            this.btnKelimeGetir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnKelimeGetir.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKelimeGetir.Location = new System.Drawing.Point(108, 25);
            this.btnKelimeGetir.Name = "btnKelimeGetir";
            this.btnKelimeGetir.Size = new System.Drawing.Size(130, 44);
            this.btnKelimeGetir.TabIndex = 0;
            this.btnKelimeGetir.Text = "Kelime Getir";
            this.btnKelimeGetir.UseVisualStyleBackColor = false;
            this.btnKelimeGetir.Click += new System.EventHandler(this.btnKelimeGetir_Click);
            // 
            // checkBoxEN
            // 
            this.checkBoxEN.AutoSize = true;
            this.checkBoxEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.checkBoxEN.Location = new System.Drawing.Point(7, 34);
            this.checkBoxEN.Name = "checkBoxEN";
            this.checkBoxEN.Size = new System.Drawing.Size(95, 29);
            this.checkBoxEN.TabIndex = 1;
            this.checkBoxEN.Text = "English";
            this.checkBoxEN.UseVisualStyleBackColor = true;
            // 
            // lblKelime
            // 
            this.lblKelime.AutoSize = true;
            this.lblKelime.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKelime.Location = new System.Drawing.Point(260, 44);
            this.lblKelime.Name = "lblKelime";
            this.lblKelime.Size = new System.Drawing.Size(177, 25);
            this.lblKelime.TabIndex = 2;
            this.lblKelime.Text = "_______________";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.lblKelime);
            this.groupBox1.Controls.Add(this.btnKelimeGetir);
            this.groupBox1.Controls.Add(this.checkBoxEN);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 92);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kelime Seç";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.SystemColors.Info;
            this.groupBox2.Controls.Add(this.btnDene);
            this.groupBox2.Controls.Add(this.lblHak);
            this.groupBox2.Controls.Add(this.txtHarf);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(12, 110);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(447, 112);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Harf Tahmini Yap :";
            // 
            // btnDene
            // 
            this.btnDene.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDene.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDene.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDene.Location = new System.Drawing.Point(265, 59);
            this.btnDene.Name = "btnDene";
            this.btnDene.Size = new System.Drawing.Size(114, 40);
            this.btnDene.TabIndex = 3;
            this.btnDene.Text = "Dene";
            this.btnDene.UseVisualStyleBackColor = false;
            this.btnDene.Click += new System.EventHandler(this.btnDene_Click);
            // 
            // lblHak
            // 
            this.lblHak.AutoSize = true;
            this.lblHak.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHak.Location = new System.Drawing.Point(103, 25);
            this.lblHak.Name = "lblHak";
            this.lblHak.Size = new System.Drawing.Size(120, 25);
            this.lblHak.TabIndex = 2;
            this.lblHak.Text = "X . Hakkınız.";
            // 
            // txtHarf
            // 
            this.txtHarf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtHarf.Location = new System.Drawing.Point(133, 69);
            this.txtHarf.MaxLength = 1;
            this.txtHarf.Name = "txtHarf";
            this.txtHarf.Size = new System.Drawing.Size(90, 30);
            this.txtHarf.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(6, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Harf Gir --- >";
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox3.Controls.Add(this.btnTahmin);
            this.groupBox3.Controls.Add(this.txtTahmin);
            this.groupBox3.Location = new System.Drawing.Point(12, 228);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(447, 143);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Kelime Tahmin Et ";
            // 
            // btnTahmin
            // 
            this.btnTahmin.BackColor = System.Drawing.SystemColors.Info;
            this.btnTahmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahmin.Location = new System.Drawing.Point(235, 56);
            this.btnTahmin.Name = "btnTahmin";
            this.btnTahmin.Size = new System.Drawing.Size(137, 42);
            this.btnTahmin.TabIndex = 1;
            this.btnTahmin.Text = "Tahmin Et";
            this.btnTahmin.UseVisualStyleBackColor = false;
            this.btnTahmin.Click += new System.EventHandler(this.btnTahmin_Click);
            // 
            // txtTahmin
            // 
            this.txtTahmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtTahmin.Location = new System.Drawing.Point(20, 62);
            this.txtTahmin.Name = "txtTahmin";
            this.txtTahmin.Size = new System.Drawing.Size(170, 30);
            this.txtTahmin.TabIndex = 0;
            // 
            // btnÇıkıs
            // 
            this.btnÇıkıs.BackColor = System.Drawing.SystemColors.Info;
            this.btnÇıkıs.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnÇıkıs.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnÇıkıs.Location = new System.Drawing.Point(471, 329);
            this.btnÇıkıs.Name = "btnÇıkıs";
            this.btnÇıkıs.Size = new System.Drawing.Size(137, 42);
            this.btnÇıkıs.TabIndex = 1;
            this.btnÇıkıs.Text = "Çıkış Yap";
            this.btnÇıkıs.UseVisualStyleBackColor = false;
            this.btnÇıkıs.Click += new System.EventHandler(this.btnÇıkıs_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 374);
            this.Controls.Add(this.btnÇıkıs);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Kelime Tahmin Oyunu V1.0";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKelimeGetir;
        private System.Windows.Forms.CheckBox checkBoxEN;
        private System.Windows.Forms.Label lblKelime;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDene;
        private System.Windows.Forms.Label lblHak;
        private System.Windows.Forms.TextBox txtHarf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnTahmin;
        private System.Windows.Forms.TextBox txtTahmin;
        private System.Windows.Forms.Button btnÇıkıs;
    }
}

