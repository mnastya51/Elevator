namespace Elevator.AddAndEditForms
{
    partial class AddAnalysQualityRawForm
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
            this.labelDate = new System.Windows.Forms.Label();
            this.analysDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.taypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.subtypeComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.impurityComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.valueTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelDate.Location = new System.Drawing.Point(12, 9);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(119, 20);
            this.labelDate.TabIndex = 54;
            this.labelDate.Text = "Дата анализа:";
            // 
            // analysDateTimePicker
            // 
            this.analysDateTimePicker.Location = new System.Drawing.Point(151, 8);
            this.analysDateTimePicker.Name = "analysDateTimePicker";
            this.analysDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.analysDateTimePicker.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Тип:";
            // 
            // taypeComboBox
            // 
            this.taypeComboBox.FormattingEnabled = true;
            this.taypeComboBox.Location = new System.Drawing.Point(151, 42);
            this.taypeComboBox.Name = "taypeComboBox";
            this.taypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.taypeComboBox.TabIndex = 57;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(12, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 58;
            this.label2.Text = "Подтип:";
            // 
            // subtypeComboBox
            // 
            this.subtypeComboBox.FormattingEnabled = true;
            this.subtypeComboBox.Location = new System.Drawing.Point(151, 79);
            this.subtypeComboBox.Name = "subtypeComboBox";
            this.subtypeComboBox.Size = new System.Drawing.Size(200, 21);
            this.subtypeComboBox.TabIndex = 59;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 60;
            this.label3.Text = "Группа:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(151, 117);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(200, 21);
            this.groupComboBox.TabIndex = 61;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(12, 155);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 62;
            this.label4.Text = "Вид показателя:";
            // 
            // impurityComboBox
            // 
            this.impurityComboBox.FormattingEnabled = true;
            this.impurityComboBox.Location = new System.Drawing.Point(151, 154);
            this.impurityComboBox.Name = "impurityComboBox";
            this.impurityComboBox.Size = new System.Drawing.Size(200, 21);
            this.impurityComboBox.TabIndex = 63;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(12, 190);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 20);
            this.label5.TabIndex = 64;
            this.label5.Text = "Значение:";
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(151, 190);
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(200, 20);
            this.valueTextBox.TabIndex = 65;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(117, 229);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 67;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // AddAnalysQualityRawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(371, 281);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.impurityComboBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.groupComboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.subtypeComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.taypeComboBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.analysDateTimePicker);
            this.Controls.Add(this.labelDate);
            this.Name = "AddAnalysQualityRawForm";
            this.Text = "Добавление качества сырья";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.DateTimePicker analysDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox taypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox subtypeComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox impurityComboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox valueTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}