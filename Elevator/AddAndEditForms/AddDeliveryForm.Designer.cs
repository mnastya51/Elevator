namespace Elevator.AddAndEditForms
{
    partial class AddDeliveryForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.yearNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.subtypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.transportTextBox = new System.Windows.Forms.TextBox();
            this.labelTransport = new System.Windows.Forms.Label();
            this.labelYear = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.labelDate = new System.Windows.Forms.Label();
            this.rawComboBox = new System.Windows.Forms.ComboBox();
            this.rawLabel = new System.Windows.Forms.Label();
            this.contractorComboBox = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 289);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Вес:";
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(159, 287);
            this.weightTextBox.MaxLength = 20;
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(231, 20);
            this.weightTextBox.TabIndex = 8;
            // 
            // yearNumericUpDown
            // 
            this.yearNumericUpDown.Location = new System.Drawing.Point(159, 208);
            this.yearNumericUpDown.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
            this.yearNumericUpDown.Minimum = new decimal(new int[] {
            1960,
            0,
            0,
            0});
            this.yearNumericUpDown.Name = "yearNumericUpDown";
            this.yearNumericUpDown.Size = new System.Drawing.Size(231, 20);
            this.yearNumericUpDown.TabIndex = 6;
            this.yearNumericUpDown.Value = new decimal(new int[] {
            2018,
            0,
            0,
            0});
            // 
            // subtypeComboBox
            // 
            this.subtypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.subtypeComboBox.FormattingEnabled = true;
            this.subtypeComboBox.Location = new System.Drawing.Point(159, 129);
            this.subtypeComboBox.Name = "subtypeComboBox";
            this.subtypeComboBox.Size = new System.Drawing.Size(231, 21);
            this.subtypeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(14, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 18);
            this.label2.TabIndex = 25;
            this.label2.Text = "Подтип:";
            // 
            // typeComboBox
            // 
            this.typeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(159, 89);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(231, 21);
            this.typeComboBox.TabIndex = 3;
            this.typeComboBox.SelectedIndexChanged += new System.EventHandler(this.typeComboBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(14, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 18);
            this.label1.TabIndex = 23;
            this.label1.Text = "Тип:";
            // 
            // transportTextBox
            // 
            this.transportTextBox.Location = new System.Drawing.Point(159, 248);
            this.transportTextBox.MaxLength = 20;
            this.transportTextBox.Name = "transportTextBox";
            this.transportTextBox.Size = new System.Drawing.Size(231, 20);
            this.transportTextBox.TabIndex = 7;
            // 
            // labelTransport
            // 
            this.labelTransport.AutoSize = true;
            this.labelTransport.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTransport.ForeColor = System.Drawing.Color.Black;
            this.labelTransport.Location = new System.Drawing.Point(14, 248);
            this.labelTransport.Name = "labelTransport";
            this.labelTransport.Size = new System.Drawing.Size(85, 18);
            this.labelTransport.TabIndex = 21;
            this.labelTransport.Text = "Транспорт:";
            // 
            // labelYear
            // 
            this.labelYear.AutoSize = true;
            this.labelYear.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYear.ForeColor = System.Drawing.Color.Black;
            this.labelYear.Location = new System.Drawing.Point(14, 212);
            this.labelYear.Name = "labelYear";
            this.labelYear.Size = new System.Drawing.Size(94, 18);
            this.labelYear.TabIndex = 19;
            this.labelYear.Text = "Год урожая:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(159, 169);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(231, 20);
            this.dateTimePicker.TabIndex = 5;
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.ForeColor = System.Drawing.Color.Black;
            this.labelDate.Location = new System.Drawing.Point(14, 173);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(47, 18);
            this.labelDate.TabIndex = 17;
            this.labelDate.Text = "Дата:";
            // 
            // rawComboBox
            // 
            this.rawComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rawComboBox.FormattingEnabled = true;
            this.rawComboBox.Location = new System.Drawing.Point(159, 48);
            this.rawComboBox.Name = "rawComboBox";
            this.rawComboBox.Size = new System.Drawing.Size(231, 21);
            this.rawComboBox.TabIndex = 2;
            this.rawComboBox.SelectedIndexChanged += new System.EventHandler(this.rawComboBox_SelectedIndexChanged);
            // 
            // rawLabel
            // 
            this.rawLabel.AutoSize = true;
            this.rawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawLabel.ForeColor = System.Drawing.Color.Black;
            this.rawLabel.Location = new System.Drawing.Point(14, 54);
            this.rawLabel.Name = "rawLabel";
            this.rawLabel.Size = new System.Drawing.Size(123, 18);
            this.rawLabel.TabIndex = 18;
            this.rawLabel.Text = "Наим. культуры:";
            // 
            // contractorComboBox
            // 
            this.contractorComboBox.BackColor = System.Drawing.SystemColors.Window;
            this.contractorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contractorComboBox.FormattingEnabled = true;
            this.contractorComboBox.Location = new System.Drawing.Point(159, 12);
            this.contractorComboBox.Name = "contractorComboBox";
            this.contractorComboBox.Size = new System.Drawing.Size(231, 21);
            this.contractorComboBox.TabIndex = 1;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(14, 18);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(143, 18);
            this.lbName.TabIndex = 21;
            this.lbName.Text = "Наим. контрагента:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(159, 327);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 11;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddDeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(411, 381);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.yearNumericUpDown);
            this.Controls.Add(this.subtypeComboBox);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.contractorComboBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.rawLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rawComboBox);
            this.Controls.Add(this.transportTextBox);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTransport);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelYear);
            this.Name = "AddDeliveryForm";
            this.Text = "Добавление поставки";
            ((System.ComponentModel.ISupportInitialize)(this.yearNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox transportTextBox;
        private System.Windows.Forms.Label labelTransport;
        private System.Windows.Forms.Label labelYear;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.ComboBox rawComboBox;
        private System.Windows.Forms.Label rawLabel;
        private System.Windows.Forms.ComboBox contractorComboBox;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.ComboBox subtypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown yearNumericUpDown;
    }
}