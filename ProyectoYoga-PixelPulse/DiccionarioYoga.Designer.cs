namespace ProyectoYoga_PixelPulse
{
    partial class DiccionarioYoga
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DiccionarioYoga));
            BusquedaTextBox = new TextBox();
            label1 = new Label();
            BusquedaButton = new Button();
            ESTextBox = new TextBox();
            ENTextBox = new TextBox();
            MorfemaTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // BusquedaTextBox
            // 
            BusquedaTextBox.Location = new Point(248, 108);
            BusquedaTextBox.Name = "BusquedaTextBox";
            BusquedaTextBox.Size = new Size(267, 27);
            BusquedaTextBox.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Font = new Font("Sitka Banner", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(270, 57);
            label1.Name = "label1";
            label1.Size = new Size(247, 40);
            label1.TabIndex = 1;
            label1.Text = "Diccionario de asanas";
            // 
            // BusquedaButton
            // 
            BusquedaButton.Image = (Image)resources.GetObject("BusquedaButton.Image");
            BusquedaButton.Location = new Point(521, 95);
            BusquedaButton.Name = "BusquedaButton";
            BusquedaButton.Size = new Size(53, 52);
            BusquedaButton.TabIndex = 2;
            BusquedaButton.UseVisualStyleBackColor = true;
            BusquedaButton.Click += BusquedaButton_Click;
            // 
            // ESTextBox
            // 
            ESTextBox.BorderStyle = BorderStyle.FixedSingle;
            ESTextBox.Location = new Point(65, 201);
            ESTextBox.Multiline = true;
            ESTextBox.Name = "ESTextBox";
            ESTextBox.Size = new Size(285, 170);
            ESTextBox.TabIndex = 3;
            // 
            // ENTextBox
            // 
            ENTextBox.BorderStyle = BorderStyle.FixedSingle;
            ENTextBox.Location = new Point(395, 201);
            ENTextBox.Multiline = true;
            ENTextBox.Name = "ENTextBox";
            ENTextBox.Size = new Size(285, 170);
            ENTextBox.TabIndex = 4;
            ENTextBox.TextChanged += ENTextBox_TextChanged;
            // 
            // MorfemaTextBox
            // 
            MorfemaTextBox.BorderStyle = BorderStyle.FixedSingle;
            MorfemaTextBox.Location = new Point(147, 423);
            MorfemaTextBox.Multiline = true;
            MorfemaTextBox.Name = "MorfemaTextBox";
            MorfemaTextBox.Size = new Size(427, 170);
            MorfemaTextBox.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Font = new Font("Sitka Banner", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(65, 165);
            label2.Name = "label2";
            label2.Size = new Size(84, 33);
            label2.TabIndex = 6;
            label2.Text = "Español";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Font = new Font("Sitka Banner", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(395, 165);
            label3.Name = "label3";
            label3.Size = new Size(65, 33);
            label3.TabIndex = 7;
            label3.Text = "Ingles";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Font = new Font("Sitka Banner", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(147, 387);
            label4.Name = "label4";
            label4.Size = new Size(107, 33);
            label4.TabIndex = 8;
            label4.Text = "Morfemas ";
            // 
            // DiccionarioYoga
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(729, 636);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(MorfemaTextBox);
            Controls.Add(ENTextBox);
            Controls.Add(ESTextBox);
            Controls.Add(BusquedaButton);
            Controls.Add(label1);
            Controls.Add(BusquedaTextBox);
            Name = "DiccionarioYoga";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox BusquedaTextBox;
        private Label label1;
        private Button BusquedaButton;
        private TextBox ESTextBox;
        private TextBox ENTextBox;
        private TextBox MorfemaTextBox;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}