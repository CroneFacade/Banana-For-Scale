namespace BananaProject
{
    partial class Form1
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
            this.textBoxLengthInput = new System.Windows.Forms.TextBox();
            this.comboBoxMeasuringUnit = new System.Windows.Forms.ComboBox();
            this.buttonCalculateBananas = new System.Windows.Forms.Button();
            this.ResultLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // textBoxLengthInput
            // 
            this.textBoxLengthInput.Location = new System.Drawing.Point(10, 12);
            this.textBoxLengthInput.Name = "textBoxLengthInput";
            this.textBoxLengthInput.Size = new System.Drawing.Size(100, 20);
            this.textBoxLengthInput.TabIndex = 0;
            this.textBoxLengthInput.Text = "Length";
            this.textBoxLengthInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // comboBoxMeasuringUnit
            // 
            this.comboBoxMeasuringUnit.FormattingEnabled = true;
            this.comboBoxMeasuringUnit.Items.AddRange(new object[] {
            "Meters",
            "Decimeters",
            "Centimeters",
            "Millimeters"});
            this.comboBoxMeasuringUnit.Location = new System.Drawing.Point(117, 12);
            this.comboBoxMeasuringUnit.Name = "comboBoxMeasuringUnit";
            this.comboBoxMeasuringUnit.Size = new System.Drawing.Size(121, 21);
            this.comboBoxMeasuringUnit.TabIndex = 1;
            this.comboBoxMeasuringUnit.Text = "Measuring Unit";
            // 
            // buttonCalculateBananas
            // 
            this.buttonCalculateBananas.Location = new System.Drawing.Point(244, 11);
            this.buttonCalculateBananas.Name = "buttonCalculateBananas";
            this.buttonCalculateBananas.Size = new System.Drawing.Size(127, 23);
            this.buttonCalculateBananas.TabIndex = 2;
            this.buttonCalculateBananas.Text = "Calculate To Bananas";
            this.buttonCalculateBananas.UseVisualStyleBackColor = true;
            this.buttonCalculateBananas.Click += new System.EventHandler(this.buttonCalculateBananas_Click);
            // 
            // ResultLabel
            // 
            this.ResultLabel.AutoSize = true;
            this.ResultLabel.Location = new System.Drawing.Point(159, 47);
            this.ResultLabel.Name = "ResultLabel";
            this.ResultLabel.Size = new System.Drawing.Size(37, 13);
            this.ResultLabel.TabIndex = 3;
            this.ResultLabel.Text = "Result";
            this.ResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(71, 63);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(214, 30);
            this.listBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 120);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.ResultLabel);
            this.Controls.Add(this.buttonCalculateBananas);
            this.Controls.Add(this.comboBoxMeasuringUnit);
            this.Controls.Add(this.textBoxLengthInput);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxLengthInput;
        private System.Windows.Forms.ComboBox comboBoxMeasuringUnit;
        private System.Windows.Forms.Button buttonCalculateBananas;
        private System.Windows.Forms.Label ResultLabel;
        private System.Windows.Forms.ListBox listBox1;
    }
}

