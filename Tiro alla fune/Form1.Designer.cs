namespace Tiro_alla_fune
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
            Corda_Ondulata = new PictureBox();
            Corda_Dura = new PictureBox();
            Start = new Button();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            Reset = new Button();
            timer1 = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)Corda_Ondulata).BeginInit();
            ((System.ComponentModel.ISupportInitialize)Corda_Dura).BeginInit();
            SuspendLayout();
            // 
            // Corda_Ondulata
            // 
            Corda_Ondulata.Image = (Image)resources.GetObject("Corda_Ondulata.Image");
            Corda_Ondulata.Location = new Point(211, 178);
            Corda_Ondulata.Name = "Corda_Ondulata";
            Corda_Ondulata.Size = new Size(350, 150);
            Corda_Ondulata.SizeMode = PictureBoxSizeMode.Zoom;
            Corda_Ondulata.TabIndex = 0;
            Corda_Ondulata.TabStop = false;
            Corda_Ondulata.Click += pictureBox1_Click;
            // 
            // Corda_Dura
            // 
            Corda_Dura.Image = (Image)resources.GetObject("Corda_Dura.Image");
            Corda_Dura.Location = new Point(158, 178);
            Corda_Dura.Name = "Corda_Dura";
            Corda_Dura.Size = new Size(450, 130);
            Corda_Dura.SizeMode = PictureBoxSizeMode.Zoom;
            Corda_Dura.TabIndex = 1;
            Corda_Dura.TabStop = false;
            Corda_Dura.Visible = false;
            Corda_Dura.LocationChanged += Corda_Dura_LocationChanged;
            // 
            // Start
            // 
            Start.Location = new Point(274, 334);
            Start.Name = "Start";
            Start.Size = new Size(100, 50);
            Start.TabIndex = 2;
            Start.Text = "START";
            Start.UseVisualStyleBackColor = true;
            Start.Click += Start_Click;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(75, 29);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(48, 19);
            radioButton1.TabIndex = 3;
            radioButton1.TabStop = true;
            radioButton1.Text = "Easy";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(75, 54);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(70, 19);
            radioButton2.TabIndex = 4;
            radioButton2.TabStop = true;
            radioButton2.Text = "Medium";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(75, 79);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(51, 19);
            radioButton3.TabIndex = 5;
            radioButton3.TabStop = true;
            radioButton3.Text = "Hard";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(75, 104);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(82, 19);
            radioButton4.TabIndex = 6;
            radioButton4.TabStop = true;
            radioButton4.Text = "Impossible";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // Reset
            // 
            Reset.Location = new Point(408, 334);
            Reset.Name = "Reset";
            Reset.Size = new Size(100, 50);
            Reset.TabIndex = 7;
            Reset.Text = "RESET";
            Reset.UseVisualStyleBackColor = true;
            Reset.Click += button1_Click_1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Reset);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(Start);
            Controls.Add(Corda_Dura);
            Controls.Add(Corda_Ondulata);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            Click += Form1_Click;
            ((System.ComponentModel.ISupportInitialize)Corda_Ondulata).EndInit();
            ((System.ComponentModel.ISupportInitialize)Corda_Dura).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Corda_Ondulata;
        private PictureBox Corda_Dura;
        private Button Start;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
        private Button Reset;
        private System.Windows.Forms.Timer timer1;
    }
}