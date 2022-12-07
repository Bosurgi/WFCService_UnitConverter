namespace ClientConverter
{
    partial class ClientConverter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientConverter));
            this.ConvertButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.MaskedTextBox();
            this.outputTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ClearButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ImperialValuesLabel = new System.Windows.Forms.Label();
            this.MetricValuesLabel = new System.Windows.Forms.Label();
            this.measureSelector = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // ConvertButton
            // 
            this.ConvertButton.Location = new System.Drawing.Point(33, 163);
            this.ConvertButton.Name = "ConvertButton";
            this.ConvertButton.Size = new System.Drawing.Size(75, 23);
            this.ConvertButton.TabIndex = 0;
            this.ConvertButton.Text = "Convert";
            this.ConvertButton.UseVisualStyleBackColor = true;
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(12, 95);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(75, 20);
            this.inputTextBox.TabIndex = 4;
            // 
            // outputTextBox
            // 
            this.outputTextBox.Location = new System.Drawing.Point(199, 93);
            this.outputTextBox.Name = "outputTextBox";
            this.outputTextBox.Size = new System.Drawing.Size(104, 20);
            this.outputTextBox.TabIndex = 5;
            // 
            // ClearButton
            // 
            this.ClearButton.Location = new System.Drawing.Point(213, 163);
            this.ClearButton.Name = "ClearButton";
            this.ClearButton.Size = new System.Drawing.Size(75, 23);
            this.ClearButton.TabIndex = 8;
            this.ClearButton.Text = "Clear";
            this.ClearButton.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Imperial to Metrics converter";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(99, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "By Andrea La Fauci De Leo";
            // 
            // ImperialValuesLabel
            // 
            this.ImperialValuesLabel.AutoSize = true;
            this.ImperialValuesLabel.Location = new System.Drawing.Point(30, 62);
            this.ImperialValuesLabel.Name = "ImperialValuesLabel";
            this.ImperialValuesLabel.Size = new System.Drawing.Size(78, 13);
            this.ImperialValuesLabel.TabIndex = 11;
            this.ImperialValuesLabel.Text = "Imperial Values";
            // 
            // MetricValuesLabel
            // 
            this.MetricValuesLabel.AutoSize = true;
            this.MetricValuesLabel.Location = new System.Drawing.Point(217, 62);
            this.MetricValuesLabel.Name = "MetricValuesLabel";
            this.MetricValuesLabel.Size = new System.Drawing.Size(71, 13);
            this.MetricValuesLabel.TabIndex = 12;
            this.MetricValuesLabel.Text = "Metric Values";
            // 
            // measureSelector
            // 
            this.measureSelector.FormattingEnabled = true;
            this.measureSelector.Items.AddRange(new object[] {
            "in.",
            "ft.",
            "mi.",
            "lb."});
            this.measureSelector.Location = new System.Drawing.Point(93, 95);
            this.measureSelector.Name = "measureSelector";
            this.measureSelector.Size = new System.Drawing.Size(34, 21);
            this.measureSelector.TabIndex = 13;
            // 
            // ClientConverter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 264);
            this.Controls.Add(this.measureSelector);
            this.Controls.Add(this.MetricValuesLabel);
            this.Controls.Add(this.ImperialValuesLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ClearButton);
            this.Controls.Add(this.outputTextBox);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.ConvertButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ClientConverter";
            this.Text = "Imperial to Metrics converter";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ConvertButton;
        private System.Windows.Forms.MaskedTextBox inputTextBox;
        private System.Windows.Forms.MaskedTextBox outputTextBox;
        private System.Windows.Forms.Button ClearButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ImperialValuesLabel;
        private System.Windows.Forms.Label MetricValuesLabel;
        private System.Windows.Forms.ComboBox measureSelector;
    }
}

