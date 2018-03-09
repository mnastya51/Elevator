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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.fromDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.rawComboBox = new System.Windows.Forms.ComboBox();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.filtrGroupBox = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.contractorRadioButton = new System.Windows.Forms.RadioButton();
            this.rawRadioButton = new System.Windows.Forms.RadioButton();
            this.yearRadioButton = new System.Windows.Forms.RadioButton();
            this.dataGridViewDelivery = new System.Windows.Forms.DataGridView();
            this.accountOfGrainDataSet = new Elevator.AccountOfGrainDataSet();
            this.rawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.RawTableAdapter();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.ContractorTableAdapter();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.filtrGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toDateTimePicker
            // 
            this.toDateTimePicker.Location = new System.Drawing.Point(355, 21);
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
            this.label3.Location = new System.Drawing.Point(324, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 18);
            this.label3.TabIndex = 12;
            this.label3.Text = "по";
            // 
            // fromDateTimePicker
            // 
            this.fromDateTimePicker.Location = new System.Drawing.Point(156, 19);
            this.fromDateTimePicker.Name = "fromDateTimePicker";
            this.fromDateTimePicker.Size = new System.Drawing.Size(159, 22);
            this.fromDateTimePicker.TabIndex = 11;
            this.fromDateTimePicker.Value = new System.DateTime(2018, 2, 8, 0, 0, 0, 0);
            // 
            // rawComboBox
            // 
            this.rawComboBox.DataSource = this.rawBindingSource;
            this.rawComboBox.DisplayMember = "name_raw";
            this.rawComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rawComboBox.FormattingEnabled = true;
            this.rawComboBox.Location = new System.Drawing.Point(156, 49);
            this.rawComboBox.Name = "rawComboBox";
            this.rawComboBox.Size = new System.Drawing.Size(159, 24);
            this.rawComboBox.TabIndex = 8;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.Location = new System.Drawing.Point(106, 132);
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
            this.addButton.Location = new System.Drawing.Point(12, 132);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 28);
            this.addButton.TabIndex = 47;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // filtrGroupBox
            // 
            this.filtrGroupBox.Controls.Add(this.button1);
            this.filtrGroupBox.Controls.Add(this.toDateTimePicker);
            this.filtrGroupBox.Controls.Add(this.rawComboBox);
            this.filtrGroupBox.Controls.Add(this.label3);
            this.filtrGroupBox.Controls.Add(this.fromDateTimePicker);
            this.filtrGroupBox.Controls.Add(this.comboBox1);
            this.filtrGroupBox.Controls.Add(this.contractorRadioButton);
            this.filtrGroupBox.Controls.Add(this.rawRadioButton);
            this.filtrGroupBox.Controls.Add(this.yearRadioButton);
            this.filtrGroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filtrGroupBox.Location = new System.Drawing.Point(12, 12);
            this.filtrGroupBox.Name = "filtrGroupBox";
            this.filtrGroupBox.Size = new System.Drawing.Size(891, 114);
            this.filtrGroupBox.TabIndex = 59;
            this.filtrGroupBox.TabStop = false;
            this.filtrGroupBox.Text = "Фильтрация";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(327, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(82, 28);
            this.button1.TabIndex = 11;
            this.button1.Text = "Найти";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.contractorBindingSource;
            this.comboBox1.DisplayMember = "name_contr";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(156, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(159, 24);
            this.comboBox1.TabIndex = 8;
            // 
            // contractorRadioButton
            // 
            this.contractorRadioButton.AutoSize = true;
            this.contractorRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.contractorRadioButton.Location = new System.Drawing.Point(6, 80);
            this.contractorRadioButton.Name = "contractorRadioButton";
            this.contractorRadioButton.Size = new System.Drawing.Size(143, 22);
            this.contractorRadioButton.TabIndex = 2;
            this.contractorRadioButton.Text = "по контрагентам";
            this.contractorRadioButton.UseVisualStyleBackColor = true;
            // 
            // rawRadioButton
            // 
            this.rawRadioButton.AutoSize = true;
            this.rawRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.rawRadioButton.Location = new System.Drawing.Point(7, 49);
            this.rawRadioButton.Name = "rawRadioButton";
            this.rawRadioButton.Size = new System.Drawing.Size(93, 22);
            this.rawRadioButton.TabIndex = 1;
            this.rawRadioButton.Text = "по сырью";
            this.rawRadioButton.UseVisualStyleBackColor = true;
            // 
            // yearRadioButton
            // 
            this.yearRadioButton.AutoSize = true;
            this.yearRadioButton.Checked = true;
            this.yearRadioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.yearRadioButton.Location = new System.Drawing.Point(7, 20);
            this.yearRadioButton.Name = "yearRadioButton";
            this.yearRadioButton.Size = new System.Drawing.Size(91, 22);
            this.yearRadioButton.TabIndex = 0;
            this.yearRadioButton.TabStop = true;
            this.yearRadioButton.Text = "по дате с";
            this.yearRadioButton.UseVisualStyleBackColor = true;
            // 
            // dataGridViewDelivery
            // 
            this.dataGridViewDelivery.AllowUserToAddRows = false;
            this.dataGridViewDelivery.AllowUserToDeleteRows = false;
            this.dataGridViewDelivery.AllowUserToResizeRows = false;
            this.dataGridViewDelivery.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewDelivery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewDelivery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewDelivery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewDelivery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDelivery.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column9,
            this.Column10,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column8,
            this.Column7,
            this.Column6});
            this.dataGridViewDelivery.EnableHeadersVisualStyles = false;
            this.dataGridViewDelivery.Location = new System.Drawing.Point(12, 166);
            this.dataGridViewDelivery.MultiSelect = false;
            this.dataGridViewDelivery.Name = "dataGridViewDelivery";
            this.dataGridViewDelivery.ReadOnly = true;
            this.dataGridViewDelivery.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewDelivery.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewDelivery.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewDelivery.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewDelivery.Size = new System.Drawing.Size(891, 239);
            this.dataGridViewDelivery.TabIndex = 62;
            // 
            // accountOfGrainDataSet
            // 
            this.accountOfGrainDataSet.DataSetName = "AccountOfGrainDataSet";
            this.accountOfGrainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawBindingSource
            // 
            this.rawBindingSource.DataMember = "Raw";
            this.rawBindingSource.DataSource = this.accountOfGrainDataSet;
            // 
            // rawTableAdapter
            // 
            this.rawTableAdapter.ClearBeforeFill = true;
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataMember = "Contractor";
            this.contractorBindingSource.DataSource = this.accountOfGrainDataSet;
            // 
            // contractorTableAdapter
            // 
            this.contractorTableAdapter.ClearBeforeFill = true;
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
            // Column9
            // 
            this.Column9.HeaderText = "Тип сырья";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Подтип сырья";
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Дата";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Год урожая";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Транспорт";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Брутто";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Нетто";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Тара";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // DeliveryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(915, 417);
            this.Controls.Add(this.dataGridViewDelivery);
            this.Controls.Add(this.filtrGroupBox);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Name = "DeliveryForm";
            this.Text = "Поставки";
            this.Load += new System.EventHandler(this.DeliveryForm_Load);
            this.filtrGroupBox.ResumeLayout(false);
            this.filtrGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDelivery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox rawComboBox;
        private System.Windows.Forms.DateTimePicker toDateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker fromDateTimePicker;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox filtrGroupBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RadioButton contractorRadioButton;
        private System.Windows.Forms.RadioButton rawRadioButton;
        private System.Windows.Forms.RadioButton yearRadioButton;
        private System.Windows.Forms.DataGridView dataGridViewDelivery;
        private AccountOfGrainDataSet accountOfGrainDataSet;
        private System.Windows.Forms.BindingSource rawBindingSource;
        private AccountOfGrainDataSetTableAdapters.RawTableAdapter rawTableAdapter;
        private System.Windows.Forms.BindingSource contractorBindingSource;
        private AccountOfGrainDataSetTableAdapters.ContractorTableAdapter contractorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
    }
}