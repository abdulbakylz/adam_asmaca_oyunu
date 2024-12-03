namespace adamasmaca
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            menuStrip1 = new MenuStrip();
            dOSYAToolStripMenuItem = new ToolStripMenuItem();
            çIKIŞToolStripMenuItem = new ToolStripMenuItem();
            dÜZENLEToolStripMenuItem = new ToolStripMenuItem();
            aDAMASMACAOYUNUToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            button1 = new Button();
            ımageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            eş_lab = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            button2 = new Button();
            maskedTextBox6 = new MaskedTextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { dOSYAToolStripMenuItem, dÜZENLEToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(810, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // dOSYAToolStripMenuItem
            // 
            dOSYAToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { çIKIŞToolStripMenuItem });
            dOSYAToolStripMenuItem.Name = "dOSYAToolStripMenuItem";
            dOSYAToolStripMenuItem.Size = new Size(70, 24);
            dOSYAToolStripMenuItem.Text = "DOSYA";
            // 
            // çIKIŞToolStripMenuItem
            // 
            çIKIŞToolStripMenuItem.Name = "çIKIŞToolStripMenuItem";
            çIKIŞToolStripMenuItem.Size = new Size(126, 26);
            çIKIŞToolStripMenuItem.Text = "ÇIKIŞ";
            çIKIŞToolStripMenuItem.Click += çIKIŞToolStripMenuItem_Click;
            // 
            // dÜZENLEToolStripMenuItem
            // 
            dÜZENLEToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { aDAMASMACAOYUNUToolStripMenuItem });
            dÜZENLEToolStripMenuItem.Name = "dÜZENLEToolStripMenuItem";
            dÜZENLEToolStripMenuItem.Size = new Size(87, 24);
            dÜZENLEToolStripMenuItem.Text = "DÜZENLE";
            // 
            // aDAMASMACAOYUNUToolStripMenuItem
            // 
            aDAMASMACAOYUNUToolStripMenuItem.Name = "aDAMASMACAOYUNUToolStripMenuItem";
            aDAMASMACAOYUNUToolStripMenuItem.Size = new Size(258, 26);
            aDAMASMACAOYUNUToolStripMenuItem.Text = "ADAM  ASMACA OYUNU";
            aDAMASMACAOYUNUToolStripMenuItem.Click += aDAMASMACAOYUNUToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(674, 28);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 83);
            label2.Name = "label2";
            label2.Size = new Size(132, 20);
            label2.TabIndex = 2;
            label2.Text = "EŞLEŞEN HARFLER";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 153);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 3;
            label3.Text = "GİRİLEN HARF";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 364);
            label4.Name = "label4";
            label4.Size = new Size(65, 20);
            label4.TabIndex = 4;
            label4.Text = "TAHMİN";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(48, 274);
            label5.Name = "label5";
            label5.Size = new Size(44, 20);
            label5.TabIndex = 5;
            label5.Text = "SÜRE";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(533, 28);
            label6.Name = "label6";
            label6.Size = new Size(84, 20);
            label6.TabIndex = 6;
            label6.Text = "CAN SAYISI";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(181, 181);
            label7.Name = "label7";
            label7.Size = new Size(0, 20);
            label7.TabIndex = 7;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(129, 364);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(235, 27);
            textBox1.TabIndex = 8;
            // 
            // progressBar1
            // 
            progressBar1.BackColor = SystemColors.ButtonHighlight;
            progressBar1.Location = new Point(129, 274);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(309, 37);
            progressBar1.TabIndex = 9;
            // 
            // button1
            // 
            button1.Location = new Point(523, 409);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 10;
            button1.Text = "bul";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ımageList1
            // 
            ımageList1.ColorDepth = ColorDepth.Depth32Bit;
            ımageList1.ImageStream = (ImageListStreamer)resources.GetObject("ımageList1.ImageStream");
            ımageList1.TransparentColor = Color.Transparent;
            ımageList1.Images.SetKeyName(0, "Asian_forest_scorpion_in_Khao_Yai_National_Park.JPG");
            ımageList1.Images.SetKeyName(1, "aslan.png");
            ımageList1.Images.SetKeyName(2, "akvaryum-balik-turleri-a00e.jpg");
            ımageList1.Images.SetKeyName(3, "böcek.png");
            ımageList1.Images.SetKeyName(4, "domuz.png");
            ımageList1.Images.SetKeyName(5, "indir.jpeg");
            ımageList1.Images.SetKeyName(6, "N'Tami,_Western_Gorilla.jpg");
            ımageList1.Images.SetKeyName(7, "indir (1).jpeg");
            ımageList1.Images.SetKeyName(8, "karga.png");
            ımageList1.Images.SetKeyName(9, "koyun.png");
            ımageList1.Images.SetKeyName(10, "köpek.png");
            ımageList1.Images.SetKeyName(11, "indir (2).jpeg");
            ımageList1.Images.SetKeyName(12, "sığır.png");
            ımageList1.Images.SetKeyName(13, "sinek.png");
            ımageList1.Images.SetKeyName(14, "tavuk.png");
            ımageList1.Images.SetKeyName(15, "tilki.png");
            ımageList1.Images.SetKeyName(16, "yılan.png");
            ımageList1.Images.SetKeyName(17, "iStock-520296577-770x375.jpg");
            ımageList1.Images.SetKeyName(18, "zebra.png");
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(533, 107);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(261, 212);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // eş_lab
            // 
            eş_lab.AutoSize = true;
            eş_lab.Location = new Point(207, 97);
            eş_lab.Name = "eş_lab";
            eş_lab.Size = new Size(0, 20);
            eş_lab.TabIndex = 12;
            // 
            // timer1
            // 
            timer1.Interval = 400;
            timer1.Tick += timer1_Tick;
            // 
            // button2
            // 
            button2.Location = new Point(295, 154);
            button2.Name = "button2";
            button2.Size = new Size(59, 29);
            button2.TabIndex = 14;
            button2.Text = "BUL";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // maskedTextBox6
            // 
            maskedTextBox6.Location = new Point(151, 154);
            maskedTextBox6.Mask = "A";
            maskedTextBox6.Name = "maskedTextBox6";
            maskedTextBox6.Size = new Size(24, 27);
            maskedTextBox6.TabIndex = 20;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(181, 85);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(43, 27);
            textBox2.TabIndex = 21;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(230, 85);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(36, 27);
            textBox3.TabIndex = 22;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(272, 85);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(36, 27);
            textBox4.TabIndex = 23;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(313, 85);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(41, 27);
            textBox5.TabIndex = 24;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(360, 85);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(37, 27);
            textBox6.TabIndex = 25;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.InactiveCaption;
            ClientSize = new Size(810, 488);
            Controls.Add(textBox6);
            Controls.Add(textBox5);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(maskedTextBox6);
            Controls.Add(button2);
            Controls.Add(eş_lab);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem dOSYAToolStripMenuItem;
        private ToolStripMenuItem çIKIŞToolStripMenuItem;
        private ToolStripMenuItem dÜZENLEToolStripMenuItem;
        private ToolStripMenuItem aDAMASMACAOYUNUToolStripMenuItem;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Button button1;
        private ImageList ımageList1;
        private PictureBox pictureBox1;
        private Label eş_lab;
        private System.Windows.Forms.Timer timer1;
        private Button button2;
        private MaskedTextBox maskedTextBox6;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private TextBox textBox5;
        private TextBox textBox6;
    }
}
