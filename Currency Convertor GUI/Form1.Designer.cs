namespace Currency_Convertor_GUI {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.startCurrencyBox = new System.Windows.Forms.ComboBox();
            this.endCurrencyBox = new System.Windows.Forms.ComboBox();
            this.startAmountLabel = new System.Windows.Forms.Label();
            this.startCurrencyLabel = new System.Windows.Forms.Label();
            this.endCurrencyLabel = new System.Windows.Forms.Label();
            this.endAmountLabel = new System.Windows.Forms.Label();
            this.equalsButton = new System.Windows.Forms.Button();
            this.conversionGroupBox = new System.Windows.Forms.GroupBox();
            this.noRadioButton = new System.Windows.Forms.RadioButton();
            this.yesRadioButton = new System.Windows.Forms.RadioButton();
            this.startCodeLabel = new System.Windows.Forms.Label();
            this.endCodeLabel = new System.Windows.Forms.Label();
            this.startAmountBox = new System.Windows.Forms.TextBox();
            this.endAmountBox = new System.Windows.Forms.TextBox();
            this.conversionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // startCurrencyBox
            // 
            this.startCurrencyBox.FormattingEnabled = true;
            this.startCurrencyBox.Location = new System.Drawing.Point(44, 57);
            this.startCurrencyBox.Name = "startCurrencyBox";
            this.startCurrencyBox.Size = new System.Drawing.Size(153, 21);
            this.startCurrencyBox.TabIndex = 0;
            this.startCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.startCurrencyBox_SelectedIndexChanged);
            // 
            // endCurrencyBox
            // 
            this.endCurrencyBox.Enabled = false;
            this.endCurrencyBox.FormattingEnabled = true;
            this.endCurrencyBox.Location = new System.Drawing.Point(282, 57);
            this.endCurrencyBox.Name = "endCurrencyBox";
            this.endCurrencyBox.Size = new System.Drawing.Size(153, 21);
            this.endCurrencyBox.TabIndex = 1;
            this.endCurrencyBox.SelectedIndexChanged += new System.EventHandler(this.endCurrencyBox_SelectedIndexChanged);
            // 
            // startAmountLabel
            // 
            this.startAmountLabel.AutoSize = true;
            this.startAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startAmountLabel.Location = new System.Drawing.Point(45, 156);
            this.startAmountLabel.Name = "startAmountLabel";
            this.startAmountLabel.Size = new System.Drawing.Size(111, 17);
            this.startAmountLabel.TabIndex = 4;
            this.startAmountLabel.Text = "Amount I have";
            // 
            // startCurrencyLabel
            // 
            this.startCurrencyLabel.AutoSize = true;
            this.startCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCurrencyLabel.Location = new System.Drawing.Point(42, 38);
            this.startCurrencyLabel.Name = "startCurrencyLabel";
            this.startCurrencyLabel.Size = new System.Drawing.Size(122, 17);
            this.startCurrencyLabel.TabIndex = 5;
            this.startCurrencyLabel.Text = "Currency I have";
            // 
            // endCurrencyLabel
            // 
            this.endCurrencyLabel.AutoSize = true;
            this.endCurrencyLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endCurrencyLabel.Location = new System.Drawing.Point(281, 38);
            this.endCurrencyLabel.Name = "endCurrencyLabel";
            this.endCurrencyLabel.Size = new System.Drawing.Size(120, 17);
            this.endCurrencyLabel.TabIndex = 6;
            this.endCurrencyLabel.Text = "Currency I want";
            // 
            // endAmountLabel
            // 
            this.endAmountLabel.AutoSize = true;
            this.endAmountLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endAmountLabel.Location = new System.Drawing.Point(316, 156);
            this.endAmountLabel.Name = "endAmountLabel";
            this.endAmountLabel.Size = new System.Drawing.Size(109, 17);
            this.endAmountLabel.TabIndex = 7;
            this.endAmountLabel.Text = "Amount I want";
            // 
            // equalsButton
            // 
            this.equalsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalsButton.Location = new System.Drawing.Point(182, 156);
            this.equalsButton.Name = "equalsButton";
            this.equalsButton.Size = new System.Drawing.Size(75, 61);
            this.equalsButton.TabIndex = 8;
            this.equalsButton.Text = "Equals";
            this.equalsButton.UseVisualStyleBackColor = true;
            this.equalsButton.Click += new System.EventHandler(this.equalsButton_Click);
            // 
            // conversionGroupBox
            // 
            this.conversionGroupBox.Controls.Add(this.noRadioButton);
            this.conversionGroupBox.Controls.Add(this.yesRadioButton);
            this.conversionGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conversionGroupBox.Location = new System.Drawing.Point(184, 235);
            this.conversionGroupBox.Name = "conversionGroupBox";
            this.conversionGroupBox.Size = new System.Drawing.Size(200, 100);
            this.conversionGroupBox.TabIndex = 9;
            this.conversionGroupBox.TabStop = false;
            this.conversionGroupBox.Text = "Another conversion?";
            this.conversionGroupBox.Visible = false;
            // 
            // noRadioButton
            // 
            this.noRadioButton.AutoSize = true;
            this.noRadioButton.Location = new System.Drawing.Point(21, 65);
            this.noRadioButton.Name = "noRadioButton";
            this.noRadioButton.Size = new System.Drawing.Size(49, 24);
            this.noRadioButton.TabIndex = 1;
            this.noRadioButton.TabStop = true;
            this.noRadioButton.Text = "No";
            this.noRadioButton.UseVisualStyleBackColor = true;
            this.noRadioButton.CheckedChanged += new System.EventHandler(this.noRadioButton_CheckedChanged);
            // 
            // yesRadioButton
            // 
            this.yesRadioButton.AutoSize = true;
            this.yesRadioButton.Location = new System.Drawing.Point(21, 34);
            this.yesRadioButton.Name = "yesRadioButton";
            this.yesRadioButton.Size = new System.Drawing.Size(58, 24);
            this.yesRadioButton.TabIndex = 0;
            this.yesRadioButton.TabStop = true;
            this.yesRadioButton.Text = "Yes";
            this.yesRadioButton.UseVisualStyleBackColor = true;
            this.yesRadioButton.CheckedChanged += new System.EventHandler(this.yesRadioButton_CheckedChanged);
            // 
            // startCodeLabel
            // 
            this.startCodeLabel.AutoSize = true;
            this.startCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startCodeLabel.Location = new System.Drawing.Point(9, 178);
            this.startCodeLabel.Name = "startCodeLabel";
            this.startCodeLabel.Size = new System.Drawing.Size(0, 15);
            this.startCodeLabel.TabIndex = 10;
            this.startCodeLabel.Visible = false;
            // 
            // endCodeLabel
            // 
            this.endCodeLabel.AutoSize = true;
            this.endCodeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endCodeLabel.Location = new System.Drawing.Point(279, 178);
            this.endCodeLabel.Name = "endCodeLabel";
            this.endCodeLabel.Size = new System.Drawing.Size(0, 15);
            this.endCodeLabel.TabIndex = 11;
            this.endCodeLabel.Visible = false;
            // 
            // startAmountBox
            // 
            this.startAmountBox.Enabled = false;
            this.startAmountBox.Location = new System.Drawing.Point(45, 178);
            this.startAmountBox.Name = "startAmountBox";
            this.startAmountBox.Size = new System.Drawing.Size(120, 20);
            this.startAmountBox.TabIndex = 12;
            // 
            // endAmountBox
            // 
            this.endAmountBox.Enabled = false;
            this.endAmountBox.Location = new System.Drawing.Point(317, 178);
            this.endAmountBox.Name = "endAmountBox";
            this.endAmountBox.Size = new System.Drawing.Size(117, 20);
            this.endAmountBox.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(468, 364);
            this.Controls.Add(this.endAmountBox);
            this.Controls.Add(this.startAmountBox);
            this.Controls.Add(this.endCodeLabel);
            this.Controls.Add(this.startCodeLabel);
            this.Controls.Add(this.conversionGroupBox);
            this.Controls.Add(this.equalsButton);
            this.Controls.Add(this.endAmountLabel);
            this.Controls.Add(this.endCurrencyLabel);
            this.Controls.Add(this.startCurrencyLabel);
            this.Controls.Add(this.startAmountLabel);
            this.Controls.Add(this.endCurrencyBox);
            this.Controls.Add(this.startCurrencyBox);
            this.Name = "Form1";
            this.Text = "Currency Converter";
            this.conversionGroupBox.ResumeLayout(false);
            this.conversionGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox startCurrencyBox;
        private System.Windows.Forms.ComboBox endCurrencyBox;
        private System.Windows.Forms.Label startAmountLabel;
        private System.Windows.Forms.Label startCurrencyLabel;
        private System.Windows.Forms.Label endCurrencyLabel;
        private System.Windows.Forms.Label endAmountLabel;
        private System.Windows.Forms.Button equalsButton;
        private System.Windows.Forms.GroupBox conversionGroupBox;
        private System.Windows.Forms.RadioButton noRadioButton;
        private System.Windows.Forms.RadioButton yesRadioButton;
        private System.Windows.Forms.Label startCodeLabel;
        private System.Windows.Forms.Label endCodeLabel;
        private System.Windows.Forms.TextBox startAmountBox;
        private System.Windows.Forms.TextBox endAmountBox;

     
    }
}

