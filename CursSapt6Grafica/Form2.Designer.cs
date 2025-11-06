namespace CursSapt6Grafica
{
    partial class Form2
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            spongebobAfrican = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button1 = new Button();
            progressBar1 = new ProgressBar();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(636, 445);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            pictureBox2.Location = new Point(651, 1);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(693, 444);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // spongebobAfrican
            // 
            spongebobAfrican.Location = new Point(7, 465);
            spongebobAfrican.Name = "spongebobAfrican";
            spongebobAfrican.Size = new Size(94, 29);
            spongebobAfrican.TabIndex = 2;
            spongebobAfrican.Text = "spongebobAfrican";
            spongebobAfrican.UseVisualStyleBackColor = true;
            spongebobAfrican.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(9, 504);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 3;
            button2.Text = "fuzzify";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(13, 545);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 4;
            button3.Text = "contur";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(22, 585);
            button4.Name = "button4";
            button4.Size = new Size(94, 29);
            button4.TabIndex = 5;
            button4.Text = "update";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button1
            // 
            button1.Location = new Point(19, 632);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "median";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(653, 453);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(691, 29);
            progressBar1.TabIndex = 7;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1360, 723);
            Controls.Add(progressBar1);
            Controls.Add(button1);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(spongebobAfrican);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button spongebobAfrican;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button1;
        private ProgressBar progressBar1;
    }
}