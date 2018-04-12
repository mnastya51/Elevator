namespace Elevator.Forms
{
    partial class DateAnalysForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewRaw = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.contractorTextBox = new System.Windows.Forms.TextBox();
            this.rawTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btnAllList = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridViewRaw);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(589, 327);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            // 
            // dataGridViewRaw
            // 
            this.dataGridViewRaw.AllowUserToAddRows = false;
            this.dataGridViewRaw.AllowUserToDeleteRows = false;
            this.dataGridViewRaw.AllowUserToResizeRows = false;
            this.dataGridViewRaw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRaw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewRaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRaw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column1,
            this.Column2,
            this.Column4});
            this.dataGridViewRaw.EnableHeadersVisualStyles = false;
            this.dataGridViewRaw.Location = new System.Drawing.Point(12, 124);
            this.dataGridViewRaw.MultiSelect = false;
            this.dataGridViewRaw.Name = "dataGridViewRaw";
            this.dataGridViewRaw.ReadOnly = true;
            this.dataGridViewRaw.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRaw.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRaw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRaw.Size = new System.Drawing.Size(566, 187);
            this.dataGridViewRaw.TabIndex = 45;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Код сырья";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Visible = false;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Контрагент";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Сырье";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Дата поставки";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.contractorTextBox);
            this.groupBox1.Controls.Add(this.rawTextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.btnAllList);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(566, 105);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // contractorTextBox
            // 
            this.contractorTextBox.Location = new System.Drawing.Point(106, 25);
            this.contractorTextBox.Name = "contractorTextBox";
            this.contractorTextBox.Size = new System.Drawing.Size(144, 22);
            this.contractorTextBox.TabIndex = 13;
            // 
            // rawTextBox
            // 
            this.rawTextBox.Location = new System.Drawing.Point(106, 64);
            this.rawTextBox.Name = "rawTextBox";
            this.rawTextBox.Size = new System.Drawing.Size(144, 22);
            this.rawTextBox.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(256, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "Дата поставки:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(377, 25);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(181, 22);
            this.dateTimePicker.TabIndex = 10;
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAllList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAllList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllList.Location = new System.Drawing.Point(375, 60);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(183, 28);
            this.btnAllList.TabIndex = 7;
            this.btnAllList.Text = "Вывести полный список";
            this.btnAllList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllList.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(9, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Сырье:";
            // 
            // findButton
            // 
            this.findButton.BackColor = System.Drawing.Color.DarkOrange;
            this.findButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.findButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.findButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.findButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.findButton.Location = new System.Drawing.Point(268, 60);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(82, 28);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти";
            this.findButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(9, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(91, 18);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Контрагент:";
            // 
            // DateAnalysForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1303, 356);
            this.Controls.Add(this.groupBox2);
            this.Name = "DateAnalysForm";
            this.Text = "Даты анализа хранилищ";
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewRaw;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox contractorTextBox;
        private System.Windows.Forms.TextBox rawTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Label lbName;
    }
}