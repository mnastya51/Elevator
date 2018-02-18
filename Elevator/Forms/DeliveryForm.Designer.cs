namespace Elevator.Forms
{
    partial class DeliveryForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contractorComboBox = new System.Windows.Forms.ComboBox();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rawComboBox = new System.Windows.Forms.ComboBox();
            this.btnAllList = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contractorComboBox);
            this.groupBox1.Controls.Add(this.toDateTimePicker);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.fromDateTimePicker);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rawComboBox);
            this.groupBox1.Controls.Add(this.btnAllList);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1010, 104);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // contractorComboBox
            // 
            this.contractorComboBox.FormattingEnabled = true;
            this.contractorComboBox.Location = new System.Drawing.Point(154, 21);
            this.contractorComboBox.Name = "contractorComboBox";
            this.contractorComboBox.Size = new System.Drawing.Size(231, 24);
            this.contractorComboBox.TabIndex = 14;
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(838, 27);
            this.toDateTimePicker.Name = "toDateTimePicker";
            this.toDateTimePicker.Size = new System.Drawing.Size(159, 22);
            this.toDateTimePicker.TabIndex = 13;
            this.toDateTimePicker.Value = new System.DateTime(2018, 3, 8, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(807, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "по";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(642, 26);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(159, 22);
            this.fromDateTimePicker.TabIndex = 11;
            this.fromDateTimePicker.Value = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(582, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 18);
            this.label2.TabIndex = 10;
            this.label2.Text = "Дата с";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(391, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 9;
            this.label1.Text = "Сырье:";
            // 
            // rawComboBox
            // 
            this.rawComboBox.FormattingEnabled = true;
            this.rawComboBox.Location = new System.Drawing.Point(455, 24);
            this.rawComboBox.Name = "rawComboBox";
            this.rawComboBox.Size = new System.Drawing.Size(121, 24);
            this.rawComboBox.TabIndex = 8;
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAllList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAllList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllList.Location = new System.Drawing.Point(507, 63);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(202, 28);
            this.btnAllList.TabIndex = 7;
            this.btnAllList.Text = "Вывести полный список";
            this.btnAllList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllList.UseVisualStyleBackColor = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(9, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(143, 18);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Наим. контрагента:";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.DarkOrange;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findButton.Location = new System.Drawing.Point(394, 63);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(82, 28);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти";
            this.findButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.Location = new System.Drawing.Point(108, 122);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 28);
            this.changeButton.TabIndex = 48;
            this.changeButton.Text = "Изменить";
            this.changeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(12, 122);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 28);
            this.addButton.TabIndex = 47;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1034, 261);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "DeliveryForm";
            this.Text = "Поставки";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox rawComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox contractorComboBox;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
    }
}