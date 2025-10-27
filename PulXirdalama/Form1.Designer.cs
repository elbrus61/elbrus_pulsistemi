namespace PulXirdalama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            maskedTextBox1 = new MaskedTextBox();
            button1 = new Button();
            panel1 = new Panel();
            pictureBox3 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox6 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox8 = new PictureBox();
            panel2 = new Panel();
            listBox8 = new ListBox();
            listBox7 = new ListBox();
            listBox6 = new ListBox();
            listBox5 = new ListBox();
            listBox4 = new ListBox();
            listBox3 = new ListBox();
            listBox2 = new ListBox();
            listBox1 = new ListBox();
            label1 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(11, 193);
            maskedTextBox1.Mask = "00000";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(303, 27);
            maskedTextBox1.TabIndex = 0;
            maskedTextBox1.ValidatingType = typeof(int);
            maskedTextBox1.MaskInputRejected += maskedTextBox1_MaskInputRejected;
            // 
            // button1
            // 
            button1.Location = new Point(24, 241);
            button1.Name = "button1";
            button1.Size = new Size(278, 55);
            button1.TabIndex = 1;
            button1.Text = "Xirdala";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.RosyBrown;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(maskedTextBox1);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(1, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(337, 457);
            panel1.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources._10luq;
            pictureBox3.Location = new Point(13, 241);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(169, 85);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 8;
            pictureBox3.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources._1_manat___2020___obv;
            pictureBox1.InitialImage = (Image)resources.GetObject("pictureBox1.InitialImage");
            pictureBox1.Location = new Point(13, 13);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(152, 87);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox7_Click;
            // 
            // pictureBox7
            // 
            pictureBox7.Image = Properties.Resources._200_Azerbaijani_manat_in_2018_Obverse;
            pictureBox7.Location = new Point(291, 241);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(164, 74);
            pictureBox7.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox7.TabIndex = 10;
            pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            pictureBox6.Image = Properties.Resources._100_manat_obv;
            pictureBox6.Location = new Point(290, 121);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(164, 87);
            pictureBox6.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox6.TabIndex = 11;
            pictureBox6.TabStop = false;
            pictureBox6.Click += pictureBox2_Click;
            // 
            // pictureBox5
            // 
            pictureBox5.Image = Properties.Resources._50_manat___2020___obv;
            pictureBox5.Location = new Point(292, 13);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(163, 87);
            pictureBox5.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox5.TabIndex = 12;
            pictureBox5.TabStop = false;
            pictureBox5.Click += pictureBox3_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources._5manat09a;
            pictureBox2.Location = new Point(13, 133);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(169, 87);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 13;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox4_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.Azerbaijan_20_manat_2020_obverse;
            pictureBox4.Location = new Point(13, 358);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(169, 88);
            pictureBox4.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox4.TabIndex = 14;
            pictureBox4.TabStop = false;
            // 
            // pictureBox8
            // 
            pictureBox8.Image = Properties.Resources.Azerbaijan_500_manat_Karabakh_obverse;
            pictureBox8.Location = new Point(290, 358);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(165, 88);
            pictureBox8.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox8.TabIndex = 15;
            pictureBox8.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.DarkTurquoise;
            panel2.Controls.Add(listBox8);
            panel2.Controls.Add(listBox7);
            panel2.Controls.Add(listBox6);
            panel2.Controls.Add(listBox5);
            panel2.Controls.Add(listBox4);
            panel2.Controls.Add(listBox3);
            panel2.Controls.Add(listBox2);
            panel2.Controls.Add(listBox1);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(pictureBox4);
            panel2.Controls.Add(pictureBox3);
            panel2.Controls.Add(pictureBox8);
            panel2.Controls.Add(pictureBox5);
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox6);
            panel2.Controls.Add(pictureBox7);
            panel2.Location = new Point(366, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(562, 457);
            panel2.TabIndex = 3;
            // 
            // listBox8
            // 
            listBox8.FormattingEnabled = true;
            listBox8.Location = new Point(461, 387);
            listBox8.Name = "listBox8";
            listBox8.Size = new Size(88, 44);
            listBox8.TabIndex = 23;
            // 
            // listBox7
            // 
            listBox7.FormattingEnabled = true;
            listBox7.Location = new Point(461, 252);
            listBox7.Name = "listBox7";
            listBox7.Size = new Size(88, 44);
            listBox7.TabIndex = 22;
            // 
            // listBox6
            // 
            listBox6.FormattingEnabled = true;
            listBox6.Location = new Point(461, 150);
            listBox6.Name = "listBox6";
            listBox6.Size = new Size(88, 44);
            listBox6.TabIndex = 21;
            // 
            // listBox5
            // 
            listBox5.FormattingEnabled = true;
            listBox5.Location = new Point(461, 37);
            listBox5.Name = "listBox5";
            listBox5.Size = new Size(88, 44);
            listBox5.TabIndex = 20;
            // 
            // listBox4
            // 
            listBox4.FormattingEnabled = true;
            listBox4.Location = new Point(188, 387);
            listBox4.Name = "listBox4";
            listBox4.Size = new Size(88, 44);
            listBox4.TabIndex = 19;
            // 
            // listBox3
            // 
            listBox3.FormattingEnabled = true;
            listBox3.Location = new Point(188, 271);
            listBox3.Name = "listBox3";
            listBox3.Size = new Size(88, 44);
            listBox3.TabIndex = 18;
            // 
            // listBox2
            // 
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(188, 150);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(88, 44);
            listBox2.TabIndex = 17;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(188, 37);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(88, 44);
            listBox1.TabIndex = 16;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(11, 159);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 9;
            label1.Text = "Meblegi daxil edin";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(927, 457);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "Form1";
            Text = "Money";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            panel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private MaskedTextBox maskedTextBox1;
        private Button button1;
        private Panel panel1;
        private PictureBox pictureBox3;
        private PictureBox pictureBox1;
        private PictureBox pictureBox7;
        private PictureBox pictureBox6;
        private PictureBox pictureBox5;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private PictureBox pictureBox8;
        private Panel panel2;
        private ListBox listBox8;
        private ListBox listBox7;
        private ListBox listBox6;
        private ListBox listBox5;
        private ListBox listBox4;
        private ListBox listBox3;
        private ListBox listBox2;
        private ListBox listBox1;
        private Label label1;
    }
}
