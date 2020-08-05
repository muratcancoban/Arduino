namespace sistemproje
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
			this.basla = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.isikDegeri = new System.Windows.Forms.Label();
			this.progressBar1 = new System.Windows.Forms.ProgressBar();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
			this.comboBox1 = new System.Windows.Forms.ComboBox();
			this.durdur = new System.Windows.Forms.Button();
			this.sifirla = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.kaydet = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// basla
			// 
			this.basla.Location = new System.Drawing.Point(80, 121);
			this.basla.Name = "basla";
			this.basla.Size = new System.Drawing.Size(75, 23);
			this.basla.TabIndex = 0;
			this.basla.Text = "Basla";
			this.basla.UseVisualStyleBackColor = true;
			this.basla.Click += new System.EventHandler(this.basla_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(287, 12);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(240, 188);
			this.textBox1.TabIndex = 1;
			// 
			// isikDegeri
			// 
			this.isikDegeri.AutoSize = true;
			this.isikDegeri.Location = new System.Drawing.Point(378, 232);
			this.isikDegeri.Name = "isikDegeri";
			this.isikDegeri.Size = new System.Drawing.Size(0, 13);
			this.isikDegeri.TabIndex = 2;
			// 
			// progressBar1
			// 
			this.progressBar1.Location = new System.Drawing.Point(287, 206);
			this.progressBar1.MarqueeAnimationSpeed = 50;
			this.progressBar1.Maximum = 1023;
			this.progressBar1.Name = "progressBar1";
			this.progressBar1.Size = new System.Drawing.Size(240, 23);
			this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.progressBar1.TabIndex = 5;
			// 
			// timer1
			// 
			this.timer1.Interval = 1000;
			// 
			// comboBox1
			// 
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Location = new System.Drawing.Point(109, 67);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new System.Drawing.Size(121, 21);
			this.comboBox1.TabIndex = 4;
			// 
			// durdur
			// 
			this.durdur.Location = new System.Drawing.Point(171, 121);
			this.durdur.Name = "durdur";
			this.durdur.Size = new System.Drawing.Size(75, 23);
			this.durdur.TabIndex = 0;
			this.durdur.Text = "Durdur";
			this.durdur.UseVisualStyleBackColor = true;
			this.durdur.Click += new System.EventHandler(this.durdur_Click);
			// 
			// sifirla
			// 
			this.sifirla.Location = new System.Drawing.Point(123, 150);
			this.sifirla.Name = "sifirla";
			this.sifirla.Size = new System.Drawing.Size(75, 23);
			this.sifirla.TabIndex = 0;
			this.sifirla.Text = "Sıfırla";
			this.sifirla.UseVisualStyleBackColor = true;
			this.sifirla.Click += new System.EventHandler(this.sifirla_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(64, 75);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Port";
			// 
			// kaydet
			// 
			this.kaydet.Location = new System.Drawing.Point(206, 159);
			this.kaydet.Name = "kaydet";
			this.kaydet.Size = new System.Drawing.Size(75, 41);
			this.kaydet.TabIndex = 0;
			this.kaydet.Text = "Kaydet";
			this.kaydet.UseVisualStyleBackColor = true;
			this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.radioButton2);
			this.panel1.Controls.Add(this.radioButton1);
			this.panel1.Location = new System.Drawing.Point(0, 179);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(200, 100);
			this.panel1.TabIndex = 7;
			// 
			// radioButton1
			// 
			this.radioButton1.AutoSize = true;
			this.radioButton1.Location = new System.Drawing.Point(12, 14);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(70, 17);
			this.radioButton1.TabIndex = 0;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "Led Açık!";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.AutoSize = true;
			this.radioButton2.Location = new System.Drawing.Point(12, 53);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(78, 17);
			this.radioButton2.TabIndex = 0;
			this.radioButton2.TabStop = true;
			this.radioButton2.Text = "Led Kapalı!";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(554, 347);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.comboBox1);
			this.Controls.Add(this.progressBar1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.isikDegeri);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.kaydet);
			this.Controls.Add(this.sifirla);
			this.Controls.Add(this.durdur);
			this.Controls.Add(this.basla);
			this.Name = "Form1";
			this.Text = "Form1";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
			this.Load += new System.EventHandler(this.Form1_Load);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button basla;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label isikDegeri;
		private System.Windows.Forms.ProgressBar progressBar1;
		private System.Windows.Forms.Timer timer1;
		private System.IO.Ports.SerialPort serialPort1;
		private System.Windows.Forms.ComboBox comboBox1;
		private System.Windows.Forms.Button durdur;
		private System.Windows.Forms.Button sifirla;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button kaydet;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.RadioButton radioButton2;
		private System.Windows.Forms.RadioButton radioButton1;
	}
}

