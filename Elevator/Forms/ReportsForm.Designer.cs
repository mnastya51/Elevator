namespace Elevator.Forms
{
    partial class ReportsForm
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
            this.toTextBox = new System.Windows.Forms.TextBox();
            this.fromTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.subdivisionComboBox = new System.Windows.Forms.ComboBox();
            this.contractorComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.volumeRawRadioButton = new System.Windows.Forms.RadioButton();
            this.processingRadioButton = new System.Windows.Forms.RadioButton();
            this.formReportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toTextBox
            // 
            this.toTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.toTextBox.Location = new System.Drawing.Point(271, 13);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 26);
            this.toTextBox.TabIndex = 10;
            this.toTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.toTextBox_KeyPress);
            // 
            // fromTextBox
            // 
            this.fromTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fromTextBox.Location = new System.Drawing.Point(132, 13);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 26);
            this.fromTextBox.TabIndex = 9;
            this.fromTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.fromTextBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(238, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(18, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Год урожая с";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.volumeRawRadioButton);
            this.groupBox1.Controls.Add(this.processingRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 216);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите отчет";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.subdivisionComboBox);
            this.groupBox2.Controls.Add(this.contractorComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(17, 96);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 104);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите контрагента";
            // 
            // subdivisionComboBox
            // 
            this.subdivisionComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.subdivisionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subdivisionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.subdivisionComboBox.FormattingEnabled = true;
            this.subdivisionComboBox.Location = new System.Drawing.Point(155, 67);
            this.subdivisionComboBox.Name = "subdivisionComboBox";
            this.subdivisionComboBox.Size = new System.Drawing.Size(167, 28);
            this.subdivisionComboBox.TabIndex = 28;
            // 
            // contractorComboBox
            // 
            this.contractorComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.contractorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractorComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorComboBox.FormattingEnabled = true;
            this.contractorComboBox.Location = new System.Drawing.Point(155, 27);
            this.contractorComboBox.Name = "contractorComboBox";
            this.contractorComboBox.Size = new System.Drawing.Size(167, 28);
            this.contractorComboBox.TabIndex = 15;
            this.contractorComboBox.SelectedIndexChanged += new System.EventHandler(this.contractorComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(15, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "Подразделение:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Контрагент:";
            // 
            // volumeRawRadioButton
            // 
            this.volumeRawRadioButton.AutoSize = true;
            this.volumeRawRadioButton.Checked = true;
            this.volumeRawRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeRawRadioButton.Location = new System.Drawing.Point(17, 30);
            this.volumeRawRadioButton.Name = "volumeRawRadioButton";
            this.volumeRawRadioButton.Size = new System.Drawing.Size(124, 24);
            this.volumeRawRadioButton.TabIndex = 3;
            this.volumeRawRadioButton.TabStop = true;
            this.volumeRawRadioButton.Text = "объем зерна";
            this.volumeRawRadioButton.UseVisualStyleBackColor = true;
            // 
            // processingRadioButton
            // 
            this.processingRadioButton.AutoSize = true;
            this.processingRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.processingRadioButton.Location = new System.Drawing.Point(17, 58);
            this.processingRadioButton.Name = "processingRadioButton";
            this.processingRadioButton.Size = new System.Drawing.Size(212, 24);
            this.processingRadioButton.TabIndex = 5;
            this.processingRadioButton.Text = "проведенная обработка";
            this.processingRadioButton.UseVisualStyleBackColor = true;
            // 
            // formReportButton
            // 
            this.formReportButton.BackColor = System.Drawing.Color.DarkOrange;
            this.formReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.formReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formReportButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.formReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formReportButton.Location = new System.Drawing.Point(113, 281);
            this.formReportButton.Name = "formReportButton";
            this.formReportButton.Size = new System.Drawing.Size(191, 34);
            this.formReportButton.TabIndex = 67;
            this.formReportButton.Text = "Сформировать отчет";
            this.formReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.formReportButton.UseVisualStyleBackColor = false;
            this.formReportButton.Click += new System.EventHandler(this.formReportButton_Click);
            // 
            // ReportsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(399, 333);
            this.Controls.Add(this.formReportButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Name = "ReportsForm";
            this.Text = "Отчеты";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox toTextBox;
        private System.Windows.Forms.TextBox fromTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton processingRadioButton;
        private System.Windows.Forms.RadioButton volumeRawRadioButton;
        private System.Windows.Forms.Button formReportButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox contractorComboBox;
        private System.Windows.Forms.ComboBox subdivisionComboBox;
    }
}