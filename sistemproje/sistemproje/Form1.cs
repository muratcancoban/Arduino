using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sistemproje
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}
		private string data;
		private void Form1_Load(object sender, EventArgs e)
		{
			textBox1.ReadOnly = true;                    //textBox1'i yalnızca okunabilir şekilde ayarla
			string[] ports = SerialPort.GetPortNames();  //Seri portları diziye ekleme
			foreach (string port in ports)
				comboBox1.Items.Add(port);               //Seri portları comboBox1'e ekleme

			serialPort1.DataReceived += new SerialDataReceivedEventHandler(SerialPort1_DataReceived); //DataReceived eventini oluşturma
		}
		private void SerialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
		{
			data = serialPort1.ReadLine();                      //Veriyi al
			this.Invoke(new EventHandler(displayData_event));
		}
		private void displayData_event(object sender, EventArgs e)
		{
			progressBar1.Value = Convert.ToInt16(data);                          //Gelen değeri ProgressBar'ın değerine eşitle
			textBox1.Text += DateTime.Now.ToString() + "        " + data + "\n"; //Gelen veriyi textBox içine güncel tarih ve zaman ile ekle
			isikDegeri.Text = "Işık Değeri = " + data;                               //Gelen veriyi label'1 e eşitle
			
			if (Convert.ToInt16(data) < 15)
			{
				radioButton1.Checked = true; //açık
			}
			else
			{
				radioButton2.Checked = true;//kapalı
			}
		}

		private void basla_Click(object sender, EventArgs e)
		{
			try
			{
				serialPort1.PortName = comboBox1.Text;  //ComboBox1'de seçili nesneyi port ismine ata
				serialPort1.BaudRate = 9600;            //BaudRate 9600 olarak ayarla
				serialPort1.Open();                     //Seri portu aç
				durdur.Enabled = true;                  //Durdurma butonunu aktif hale getir
				basla.Enabled = false;                 //Başlatma butonunu pasif hale getir
			}

			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Hata");    //Hata mesajı göster
			}
		}

		private void durdur_Click(object sender, EventArgs e)
		{
			serialPort1.Close();        //Seri Portu kapa
			durdur.Enabled = false;     //Durdurma butonunu pasif hale getir
			basla.Enabled = true;      //Başlatma butonunu aktif hale getir
		}

		private void sifirla_Click(object sender, EventArgs e)
		{
			textBox1.ResetText();           //textBox1'i sıfırla
		}

		private void kaydet_Click(object sender, EventArgs e)
		{
			try
			{
				string filelocation = @"..\..\";                    //Dosyanın kaydedileceği konumu belirliyoruz
				string filename = "data.txt";                                                               //Kaydedilecek dosyanın ismi
				System.IO.File.WriteAllText(filelocation + filename, "Zaman\t\t\tDeğer\n" + textBox1.Text); //Dosya konumuna textBox1 üstündeki verilerden oluşan text dosyamızı kaydediyoruz
				MessageBox.Show("Dosya başarıyla kaydedildi", "Mesaj");                                     //Dosya kaydedildiğinde kullanıcıya mesaj gönder
			}
			catch (Exception ex2)
			{
				MessageBox.Show(ex2.Message, "Hata");       //Hata mesajı
			}
		}
		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			if (serialPort1.IsOpen) serialPort1.Close();    //Seri port açıksa kapat
		}
	}
}
