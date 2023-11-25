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
            traduccion = new TextBox();
            morfemas = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(310, 116);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Sitka Banner", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(314, 48);
            label1.Name = "label1";
            label1.Size = new Size(263, 43);
            label1.TabIndex = 1;
            label1.Text = "Diccionario de asanas";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(583, 103);
            button1.Name = "button1";
            button1.Size = new Size(53, 52);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // traduccion
            // 
            traduccion.BorderStyle = BorderStyle.FixedSingle;
            traduccion.Font = new Font("LEMON MILK Bold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            traduccion.Location = new Point(57, 184);
            traduccion.Multiline = true;
            traduccion.Name = "traduccion";
            traduccion.RightToLeft = RightToLeft.Yes;
            traduccion.Size = new Size(350, 215);
            traduccion.TabIndex = 3;
            traduccion.Text = "ESPAÑOL";
            traduccion.TextAlign = HorizontalAlignment.Center;
            // 
            // morfemas
            // 
            morfemas.BorderStyle = BorderStyle.FixedSingle;
            morfemas.Font = new Font("LEMON MILK Bold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            morfemas.Location = new Point(453, 184);
            morfemas.Multiline = true;
            morfemas.Name = "morfemas";
            morfemas.Size = new Size(350, 215);
            morfemas.TabIndex = 4;
            morfemas.Text = "INGLES";
            morfemas.TextAlign = HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.FixedSingle;
            textBox2.Font = new Font("LEMON MILK Bold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            textBox2.Location = new Point(146, 423);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(550, 196);
            textBox2.TabIndex = 5;
            textBox2.Text = "MORFEMAS";
            textBox2.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 641);
            Controls.Add(textBox2);
            Controls.Add(morfemas);
            Controls.Add(traduccion);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "ASANAS";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private Label label1;
        private Button button1;
        private TextBox traduccion;
        private TextBox morfemas;
        private TextBox textBox2;
    }
}