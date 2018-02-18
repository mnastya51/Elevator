namespace Elevator.Forms
{
    partial class AddEmployeeForm
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
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.labelPost = new System.Windows.Forms.Label();
            this.secnameLabel = new System.Windows.Forms.Label();
            this.rawLabel = new System.Windows.Forms.Label();
            this.lbSurname = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.secnameTextBox = new System.Windows.Forms.TextBox();
            this.comboBoxPost = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBoxPost);
            this.groupBox1.Controls.Add(this.secnameTextBox);
            this.groupBox1.Controls.Add(this.nameTextBox);
            this.groupBox1.Controls.Add(this.surnameTextBox);
            this.groupBox1.Controls.Add(this.labelPost);
            this.groupBox1.Controls.Add(this.secnameLabel);
            this.groupBox1.Controls.Add(this.rawLabel);
            this.groupBox1.Controls.Add(this.lbSurname);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 183);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о сотруднике";
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(115, 26);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(231, 22);
            this.surnameTextBox.TabIndex = 22;
            // 
            // labelPost
            // 
            this.labelPost.AutoSize = true;
            this.labelPost.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPost.ForeColor = System.Drawing.Color.Black;
            this.labelPost.Location = new System.Drawing.Point(9, 149);
            this.labelPost.Name = "labelPost";
            this.labelPost.Size = new System.Drawing.Size(93, 18);
            this.labelPost.TabIndex = 19;
            this.labelPost.Text = "Должность:";
            // 
            // secnameLabel
            // 
            this.secnameLabel.AutoSize = true;
            this.secnameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.secnameLabel.ForeColor = System.Drawing.Color.Black;
            this.secnameLabel.Location = new System.Drawing.Point(9, 104);
            this.secnameLabel.Name = "secnameLabel";
            this.secnameLabel.Size = new System.Drawing.Size(79, 18);
            this.secnameLabel.TabIndex = 17;
            this.secnameLabel.Text = "Отчество:";
            // 
            // rawLabel
            // 
            this.rawLabel.AutoSize = true;
            this.rawLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawLabel.ForeColor = System.Drawing.Color.Black;
            this.rawLabel.Location = new System.Drawing.Point(9, 63);
            this.rawLabel.Name = "rawLabel";
            this.rawLabel.Size = new System.Drawing.Size(42, 18);
            this.rawLabel.TabIndex = 15;
            this.rawLabel.Text = "Имя:";
            // 
            // lbSurname
            // 
            this.lbSurname.AutoSize = true;
            this.lbSurname.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbSurname.ForeColor = System.Drawing.Color.Black;
            this.lbSurname.Location = new System.Drawing.Point(9, 27);
            this.lbSurname.Name = "lbSurname";
            this.lbSurname.Size = new System.Drawing.Size(77, 18);
            this.lbSurname.TabIndex = 6;
            this.lbSurname.Text = "Фамилия:";
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(115, 63);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(231, 22);
            this.nameTextBox.TabIndex = 23;
            // 
            // secnameTextBox
            // 
            this.secnameTextBox.Location = new System.Drawing.Point(115, 104);
            this.secnameTextBox.Name = "secnameTextBox";
            this.secnameTextBox.Size = new System.Drawing.Size(231, 22);
            this.secnameTextBox.TabIndex = 24;
            // 
            // comboBoxPost
            // 
            this.comboBoxPost.FormattingEnabled = true;
            this.comboBoxPost.Location = new System.Drawing.Point(115, 143);
            this.comboBoxPost.Name = "comboBoxPost";
            this.comboBoxPost.Size = new System.Drawing.Size(231, 24);
            this.comboBoxPost.TabIndex = 25;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox2);
            this.groupBox2.Controls.Add(this.textBox3);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(13, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(358, 99);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Информация для входа в систему";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(115, 63);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(231, 22);
            this.textBox2.TabIndex = 23;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(115, 26);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(231, 22);
            this.textBox3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 15;
            this.label3.Text = "Пароль:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(9, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Логин:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(128, 315);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 68;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            // 
            // AddEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(383, 359);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddEmployeeForm";
            this.Text = "Добавление сотрудника";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxPost;
        private System.Windows.Forms.TextBox secnameTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label labelPost;
        private System.Windows.Forms.Label secnameLabel;
        private System.Windows.Forms.Label rawLabel;
        private System.Windows.Forms.Label lbSurname;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button saveButton;
    }
}