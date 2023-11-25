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
            this.BusquedaTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BusquedaButton = new System.Windows.Forms.Button();
            this.ESTextBox = new System.Windows.Forms.TextBox();
            this.ENTextBox = new System.Windows.Forms.TextBox();
            this.MorfemaTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BusquedaTextBox
            // 
            this.BusquedaTextBox.Location = new System.Drawing.Point(217, 81);
            this.BusquedaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusquedaTextBox.Name = "BusquedaTextBox";
            this.BusquedaTextBox.Size = new System.Drawing.Size(234, 23);
            this.BusquedaTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(236, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(190, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diccionario de asanas";
            // 
            // BusquedaButton
            // 
            this.BusquedaButton.Image = ((System.Drawing.Image)(resources.GetObject("BusquedaButton.Image")));
            this.BusquedaButton.Location = new System.Drawing.Point(456, 71);
            this.BusquedaButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BusquedaButton.Name = "BusquedaButton";
            this.BusquedaButton.Size = new System.Drawing.Size(46, 39);
            this.BusquedaButton.TabIndex = 2;
            this.BusquedaButton.UseVisualStyleBackColor = true;
            this.BusquedaButton.Click += new System.EventHandler(this.BusquedaButton_Click);
            // 
            // ESTextBox
            // 
            this.ESTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ESTextBox.Location = new System.Drawing.Point(57, 151);
            this.ESTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ESTextBox.Multiline = true;
            this.ESTextBox.Name = "ESTextBox";
            this.ESTextBox.Size = new System.Drawing.Size(250, 128);
            this.ESTextBox.TabIndex = 3;
            this.ESTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // ENTextBox
            // 
            this.ENTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ENTextBox.Location = new System.Drawing.Point(346, 151);
            this.ENTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ENTextBox.Multiline = true;
            this.ENTextBox.Name = "ENTextBox";
            this.ENTextBox.Size = new System.Drawing.Size(250, 128);
            this.ENTextBox.TabIndex = 4;
            // 
            // MorfemaTextBox
            // 
            this.MorfemaTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MorfemaTextBox.Location = new System.Drawing.Point(129, 317);
            this.MorfemaTextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MorfemaTextBox.Multiline = true;
            this.MorfemaTextBox.Name = "MorfemaTextBox";
            this.MorfemaTextBox.Size = new System.Drawing.Size(374, 128);
            this.MorfemaTextBox.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(57, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "Español";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(346, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 28);
            this.label3.TabIndex = 7;
            this.label3.Text = "Ingles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(129, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 28);
            this.label4.TabIndex = 8;
            this.label4.Text = "Morfemas ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 477);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MorfemaTextBox);
            this.Controls.Add(this.ENTextBox);
            this.Controls.Add(this.ESTextBox);
            this.Controls.Add(this.BusquedaButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BusquedaTextBox);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

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