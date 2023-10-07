namespace nesne_odev
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.gBox = new System.Windows.Forms.GroupBox();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.mGirisDeger2 = new System.Windows.Forms.MaskedTextBox();
            this.mGirisDeger = new System.Windows.Forms.MaskedTextBox();
            this.Calistir = new System.Windows.Forms.Button();
            this.tabSayılar = new System.Windows.Forms.TabControl();
            this.tabTekSayi = new System.Windows.Forms.TabPage();
            this.listTekSayilar = new System.Windows.Forms.ListView();
            this.columnTekSayilar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabCiftSayi = new System.Windows.Forms.TabPage();
            this.listCiftSayilar = new System.Windows.Forms.ListView();
            this.columnCiftSayi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabAsalSayi = new System.Windows.Forms.TabPage();
            this.listAsalSayilar = new System.Windows.Forms.ListView();
            this.columnAsalSayilar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabMukemmelSayilar = new System.Windows.Forms.TabPage();
            this.listMükemmelSayilar = new System.Windows.Forms.ListView();
            this.columnMukemmelSayilar = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.gBox.SuspendLayout();
            this.tabSayılar.SuspendLayout();
            this.tabTekSayi.SuspendLayout();
            this.tabCiftSayi.SuspendLayout();
            this.tabAsalSayi.SuspendLayout();
            this.tabMukemmelSayilar.SuspendLayout();
            this.SuspendLayout();
            // 
            // gBox
            // 
            this.gBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.gBox.Controls.Add(this.lbl2);
            this.gBox.Controls.Add(this.lbl1);
            this.gBox.Controls.Add(this.mGirisDeger2);
            this.gBox.Controls.Add(this.mGirisDeger);
            this.gBox.Controls.Add(this.Calistir);
            this.gBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.gBox.Location = new System.Drawing.Point(45, 22);
            this.gBox.Name = "gBox";
            this.gBox.Size = new System.Drawing.Size(663, 126);
            this.gBox.TabIndex = 13;
            this.gBox.TabStop = false;
            this.gBox.Text = "Giriş Bilgileri";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(243, 58);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(32, 16);
            this.lbl2.TabIndex = 11;
            this.lbl2.Text = "Bitiş";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(32, 55);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(67, 16);
            this.lbl1.TabIndex = 10;
            this.lbl1.Text = "Başlangıç";
            // 
            // mGirisDeger2
            // 
            this.mGirisDeger2.Location = new System.Drawing.Point(281, 55);
            this.mGirisDeger2.Name = "mGirisDeger2";
            this.mGirisDeger2.Size = new System.Drawing.Size(100, 22);
            this.mGirisDeger2.TabIndex = 9;
            // 
            // mGirisDeger
            // 
            this.mGirisDeger.Location = new System.Drawing.Point(105, 52);
            this.mGirisDeger.Name = "mGirisDeger";
            this.mGirisDeger.Size = new System.Drawing.Size(100, 22);
            this.mGirisDeger.TabIndex = 8;
            // 
            // Calistir
            // 
            this.Calistir.Location = new System.Drawing.Point(427, 55);
            this.Calistir.Name = "Calistir";
            this.Calistir.Size = new System.Drawing.Size(75, 23);
            this.Calistir.TabIndex = 3;
            this.Calistir.Text = "Hesapla";
            this.Calistir.UseVisualStyleBackColor = true;
            this.Calistir.Click += new System.EventHandler(this.Calistir_Click);
            // 
            // tabSayılar
            // 
            this.tabSayılar.Controls.Add(this.tabTekSayi);
            this.tabSayılar.Controls.Add(this.tabCiftSayi);
            this.tabSayılar.Controls.Add(this.tabAsalSayi);
            this.tabSayılar.Controls.Add(this.tabMukemmelSayilar);
            this.tabSayılar.Location = new System.Drawing.Point(38, 174);
            this.tabSayılar.Name = "tabSayılar";
            this.tabSayılar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tabSayılar.SelectedIndex = 0;
            this.tabSayılar.Size = new System.Drawing.Size(725, 255);
            this.tabSayılar.TabIndex = 12;
            // 
            // tabTekSayi
            // 
            this.tabTekSayi.Controls.Add(this.listTekSayilar);
            this.tabTekSayi.Location = new System.Drawing.Point(4, 25);
            this.tabTekSayi.Name = "tabTekSayi";
            this.tabTekSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tabTekSayi.Size = new System.Drawing.Size(717, 226);
            this.tabTekSayi.TabIndex = 0;
            this.tabTekSayi.Text = "Tek Sayılar";
            this.tabTekSayi.UseVisualStyleBackColor = true;
            // 
            // listTekSayilar
            // 
            this.listTekSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTekSayilar});
            this.listTekSayilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listTekSayilar.HideSelection = false;
            this.listTekSayilar.Location = new System.Drawing.Point(3, 3);
            this.listTekSayilar.Name = "listTekSayilar";
            this.listTekSayilar.Size = new System.Drawing.Size(711, 220);
            this.listTekSayilar.TabIndex = 4;
            this.listTekSayilar.UseCompatibleStateImageBehavior = false;
            this.listTekSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnTekSayilar
            // 
            this.columnTekSayilar.Text = "Tek Sayılar";
            this.columnTekSayilar.Width = 200;
            // 
            // tabCiftSayi
            // 
            this.tabCiftSayi.Controls.Add(this.listCiftSayilar);
            this.tabCiftSayi.Location = new System.Drawing.Point(4, 25);
            this.tabCiftSayi.Name = "tabCiftSayi";
            this.tabCiftSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tabCiftSayi.Size = new System.Drawing.Size(717, 226);
            this.tabCiftSayi.TabIndex = 1;
            this.tabCiftSayi.Text = "Çift Sayılar";
            this.tabCiftSayi.UseVisualStyleBackColor = true;
            // 
            // listCiftSayilar
            // 
            this.listCiftSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnCiftSayi});
            this.listCiftSayilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listCiftSayilar.HideSelection = false;
            this.listCiftSayilar.Location = new System.Drawing.Point(3, 3);
            this.listCiftSayilar.Name = "listCiftSayilar";
            this.listCiftSayilar.Size = new System.Drawing.Size(711, 220);
            this.listCiftSayilar.TabIndex = 7;
            this.listCiftSayilar.UseCompatibleStateImageBehavior = false;
            this.listCiftSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnCiftSayi
            // 
            this.columnCiftSayi.Text = "Çift Sayılar";
            this.columnCiftSayi.Width = 200;
            // 
            // tabAsalSayi
            // 
            this.tabAsalSayi.Controls.Add(this.listAsalSayilar);
            this.tabAsalSayi.Location = new System.Drawing.Point(4, 25);
            this.tabAsalSayi.Name = "tabAsalSayi";
            this.tabAsalSayi.Padding = new System.Windows.Forms.Padding(3);
            this.tabAsalSayi.Size = new System.Drawing.Size(717, 226);
            this.tabAsalSayi.TabIndex = 2;
            this.tabAsalSayi.Text = "Asal Sayılar";
            this.tabAsalSayi.UseVisualStyleBackColor = true;
            // 
            // listAsalSayilar
            // 
            this.listAsalSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnAsalSayilar});
            this.listAsalSayilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listAsalSayilar.HideSelection = false;
            this.listAsalSayilar.Location = new System.Drawing.Point(3, 3);
            this.listAsalSayilar.Name = "listAsalSayilar";
            this.listAsalSayilar.Size = new System.Drawing.Size(711, 220);
            this.listAsalSayilar.TabIndex = 6;
            this.listAsalSayilar.UseCompatibleStateImageBehavior = false;
            this.listAsalSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnAsalSayilar
            // 
            this.columnAsalSayilar.Text = "Asal Sayılar";
            this.columnAsalSayilar.Width = 200;
            // 
            // tabMukemmelSayilar
            // 
            this.tabMukemmelSayilar.Controls.Add(this.listMükemmelSayilar);
            this.tabMukemmelSayilar.Location = new System.Drawing.Point(4, 25);
            this.tabMukemmelSayilar.Name = "tabMukemmelSayilar";
            this.tabMukemmelSayilar.Padding = new System.Windows.Forms.Padding(3);
            this.tabMukemmelSayilar.Size = new System.Drawing.Size(717, 226);
            this.tabMukemmelSayilar.TabIndex = 3;
            this.tabMukemmelSayilar.Text = "Mükemmel Sayılar";
            this.tabMukemmelSayilar.UseVisualStyleBackColor = true;
            // 
            // listMükemmelSayilar
            // 
            this.listMükemmelSayilar.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnMukemmelSayilar});
            this.listMükemmelSayilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listMükemmelSayilar.HideSelection = false;
            this.listMükemmelSayilar.Location = new System.Drawing.Point(3, 3);
            this.listMükemmelSayilar.Name = "listMükemmelSayilar";
            this.listMükemmelSayilar.Size = new System.Drawing.Size(711, 220);
            this.listMükemmelSayilar.TabIndex = 7;
            this.listMükemmelSayilar.UseCompatibleStateImageBehavior = false;
            this.listMükemmelSayilar.View = System.Windows.Forms.View.Details;
            // 
            // columnMukemmelSayilar
            // 
            this.columnMukemmelSayilar.Text = "Mükemmel Sayılar";
            this.columnMukemmelSayilar.Width = 200;
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipText = "Programa Hoşgeldiniz!";
            this.notifyIcon1.BalloonTipTitle = "Nesne Yönelimli Programlama";
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Programa Hoşgeldiniz!";
            this.notifyIcon1.Visible = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gBox);
            this.Controls.Add(this.tabSayılar);
            this.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Name = "Form1";
            this.Text = "Form1";
            this.gBox.ResumeLayout(false);
            this.gBox.PerformLayout();
            this.tabSayılar.ResumeLayout(false);
            this.tabTekSayi.ResumeLayout(false);
            this.tabCiftSayi.ResumeLayout(false);
            this.tabAsalSayi.ResumeLayout(false);
            this.tabMukemmelSayilar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gBox;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.MaskedTextBox mGirisDeger2;
        private System.Windows.Forms.MaskedTextBox mGirisDeger;
        private System.Windows.Forms.Button Calistir;
        private System.Windows.Forms.TabControl tabSayılar;
        private System.Windows.Forms.TabPage tabTekSayi;
        private System.Windows.Forms.ListView listTekSayilar;
        private System.Windows.Forms.ColumnHeader columnTekSayilar;
        private System.Windows.Forms.TabPage tabCiftSayi;
        private System.Windows.Forms.ListView listCiftSayilar;
        private System.Windows.Forms.ColumnHeader columnCiftSayi;
        private System.Windows.Forms.TabPage tabAsalSayi;
        private System.Windows.Forms.ListView listAsalSayilar;
        private System.Windows.Forms.ColumnHeader columnAsalSayilar;
        private System.Windows.Forms.TabPage tabMukemmelSayilar;
        private System.Windows.Forms.ListView listMükemmelSayilar;
        private System.Windows.Forms.ColumnHeader columnMukemmelSayilar;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

