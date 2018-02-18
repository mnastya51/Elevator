namespace Elevator.Forms
{
    partial class ReportForm
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
            this.label4 = new System.Windows.Forms.Label();
            this.contractorComboBox = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.volumeRawRadioButton = new System.Windows.Forms.RadioButton();
            this.formReportButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toTextBox
            // 
            this.toTextBox.Location = new System.Drawing.Point(228, 10);
            this.toTextBox.Name = "toTextBox";
            this.toTextBox.Size = new System.Drawing.Size(100, 20);
            this.toTextBox.TabIndex = 10;
            // 
            // fromTextBox
            // 
            this.fromTextBox.Location = new System.Drawing.Point(91, 11);
            this.fromTextBox.Name = "fromTextBox";
            this.fromTextBox.Size = new System.Drawing.Size(100, 20);
            this.fromTextBox.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(197, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 18);
            this.label2.TabIndex = 8;
            this.label2.Text = "по";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 18);
            this.label3.TabIndex = 11;
            this.label3.Text = "Период с";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.volumeRawRadioButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(15, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 197);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выберите отчет";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.contractorComboBox);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(17, 58);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(338, 126);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Выберите контрагента";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Контрагент:";
            // 
            // contractorComboBox
            // 
            this.contractorComboBox.FormattingEnabled = true;
            this.contractorComboBox.Location = new System.Drawing.Point(122, 27);
            this.contractorComboBox.Name = "contractorComboBox";
            this.contractorComboBox.Size = new System.Drawing.Size(194, 24);
            this.contractorComboBox.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton1.Location = new System.Drawing.Point(18, 97);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(195, 22);
            this.radioButton1.TabIndex = 5;
            this.radioButton1.Text = "проведенная обработка";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButton2.Location = new System.Drawing.Point(18, 69);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(116, 22);
            this.radioButton2.TabIndex = 4;
            this.radioButton2.Text = "объем зерна";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // volumeRawRadioButton
            // 
            this.volumeRawRadioButton.AutoSize = true;
            this.volumeRawRadioButton.Checked = true;
            this.volumeRawRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.volumeRawRadioButton.Location = new System.Drawing.Point(17, 30);
            this.volumeRawRadioButton.Name = "volumeRawRadioButton";
            this.volumeRawRadioButton.Size = new System.Drawing.Size(116, 22);
            this.volumeRawRadioButton.TabIndex = 3;
            this.volumeRawRadioButton.TabStop = true;
            this.volumeRawRadioButton.Text = "объем зерна";
            this.volumeRawRadioButton.UseVisualStyleBackColor = true;
            // 
            // formReportButton
            // 
            this.formReportButton.BackColor = System.Drawing.Color.DarkOrange;
            this.formReportButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.formReportButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.formReportButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.formReportButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.formReportButton.Location = new System.Drawing.Point(117, 256);
            this.formReportButton.Name = "formReportButton";
            this.formReportButton.Size = new System.Drawing.Size(180, 34);
            this.formReportButton.TabIndex = 67;
            this.formReportButton.Text = "Сформировать отчет";
            this.formReportButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.formReportButton.UseVisualStyleBackColor = false;
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(398, 302);
            this.Controls.Add(this.formReportButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.toTextBox);
            this.Controls.Add(this.fromTextBox);
            this.Controls.Add(this.label2);
            this.Name = "ReportForm";
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
        private System.Windows.Forms.ComboBox contractorComboBox;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton volumeRawRadioButton;
        private System.Windows.Forms.Button formReportButton;
    }
}