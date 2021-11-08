using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace FPGA_Communication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string[] serialPorts = SerialPort.GetPortNames();
        
        Bitmap resizedImage;

        public void DosyaAc()
        {
            try
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                openFileDialog1.DefaultExt = ".jpg";
                openFileDialog1.Filter = "Image Files(*.BMP;*.JPG;*.GIF)|*.BMP;*.JPG;*.GIF|All files (*.*)|*.*";
                openFileDialog1.ShowDialog();
                String resminYolu = openFileDialog1.FileName;                
                resizedImage = new Bitmap(Image.FromFile(resminYolu), new Size(200, 200));
                pictureBox1.Image = resizedImage;

            }
            catch (Exception err)
			{
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);				
			}
        }        

        private void acToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DosyaAc();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox_ComList.Items.AddRange(serialPorts);
        }

        private void buttonComConn_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.PortName = comboBox_ComList.Text;
                    serialPort1.BaudRate = 921600;
                    serialPort1.DataBits = 8;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.Parity = Parity.None;
                    serialPort1.Open();
                    buttonComConn.Text = "KAPAT";
                    comboBox_ComList.Enabled = false;
                    buttonSend.Enabled = true;
                    labelConnectStatus.Text = "BAĞLANDI";
                }
                else
                {
                    serialPort1.Close();
                    buttonComConn.Text = "BAĞLAN";
                    comboBox_ComList.Enabled = true;
                    buttonSend.Enabled = false;
                    labelConnectStatus.Text = "BAĞLANTI YOK";
                    labelSendStatus.Text = "";
                    progressBar1.Value = 0;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (serialPort1.IsOpen == true) serialPort1.Close();
        }

        private void buttonSend_Click(object sender, EventArgs e)
        {
            try
            {
                progressBar1.Value = 0;
                labelSendStatus.Text = "";
                Color OkunanRenk;
                byte[] buffer = new byte[600];
                byte R = 0, G = 0, B = 0;
                int ResimGenisligi = resizedImage.Width; //GirisResmi global tanımlandı
                int ResimYuksekligi = resizedImage.Height;
                int indexBuffer = 0;

                for (int x = 0; x < ResimGenisligi; x++)
                {
                    for (int y = 0; y < ResimYuksekligi; y++)
                    {
                        OkunanRenk = resizedImage.GetPixel(x, y);
                        R = Convert.ToByte(OkunanRenk.R);
                        G = Convert.ToByte(OkunanRenk.G);
                        B = Convert.ToByte(OkunanRenk.B);
                        buffer[indexBuffer] = R;
                        buffer[++indexBuffer] = G;
                        buffer[++indexBuffer] = B;
                        ++indexBuffer;
                    }

                    progressBar1.Value += 1;
                    serialPort1.Write(buffer, 0, 600);
                    indexBuffer = 0;
                }
                labelSendStatus.Text = "RESİM GÖNDERİLDİ";               
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                     
        }

        private void comboBox_ComList_Click(object sender, EventArgs e)
        {
            comboBox_ComList.Items.Clear();
            serialPorts = SerialPort.GetPortNames();
            comboBox_ComList.Items.AddRange(serialPorts);
        }        
    }
}
