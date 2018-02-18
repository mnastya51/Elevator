namespace Elevator.Forms
{
    partial class ProcessingForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAllList = new System.Windows.Forms.Button();
            this.rawComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.nameContractorComboBox = new System.Windows.Forms.ComboBox();
            this.lbName = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewDry = new System.Windows.Forms.DataGridView();
            this.changeDryButton = new System.Windows.Forms.Button();
            this.addDryButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridViewClear = new System.Windows.Forms.DataGridView();
            this.changeClearButton = new System.Windows.Forms.Button();
            this.addClearButton = new System.Windows.Forms.Button();
            this.bindingSourceDry = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSourceClear = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDry)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClear)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDry)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClear)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(580, 257);
            this.groupBox1.TabIndex = 62;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAllList);
            this.groupBox2.Controls.Add(this.rawComboBox);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.findButton);
            this.groupBox2.Controls.Add(this.nameContractorComboBox);
            this.groupBox2.Controls.Add(this.lbName);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(11, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(557, 105);
            this.groupBox2.TabIndex = 44;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Поиск";
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAllList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAllList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllList.Location = new System.Drawing.Point(230, 62);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(202, 28);
            this.btnAllList.TabIndex = 7;
            this.btnAllList.Text = "Вывести полный список";
            this.btnAllList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllList.UseVisualStyleBackColor = false;
            // 
            // rawComboBox
            // 
            this.rawComboBox.FormattingEnabled = true;
            this.rawComboBox.Location = new System.Drawing.Point(422, 21);
            this.rawComboBox.Name = "rawComboBox";
            this.rawComboBox.Size = new System.Drawing.Size(125, 24);
            this.rawComboBox.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(358, 27);
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
            this.findButton.Location = new System.Drawing.Point(128, 62);
            this.findButton.Name = "findButton";
            this.findButton.Size = new System.Drawing.Size(82, 28);
            this.findButton.TabIndex = 5;
            this.findButton.Text = "Найти";
            this.findButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.findButton.UseVisualStyleBackColor = false;
            // 
            // nameContractorComboBox
            // 
            this.nameContractorComboBox.FormattingEnabled = true;
            this.nameContractorComboBox.Location = new System.Drawing.Point(158, 21);
            this.nameContractorComboBox.Name = "nameContractorComboBox";
            this.nameContractorComboBox.Size = new System.Drawing.Size(189, 24);
            this.nameContractorComboBox.TabIndex = 7;
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
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tabControl);
            this.groupBox3.Location = new System.Drawing.Point(598, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(514, 257);
            this.groupBox3.TabIndex = 63;
            this.groupBox3.TabStop = false;
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabControl.Location = new System.Drawing.Point(6, 14);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(502, 234);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.tabPage1.Controls.Add(this.dataGridViewDry);
            this.tabPage1.Controls.Add(this.changeDryButton);
            this.tabPage1.Controls.Add(this.addDryButton);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tabPage1.Location = new System.Drawing.Point(4, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(494, 203);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Сушка";
            // 
            // dataGridViewDry
            // 
            this.dataGridViewDry.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewDry.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewDry.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDry.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDry.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDry.EnableHeadersVisualStyles = false;
            this.dataGridViewDry.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewDry.Name = "dataGridViewDry";
            this.dataGridViewDry.ReadOnly = true;
            this.dataGridViewDry.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDry.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDry.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDry.Size = new System.Drawing.Size(233, 51);
            this.dataGridViewDry.TabIndex = 61;
            // 
            // changeDryButton
            // 
            this.changeDryButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeDryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeDryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeDryButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeDryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeDryButton.Location = new System.Drawing.Point(100, 6);
            this.changeDryButton.Name = "changeDryButton";
            this.changeDryButton.Size = new System.Drawing.Size(88, 28);
            this.changeDryButton.TabIndex = 48;
            this.changeDryButton.Text = "Изменить";
            this.changeDryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeDryButton.UseVisualStyleBackColor = false;
            // 
            // addDryButton
            // 
            this.addDryButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addDryButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addDryButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addDryButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addDryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addDryButton.Location = new System.Drawing.Point(6, 6);
            this.addDryButton.Name = "addDryButton";
            this.addDryButton.Size = new System.Drawing.Size(88, 28);
            this.addDryButton.TabIndex = 47;
            this.addDryButton.Text = "Добавить";
            this.addDryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addDryButton.UseVisualStyleBackColor = false;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.tabPage2.Controls.Add(this.dataGridViewClear);
            this.tabPage2.Controls.Add(this.changeClearButton);
            this.tabPage2.Controls.Add(this.addClearButton);
            this.tabPage2.Location = new System.Drawing.Point(4, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(494, 203);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Чистка";
            // 
            // dataGridViewClear
            // 
            this.dataGridViewClear.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewClear.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewClear.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClear.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClear.EnableHeadersVisualStyles = false;
            this.dataGridViewClear.Location = new System.Drawing.Point(6, 49);
            this.dataGridViewClear.Name = "dataGridViewClear";
            this.dataGridViewClear.ReadOnly = true;
            this.dataGridViewClear.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClear.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClear.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClear.Size = new System.Drawing.Size(233, 51);
            this.dataGridViewClear.TabIndex = 62;
            // 
            // changeClearButton
            // 
            this.changeClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeClearButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeClearButton.Location = new System.Drawing.Point(100, 6);
            this.changeClearButton.Name = "changeClearButton";
            this.changeClearButton.Size = new System.Drawing.Size(88, 28);
            this.changeClearButton.TabIndex = 50;
            this.changeClearButton.Text = "Изменить";
            this.changeClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeClearButton.UseVisualStyleBackColor = false;
            // 
            // addClearButton
            // 
            this.addClearButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addClearButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addClearButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addClearButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addClearButton.Location = new System.Drawing.Point(6, 6);
            this.addClearButton.Name = "addClearButton";
            this.addClearButton.Size = new System.Drawing.Size(88, 28);
            this.addClearButton.TabIndex = 49;
            this.addClearButton.Text = "Добавить";
            this.addClearButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addClearButton.UseVisualStyleBackColor = false;
            // 
            // ProcessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(1119, 280);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ProcessingForm";
            this.Text = "Обработка";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDry)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClear)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceDry)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceClear)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.ComboBox rawComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.ComboBox nameContractorComboBox;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button changeDryButton;
        private System.Windows.Forms.Button addDryButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button changeClearButton;
        private System.Windows.Forms.Button addClearButton;
        private System.Windows.Forms.BindingSource bindingSourceDry;
        private System.Windows.Forms.DataGridView dataGridViewDry;
        private System.Windows.Forms.DataGridView dataGridViewClear;
        private System.Windows.Forms.BindingSource bindingSourceClear;
    }
}