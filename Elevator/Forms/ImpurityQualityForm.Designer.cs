namespace Elevator.Forms
{
    partial class ImpurityQualityForm
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.labelName = new System.Windows.Forms.Label();
            this.nameComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewImpurityQuality = new System.Windows.Forms.DataGridView();
            this.bindingSourceImpurityQuality = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpurityQuality)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceImpurityQuality)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(12, 22);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(108, 20);
            this.labelName.TabIndex = 54;
            this.labelName.Text = "Наим. сырья:";
            // 
            // nameComboBox
            // 
            this.nameComboBox.FormattingEnabled = true;
            this.nameComboBox.Location = new System.Drawing.Point(137, 21);
            this.nameComboBox.Name = "nameComboBox";
            this.nameComboBox.Size = new System.Drawing.Size(162, 24);
            this.nameComboBox.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 56;
            this.label1.Text = "Группа:";
            // 
            // groupComboBox
            // 
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Location = new System.Drawing.Point(137, 61);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(162, 24);
            this.groupComboBox.TabIndex = 57;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.nameComboBox);
            this.groupBox1.Controls.Add(this.groupComboBox);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 105);
            this.groupBox1.TabIndex = 58;
            this.groupBox1.TabStop = false;
            // 
            // showButton
            // 
            this.showButton.BackColor = System.Drawing.Color.DarkOrange;
            this.showButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.showButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.showButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.showButton.Location = new System.Drawing.Point(318, 51);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(92, 34);
            this.showButton.TabIndex = 67;
            this.showButton.Text = "Показать";
            this.showButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(202, 123);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 28);
            this.deleteButton.TabIndex = 61;
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
            this.changeButton.Location = new System.Drawing.Point(108, 123);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 28);
            this.changeButton.TabIndex = 60;
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
            this.addButton.Location = new System.Drawing.Point(12, 123);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 28);
            this.addButton.TabIndex = 59;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // dataGridViewImpurityQuality
            // 
            this.dataGridViewImpurityQuality.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewImpurityQuality.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewImpurityQuality.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImpurityQuality.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewImpurityQuality.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewImpurityQuality.EnableHeadersVisualStyles = false;
            this.dataGridViewImpurityQuality.Location = new System.Drawing.Point(12, 167);
            this.dataGridViewImpurityQuality.Name = "dataGridViewImpurityQuality";
            this.dataGridViewImpurityQuality.ReadOnly = true;
            this.dataGridViewImpurityQuality.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewImpurityQuality.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewImpurityQuality.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewImpurityQuality.Size = new System.Drawing.Size(233, 51);
            this.dataGridViewImpurityQuality.TabIndex = 62;
            // 
            // ImpurityQualityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(873, 298);
            this.Controls.Add(this.dataGridViewImpurityQuality);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "ImpurityQualityForm";
            this.Text = "Показатели качества";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewImpurityQuality)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceImpurityQuality)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.ComboBox nameComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.DataGridView dataGridViewImpurityQuality;
        private System.Windows.Forms.BindingSource bindingSourceImpurityQuality;
    }
}