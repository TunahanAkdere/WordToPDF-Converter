namespace WordToPDFConverter
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
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            convertbtn = new Button();
            infobtn = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(374, 27);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(188, 194);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(374, 224);
            label1.Name = "label1";
            label1.Size = new Size(188, 31);
            label1.TabIndex = 1;
            label1.Text = "Word'den PDF'e";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(405, 255);
            label2.Name = "label2";
            label2.Size = new Size(130, 28);
            label2.TabIndex = 2;
            label2.Text = "Dönüştürücü";
            // 
            // convertbtn
            // 
            convertbtn.BackColor = Color.Lavender;
            convertbtn.FlatStyle = FlatStyle.Flat;
            convertbtn.Location = new Point(374, 315);
            convertbtn.Name = "convertbtn";
            convertbtn.Size = new Size(188, 49);
            convertbtn.TabIndex = 3;
            convertbtn.Text = "Seç ve Dönüştür";
            convertbtn.UseVisualStyleBackColor = false;
            convertbtn.Click += convertbtn_Click;
            // 
            // infobtn
            // 
            infobtn.BackColor = Color.Lavender;
            infobtn.FlatStyle = FlatStyle.Flat;
            infobtn.Location = new Point(374, 370);
            infobtn.Name = "infobtn";
            infobtn.Size = new Size(188, 49);
            infobtn.TabIndex = 4;
            infobtn.Text = "Hakkında";
            infobtn.UseVisualStyleBackColor = false;
            infobtn.Click += infobtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkSlateBlue;
            ClientSize = new Size(946, 481);
            Controls.Add(infobtn);
            Controls.Add(convertbtn);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Button convertbtn;
        private Button infobtn;
    }
}