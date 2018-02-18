namespace Elevator.Forms
{
    partial class ContarctForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAllList = new System.Windows.Forms.Button();
            this.nameContractorComboBox = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewRaw = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnAllList);
            this.groupBox1.Controls.Add(this.nameContractorComboBox);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(729, 68);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAllList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAllList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllList.Location = new System.Drawing.Point(516, 23);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(202, 28);
            this.btnAllList.TabIndex = 9;
            this.btnAllList.Text = "Вывести полный список";
            this.btnAllList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllList.UseVisualStyleBackColor = false;
            // 
            // nameContractorComboBox
            // 
            this.nameContractorComboBox.FormattingEnabled = true;
            this.nameContractorComboBox.Location = new System.Drawing.Point(158, 26);
            this.nameContractorComboBox.Name = "nameContractorComboBox";
            this.nameContractorComboBox.Size = new System.Drawing.Size(248, 24);
            this.nameContractorComboBox.TabIndex = 8;
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
            this.findButton.Location = new System.Drawing.Point(428, 23);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(82, 28);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти";
            this.findButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(202, 86);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 28);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.Location = new System.Drawing.Point(108, 86);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 28);
            this.changeButton.TabIndex = 49;
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
            this.addButton.Location = new System.Drawing.Point(12, 86);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 28);
            this.addButton.TabIndex = 48;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // dataGridViewRaw
            // 
            this.dataGridViewRaw.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.dataGridViewRaw.EnableHeadersVisualStyles = false;
            this.dataGridViewRaw.Location = new System.Drawing.Point(12, 130);
            this.dataGridViewRaw.Name = "dataGridViewRaw";
            this.dataGridViewRaw.ReadOnly = true;
            this.dataGridViewRaw.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRaw.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRaw.Size = new System.Drawing.Size(497, 51);
            this.dataGridViewRaw.TabIndex = 61;
            // 
            // ContarctForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(747, 338);
            this.Controls.Add(this.dataGridViewRaw);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ContarctForm";
            this.Text = "Договора";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox nameContractorComboBox;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.DataGridView dataGridViewRaw;
    }
}