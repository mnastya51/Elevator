namespace Elevator.AddAndEditForms
{
    partial class AddContractForm
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
            this.labelSubdivision = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.goalTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.contactorComboBox = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelSubdivision
            // 
            this.labelSubdivision.AutoSize = true;
            this.labelSubdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubdivision.Location = new System.Drawing.Point(3, 80);
            this.labelSubdivision.Name = "labelSubdivision";
            this.labelSubdivision.Size = new System.Drawing.Size(52, 20);
            this.labelSubdivision.TabIndex = 56;
            this.labelSubdivision.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(148, 79);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(2, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Цель:";
            // 
            // goalTextBox
            // 
            this.goalTextBox.Location = new System.Drawing.Point(148, 115);
            this.goalTextBox.MaxLength = 20;
            this.goalTextBox.Name = "goalTextBox";
            this.goalTextBox.Size = new System.Drawing.Size(200, 20);
            this.goalTextBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Контрагент:";
            // 
            // contactorComboBox
            // 
            this.contactorComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.contactorComboBox.FormattingEnabled = true;
            this.contactorComboBox.Location = new System.Drawing.Point(148, 42);
            this.contactorComboBox.Name = "contactorComboBox";
            this.contactorComboBox.Size = new System.Drawing.Size(200, 21);
            this.contactorComboBox.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(2, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 20);
            this.label3.TabIndex = 62;
            this.label3.Text = "Наим. договора*:";
            // 
            // contactTextBox
            // 
            this.contactTextBox.BackColor = System.Drawing.Color.Red;
            this.contactTextBox.Location = new System.Drawing.Point(148, 8);
            this.contactTextBox.MaxLength = 20;
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(200, 20);
            this.contactTextBox.TabIndex = 1;
            this.contactTextBox.TextChanged += new System.EventHandler(this.contactTextBox_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.Red;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(126, 155);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddContractForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(360, 201);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactorComboBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.goalTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.labelSubdivision);
            this.Name = "AddContractForm";
            this.Text = "Добавление договора";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSubdivision;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox goalTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox contactorComboBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Button saveButton;
    }
}