namespace FPGA_Communication
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelSendStatus = new System.Windows.Forms.Label();
            this.labelConnectStatus = new System.Windows.Forms.Label();
            this.buttonSend = new System.Windows.Forms.Button();
            this.buttonComConn = new System.Windows.Forms.Button();
            this.comboBox_ComList = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dosyaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(425, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dosyaToolStripMenuItem
            // 
            this.dosyaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acToolStripMenuItem});
            this.dosyaToolStripMenuItem.Name = "dosyaToolStripMenuItem";
            this.dosyaToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            // 
            // acToolStripMenuItem
            // 
            this.acToolStripMenuItem.Name = "acToolStripMenuItem";
            this.acToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.acToolStripMenuItem.Text = "Aç";
            this.acToolStripMenuItem.Click += new System.EventHandler(this.acToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(218, 50);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.labelSendStatus);
            this.groupBox1.Controls.Add(this.labelConnectStatus);
            this.groupBox1.Controls.Add(this.buttonSend);
            this.groupBox1.Controls.Add(this.buttonComConn);
            this.groupBox1.Controls.Add(this.comboBox_ComList);
            this.groupBox1.Location = new System.Drawing.Point(12, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 280);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "UART";
            // 
            // labelSendStatus
            // 
            this.labelSendStatus.AutoSize = true;
            this.labelSendStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSendStatus.Location = new System.Drawing.Point(13, 243);
            this.labelSendStatus.Name = "labelSendStatus";
            this.labelSendStatus.Size = new System.Drawing.Size(0, 18);
            this.labelSendStatus.TabIndex = 2;
            // 
            // labelConnectStatus
            // 
            this.labelConnectStatus.AutoSize = true;
            this.labelConnectStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelConnectStatus.Location = new System.Drawing.Point(38, 163);
            this.labelConnectStatus.Name = "labelConnectStatus";
            this.labelConnectStatus.Size = new System.Drawing.Size(126, 18);
            this.labelConnectStatus.TabIndex = 2;
            this.labelConnectStatus.Text = "BAĞLANTI YOK";
            this.labelConnectStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonSend
            // 
            this.buttonSend.Enabled = false;
            this.buttonSend.Location = new System.Drawing.Point(41, 110);
            this.buttonSend.Name = "buttonSend";
            this.buttonSend.Size = new System.Drawing.Size(121, 30);
            this.buttonSend.TabIndex = 1;
            this.buttonSend.Text = "GÖNDER";
            this.buttonSend.UseVisualStyleBackColor = true;
            this.buttonSend.Click += new System.EventHandler(this.buttonSend_Click);
            // 
            // buttonComConn
            // 
            this.buttonComConn.Location = new System.Drawing.Point(41, 74);
            this.buttonComConn.Name = "buttonComConn";
            this.buttonComConn.Size = new System.Drawing.Size(121, 30);
            this.buttonComConn.TabIndex = 1;
            this.buttonComConn.Text = "BAĞLAN";
            this.buttonComConn.UseVisualStyleBackColor = true;
            this.buttonComConn.Click += new System.EventHandler(this.buttonComConn_Click);
            // 
            // comboBox_ComList
            // 
            this.comboBox_ComList.FormattingEnabled = true;
            this.comboBox_ComList.Location = new System.Drawing.Point(41, 34);
            this.comboBox_ComList.Name = "comboBox_ComList";
            this.comboBox_ComList.Size = new System.Drawing.Size(121, 21);
            this.comboBox_ComList.TabIndex = 0;
            this.comboBox_ComList.Click += new System.EventHandler(this.comboBox_ComList_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(246, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 18);
            this.label3.TabIndex = 2;
            this.label3.Text = "BAUDRATE 921600";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 193);
            this.progressBar1.Maximum = 200;
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(164, 23);
            this.progressBar1.Step = 1;
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 336);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "FPGA UART Image Sender Version 1.0";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button buttonComConn;
        private System.Windows.Forms.ComboBox comboBox_ComList;
        private System.Windows.Forms.Button buttonSend;
        private System.Windows.Forms.Label labelSendStatus;
        private System.Windows.Forms.Label labelConnectStatus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

