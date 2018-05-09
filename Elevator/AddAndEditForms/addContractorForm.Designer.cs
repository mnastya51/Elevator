namespace Elevator.AddAndEditForms
{
    partial class AddContractorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddContractorForm));
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxSubdivision = new System.Windows.Forms.TextBox();
            this.labelSubdivision = new System.Windows.Forms.Label();
            this.labelYuradress = new System.Windows.Forms.Label();
            this.labelFactadress = new System.Windows.Forms.Label();
            this.labelIndex = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.labelInn = new System.Windows.Forms.Label();
            this.richTextBoxYuradress = new System.Windows.Forms.RichTextBox();
            this.richTextBoxFactadress = new System.Windows.Forms.RichTextBox();
            this.textBoxIndex = new System.Windows.Forms.TextBox();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.textBoxINN = new System.Windows.Forms.TextBox();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxName.Location = new System.Drawing.Point(155, 16);
            this.textBoxName.MaxLength = 150;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(232, 26);
            this.textBoxName.TabIndex = 53;
            this.textBoxName.TextChanged += new System.EventHandler(this.textBoxName_TextChanged);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 16);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(132, 20);
            this.labelName.TabIndex = 52;
            this.labelName.Text = "Наименование*:";
            // 
            // textBoxSubdivision
            // 
            this.textBoxSubdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxSubdivision.Location = new System.Drawing.Point(155, 58);
            this.textBoxSubdivision.MaxLength = 50;
            this.textBoxSubdivision.Name = "textBoxSubdivision";
            this.textBoxSubdivision.Size = new System.Drawing.Size(232, 26);
            this.textBoxSubdivision.TabIndex = 55;
            // 
            // labelSubdivision
            // 
            this.labelSubdivision.AutoSize = true;
            this.labelSubdivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelSubdivision.Location = new System.Drawing.Point(12, 58);
            this.labelSubdivision.Name = "labelSubdivision";
            this.labelSubdivision.Size = new System.Drawing.Size(137, 20);
            this.labelSubdivision.TabIndex = 54;
            this.labelSubdivision.Text = "Подразделение:";
            // 
            // labelYuradress
            // 
            this.labelYuradress.AutoSize = true;
            this.labelYuradress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelYuradress.Location = new System.Drawing.Point(12, 103);
            this.labelYuradress.Name = "labelYuradress";
            this.labelYuradress.Size = new System.Drawing.Size(90, 20);
            this.labelYuradress.TabIndex = 56;
            this.labelYuradress.Text = "Юр. адрес:";
            // 
            // labelFactadress
            // 
            this.labelFactadress.AutoSize = true;
            this.labelFactadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelFactadress.Location = new System.Drawing.Point(12, 188);
            this.labelFactadress.Name = "labelFactadress";
            this.labelFactadress.Size = new System.Drawing.Size(114, 20);
            this.labelFactadress.TabIndex = 58;
            this.labelFactadress.Text = "Факт. адрес*:";
            // 
            // labelIndex
            // 
            this.labelIndex.AutoSize = true;
            this.labelIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelIndex.Location = new System.Drawing.Point(12, 269);
            this.labelIndex.Name = "labelIndex";
            this.labelIndex.Size = new System.Drawing.Size(69, 20);
            this.labelIndex.TabIndex = 60;
            this.labelIndex.Text = "Индекс:";
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelPhone.Location = new System.Drawing.Point(12, 316);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(83, 20);
            this.labelPhone.TabIndex = 62;
            this.labelPhone.Text = "Телефон:";
            // 
            // labelInn
            // 
            this.labelInn.AutoSize = true;
            this.labelInn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInn.Location = new System.Drawing.Point(12, 362);
            this.labelInn.Name = "labelInn";
            this.labelInn.Size = new System.Drawing.Size(48, 20);
            this.labelInn.TabIndex = 64;
            this.labelInn.Text = "ИНН:";
            // 
            // richTextBoxYuradress
            // 
            this.richTextBoxYuradress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxYuradress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxYuradress.Location = new System.Drawing.Point(150, 103);
            this.richTextBoxYuradress.MaxLength = 200;
            this.richTextBoxYuradress.Name = "richTextBoxYuradress";
            this.richTextBoxYuradress.Size = new System.Drawing.Size(232, 63);
            this.richTextBoxYuradress.TabIndex = 69;
            this.richTextBoxYuradress.Text = "";
            // 
            // richTextBoxFactadress
            // 
            this.richTextBoxFactadress.BackColor = System.Drawing.Color.LightBlue;
            this.richTextBoxFactadress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBoxFactadress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.richTextBoxFactadress.Location = new System.Drawing.Point(150, 188);
            this.richTextBoxFactadress.MaxLength = 200;
            this.richTextBoxFactadress.Name = "richTextBoxFactadress";
            this.richTextBoxFactadress.Size = new System.Drawing.Size(232, 63);
            this.richTextBoxFactadress.TabIndex = 70;
            this.richTextBoxFactadress.Text = "";
            this.richTextBoxFactadress.TextChanged += new System.EventHandler(this.richTextBoxFactadress_TextChanged);
            // 
            // textBoxIndex
            // 
            this.textBoxIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxIndex.Location = new System.Drawing.Point(150, 269);
            this.textBoxIndex.Name = "textBoxIndex";
            this.textBoxIndex.Size = new System.Drawing.Size(232, 26);
            this.textBoxIndex.TabIndex = 71;
            this.textBoxIndex.TextChanged += new System.EventHandler(this.textBoxIndex_TextChanged);
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(150, 316);
            this.maskedTextBoxPhone.Mask = "8(000)000-0000";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.RejectInputOnFirstFailure = true;
            this.maskedTextBoxPhone.ResetOnSpace = false;
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(232, 26);
            this.maskedTextBoxPhone.TabIndex = 75;
            // 
            // textBoxINN
            // 
            this.textBoxINN.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxINN.Location = new System.Drawing.Point(150, 362);
            this.textBoxINN.Name = "textBoxINN";
            this.textBoxINN.Size = new System.Drawing.Size(232, 26);
            this.textBoxINN.TabIndex = 76;
            this.textBoxINN.TextChanged += new System.EventHandler(this.textBoxINN_TextChanged);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(150, 407);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(100, 36);
            this.saveButton.TabIndex = 77;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(406, 463);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.textBoxINN);
            this.Controls.Add(this.maskedTextBoxPhone);
            this.Controls.Add(this.textBoxIndex);
            this.Controls.Add(this.richTextBoxFactadress);
            this.Controls.Add(this.richTextBoxYuradress);
            this.Controls.Add(this.labelInn);
            this.Controls.Add(this.labelPhone);
            this.Controls.Add(this.labelIndex);
            this.Controls.Add(this.labelFactadress);
            this.Controls.Add(this.labelYuradress);
            this.Controls.Add(this.textBoxSubdivision);
            this.Controls.Add(this.labelSubdivision);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.labelName);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(422, 502);
            this.MinimumSize = new System.Drawing.Size(422, 502);
            this.Name = "AddContractorForm";
            this.Text = "Добавление контрагента";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxSubdivision;
        private System.Windows.Forms.Label labelSubdivision;
        private System.Windows.Forms.Label labelYuradress;
        private System.Windows.Forms.Label labelFactadress;
        private System.Windows.Forms.Label labelIndex;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.Label labelInn;
        private System.Windows.Forms.RichTextBox richTextBoxYuradress;
        private System.Windows.Forms.RichTextBox richTextBoxFactadress;
        private System.Windows.Forms.TextBox textBoxIndex;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.TextBox textBoxINN;
        private System.Windows.Forms.Button saveButton;
    }
}