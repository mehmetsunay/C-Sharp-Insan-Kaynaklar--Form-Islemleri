
namespace FormDersleri_2
{
    partial class FrmPersonelTakip
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
            this.btn_ollist = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.lbl_personel = new System.Windows.Forms.Label();
            this.txt_personel = new System.Windows.Forms.TextBox();
            this.btn_ara = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbl_sonuc = new System.Windows.Forms.Label();
            this.btn_sonpersonel = new System.Windows.Forms.Button();
            this.btn_ucuncueleman = new System.Windows.Forms.Button();
            this.btn_toplam = new System.Windows.Forms.Button();
            this.btn_besbinyedibin = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.btn_enykskmaasper = new System.Windows.Forms.Button();
            this.btn_endskmaas = new System.Windows.Forms.Button();
            this.btn_pergoster = new System.Windows.Forms.Button();
            this.btn_temizle = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ollist
            // 
            this.btn_ollist.Location = new System.Drawing.Point(22, 24);
            this.btn_ollist.Name = "btn_ollist";
            this.btn_ollist.Size = new System.Drawing.Size(336, 29);
            this.btn_ollist.TabIndex = 0;
            this.btn_ollist.Text = "OLUŞTUR VE LİSTELE";
            this.btn_ollist.UseVisualStyleBackColor = true;
            this.btn_ollist.Click += new System.EventHandler(this.btn_ollist_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 20;
            this.listBox1.Location = new System.Drawing.Point(22, 87);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(336, 104);
            this.listBox1.TabIndex = 1;
            // 
            // lbl_personel
            // 
            this.lbl_personel.AutoSize = true;
            this.lbl_personel.Location = new System.Drawing.Point(23, 234);
            this.lbl_personel.Name = "lbl_personel";
            this.lbl_personel.Size = new System.Drawing.Size(79, 20);
            this.lbl_personel.TabIndex = 2;
            this.lbl_personel.Text = "PERSONEL";
            // 
            // txt_personel
            // 
            this.txt_personel.Location = new System.Drawing.Point(117, 229);
            this.txt_personel.Name = "txt_personel";
            this.txt_personel.Size = new System.Drawing.Size(125, 27);
            this.txt_personel.TabIndex = 3;
            // 
            // btn_ara
            // 
            this.btn_ara.Location = new System.Drawing.Point(257, 228);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(72, 29);
            this.btn_ara.TabIndex = 4;
            this.btn_ara.Text = "ARA";
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbl_sonuc);
            this.groupBox1.Controls.Add(this.btn_sonpersonel);
            this.groupBox1.Controls.Add(this.btn_ucuncueleman);
            this.groupBox1.Controls.Add(this.btn_toplam);
            this.groupBox1.Controls.Add(this.btn_besbinyedibin);
            this.groupBox1.Controls.Add(this.button7);
            this.groupBox1.Controls.Add(this.btn_enykskmaasper);
            this.groupBox1.Controls.Add(this.btn_endskmaas);
            this.groupBox1.Controls.Add(this.btn_pergoster);
            this.groupBox1.Controls.Add(this.btn_temizle);
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.btn_ara);
            this.groupBox1.Controls.Add(this.btn_ollist);
            this.groupBox1.Controls.Add(this.txt_personel);
            this.groupBox1.Controls.Add(this.lbl_personel);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(869, 414);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İŞLEM KAYDI";
            // 
            // lbl_sonuc
            // 
            this.lbl_sonuc.AutoSize = true;
            this.lbl_sonuc.Location = new System.Drawing.Point(441, 391);
            this.lbl_sonuc.Name = "lbl_sonuc";
            this.lbl_sonuc.Size = new System.Drawing.Size(69, 20);
            this.lbl_sonuc.TabIndex = 14;
            this.lbl_sonuc.Text = "SONUÇ : ";
            // 
            // btn_sonpersonel
            // 
            this.btn_sonpersonel.Location = new System.Drawing.Point(710, 277);
            this.btn_sonpersonel.Name = "btn_sonpersonel";
            this.btn_sonpersonel.Size = new System.Drawing.Size(133, 93);
            this.btn_sonpersonel.TabIndex = 13;
            this.btn_sonpersonel.Text = "SON PERSONELİN ADI";
            this.btn_sonpersonel.UseVisualStyleBackColor = true;
            this.btn_sonpersonel.Click += new System.EventHandler(this.btn_sonpersonel_Click);
            // 
            // btn_ucuncueleman
            // 
            this.btn_ucuncueleman.Location = new System.Drawing.Point(570, 279);
            this.btn_ucuncueleman.Name = "btn_ucuncueleman";
            this.btn_ucuncueleman.Size = new System.Drawing.Size(123, 91);
            this.btn_ucuncueleman.TabIndex = 12;
            this.btn_ucuncueleman.Text = "LİSTEDEKİ 3.ELEMANIN MAAŞINI 500 ARTTIR";
            this.btn_ucuncueleman.UseVisualStyleBackColor = true;
            this.btn_ucuncueleman.Click += new System.EventHandler(this.btn_ucuncueleman_Click);
            // 
            // btn_toplam
            // 
            this.btn_toplam.Location = new System.Drawing.Point(441, 277);
            this.btn_toplam.Name = "btn_toplam";
            this.btn_toplam.Size = new System.Drawing.Size(109, 93);
            this.btn_toplam.TabIndex = 11;
            this.btn_toplam.Text = "TOPLAM ÖDENEN MAAŞ";
            this.btn_toplam.UseVisualStyleBackColor = true;
            this.btn_toplam.Click += new System.EventHandler(this.btn_toplam_Click);
            // 
            // btn_besbinyedibin
            // 
            this.btn_besbinyedibin.Location = new System.Drawing.Point(710, 152);
            this.btn_besbinyedibin.Name = "btn_besbinyedibin";
            this.btn_besbinyedibin.Size = new System.Drawing.Size(133, 96);
            this.btn_besbinyedibin.TabIndex = 10;
            this.btn_besbinyedibin.Text = "MAAŞI 5000-7000 ARASI OLANLARIN SAYISI";
            this.btn_besbinyedibin.UseVisualStyleBackColor = true;
            this.btn_besbinyedibin.Click += new System.EventHandler(this.btn_besbinyedibin_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(570, 152);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(123, 96);
            this.button7.TabIndex = 9;
            this.button7.Text = "MAAŞI 4000 DEN AZ OLANLAR";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // btn_enykskmaasper
            // 
            this.btn_enykskmaasper.Location = new System.Drawing.Point(441, 152);
            this.btn_enykskmaasper.Name = "btn_enykskmaasper";
            this.btn_enykskmaasper.Size = new System.Drawing.Size(109, 96);
            this.btn_enykskmaasper.TabIndex = 8;
            this.btn_enykskmaasper.Text = "EN YUKSEK MAAŞLI PERSONEL";
            this.btn_enykskmaasper.UseVisualStyleBackColor = true;
            this.btn_enykskmaasper.Click += new System.EventHandler(this.btn_enykskmaasper_Click);
            // 
            // btn_endskmaas
            // 
            this.btn_endskmaas.Location = new System.Drawing.Point(710, 49);
            this.btn_endskmaas.Name = "btn_endskmaas";
            this.btn_endskmaas.Size = new System.Drawing.Size(133, 81);
            this.btn_endskmaas.TabIndex = 7;
            this.btn_endskmaas.Text = "EN DÜŞÜK MAAŞ";
            this.btn_endskmaas.UseVisualStyleBackColor = true;
            this.btn_endskmaas.Click += new System.EventHandler(this.btn_endskmaas_Click);
            // 
            // btn_pergoster
            // 
            this.btn_pergoster.Location = new System.Drawing.Point(570, 49);
            this.btn_pergoster.Name = "btn_pergoster";
            this.btn_pergoster.Size = new System.Drawing.Size(123, 81);
            this.btn_pergoster.TabIndex = 6;
            this.btn_pergoster.Text = "TOPLAM PERSONELİ GÖSTER";
            this.btn_pergoster.UseVisualStyleBackColor = true;
            this.btn_pergoster.Click += new System.EventHandler(this.btn_pergoster_Click);
            // 
            // btn_temizle
            // 
            this.btn_temizle.Location = new System.Drawing.Point(441, 49);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(109, 81);
            this.btn_temizle.TabIndex = 5;
            this.btn_temizle.Text = "LİST BOX TEMİZLE";
            this.btn_temizle.UseVisualStyleBackColor = true;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_ollist;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lbl_personel;
        private System.Windows.Forms.TextBox txt_personel;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_sonpersonel;
        private System.Windows.Forms.Button btn_ucuncueleman;
        private System.Windows.Forms.Button btn_toplam;
        private System.Windows.Forms.Button btn_besbinyedibin;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button btn_enykskmaasper;
        private System.Windows.Forms.Button btn_endskmaas;
        private System.Windows.Forms.Button btn_pergoster;
        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Label lbl_sonuc;
    }
}

