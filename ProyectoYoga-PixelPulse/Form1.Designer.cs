namespace ProyectoYoga_PixelPulse
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
            textBox1 = new TextBox();
            label1 = new Label();
            button1 = new Button();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(248, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Sitka Banner", 16.1999989F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 57);
            label1.Name = "label1";
            label1.Size = new Size(237, 39);
            label1.TabIndex = 1;
            label1.Text = "Diccionario de asanas";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(521, 95);
            button1.Name = "button1";
            button1.Size = new Size(53, 52);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Location = new Point(65, 201);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(285, 170);
            textBox2.TabIndex = 3;
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.FixedSingle;
            textBox3.Location = new Point(396, 201);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(285, 170);
            textBox3.TabIndex = 4;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.FixedSingle;
            textBox4.Location = new Point(147, 423);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(427, 170);
            textBox4.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 165);
            label2.Name = "label2";
            label2.Size = new Size(84, 33);
            label2.TabIndex = 6;
            label2.Text = "Español";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(396, 165);
            label3.Name = "label3";
            label3.Size = new Size(65, 33);
            label3.TabIndex = 7;
            label3.Text = "Ingles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(147, 387);
            label4.Name = "label4";
            label4.Size = new Size(107, 33);
            label4.TabIndex = 8;
            label4.Text = "Morfemas ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 636);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}