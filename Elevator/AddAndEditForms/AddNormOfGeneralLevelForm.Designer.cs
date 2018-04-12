namespace Elevator.AddAndEditForms
{
    partial class AddNormOfGeneralLevelForm
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
            this.impComboBox = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxNorm = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.normLabel = new System.Windows.Forms.Label();
            this.radioButtonMin = new System.Windows.Forms.RadioButton();
            this.radioButtonMax = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // impComboBox
            // 
            this.impComboBox.DisplayMember = "name_raw";
            this.impComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.impComboBox.FormattingEnabled = true;
            this.impComboBox.Location = new System.Drawing.Point(123, 8);
            this.impComboBox.Name = "impComboBox";
            this.impComboBox.Size = new System.Drawing.Size(256, 21);
            this.impComboBox.TabIndex = 83;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 9);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(105, 20);
            this.labelName.TabIndex = 82;
            this.labelName.Text = "Показатель:";
            // 
            // textBoxNorm
            // 
            this.textBoxNorm.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxNorm.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxNorm.Location = new System.Drawing.Point(123, 43);
            this.textBoxNorm.MaxLength = 5;
            this.textBoxNorm.Name = "textBoxNorm";
            this.textBoxNorm.Size = new System.Drawing.Size(256, 22);
            this.textBoxNorm.TabIndex = 81;
            this.textBoxNorm.TextChanged += new System.EventHandler(this.textBoxNorm_TextChanged);
            this.textBoxNorm.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNorm_KeyPress);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(150, 179);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 80;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // normLabel
            // 
            this.normLabel.AutoSize = true;
            this.normLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.normLabel.Location = new System.Drawing.Point(12, 45);
            this.normLabel.Name = "normLabel";
            this.normLabel.Size = new System.Drawing.Size(63, 20);
            this.normLabel.TabIndex = 79;
            this.normLabel.Text = "Норма:";
            // 
            // radioButtonMin
            // 
            this.radioButtonMin.AutoSize = true;
            this.radioButtonMin.Checked = true;
            this.radioButtonMin.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMin.Location = new System.Drawing.Point(134, 19);
            this.radioButtonMin.Name = "radioButtonMin";
            this.radioButtonMin.Size = new System.Drawing.Size(89, 22);
            this.radioButtonMin.TabIndex = 84;
            this.radioButtonMin.TabStop = true;
            this.radioButtonMin.Text = "не менее";
            this.radioButtonMin.UseVisualStyleBackColor = true;
            // 
            // radioButtonMax
            // 
            this.radioButtonMax.AutoSize = true;
            this.radioButtonMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.radioButtonMax.Location = new System.Drawing.Point(134, 47);
            this.radioButtonMax.Name = "radioButtonMax";
            this.radioButtonMax.Size = new System.Drawing.Size(89, 22);
            this.radioButtonMax.TabIndex = 85;
            this.radioButtonMax.Text = "не более";
            this.radioButtonMax.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonMin);
            this.groupBox1.Controls.Add(this.radioButtonMax);
            this.groupBox1.Location = new System.Drawing.Point(16, 83);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 77);
            this.groupBox1.TabIndex = 87;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Настройка нормы";
            // 
            // AddNormOfGeneralLevelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(398, 225);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.impComboBox);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.textBoxNorm);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.normLabel);
            this.Name = "AddNormOfGeneralLevelForm";
            this.Text = "Добавление нормы показателя качества";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox impComboBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxNorm;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label normLabel;
        private System.Windows.Forms.RadioButton radioButtonMin;
        private System.Windows.Forms.RadioButton radioButtonMax;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}