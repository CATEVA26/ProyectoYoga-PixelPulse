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
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(266, 106);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(267, 27);
            textBox1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Sitka Banner", 13.7999992F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(288, 55);
            label1.Name = "label1";
            label1.Size = new Size(202, 33);
            label1.TabIndex = 1;
            label1.Text = "Diccionario de asanas";
            label1.Click += label1_Click;
            // 
            // button1
            // 
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(539, 93);
            button1.Name = "button1";
            button1.Size = new Size(53, 52);
            button1.TabIndex = 2;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // traduccion
            // 
            traduccion.BorderStyle = BorderStyle.FixedSingle;
            traduccion.Location = new Point(57, 184);
            traduccion.Multiline = true;
            traduccion.Name = "traduccion";
            traduccion.Size = new Size(325, 215);
            traduccion.TabIndex = 3;
            // 
            // morfemas
            // 
            morfemas.BorderStyle = BorderStyle.FixedSingle;
            morfemas.Location = new Point(414, 184);
            morfemas.Multiline = true;
            morfemas.Name = "morfemas";
            morfemas.Size = new Size(325, 215);
            morfemas.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(morfemas);
            Controls.Add(traduccion);
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
        private TextBox traduccion;
        private TextBox morfemas;
    }
}