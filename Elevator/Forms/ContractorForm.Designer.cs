namespace Elevator.Forms
{
    partial class ContractorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ContractorForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.nameContractortextBox = new System.Windows.Forms.TextBox();
            this.btnAllList = new System.Windows.Forms.Button();
            this.lbName = new System.Windows.Forms.Label();
            this.findButton = new System.Windows.Forms.Button();
            this.dataGridViewContractor = new System.Windows.Forms.DataGridView();
            this.bindingSourceContractor = new System.Windows.Forms.BindingSource(this.components);
            this.addButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.accountOfGrainDataSet1 = new Elevator.AccountOfGrainDataSet();
            this.contractorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contractorTableAdapter1 = new Elevator.AccountOfGrainDataSetTableAdapters.ContractorTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContractor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nameContractortextBox);
            this.groupBox1.Controls.Add(this.btnAllList);
            this.groupBox1.Controls.Add(this.lbName);
            this.groupBox1.Controls.Add(this.findButton);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(824, 68);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // nameContractortextBox
            // 
            this.nameContractortextBox.Location = new System.Drawing.Point(130, 27);
            this.nameContractortextBox.Name = "nameContractortextBox";
            this.nameContractortextBox.Size = new System.Drawing.Size(282, 22);
            this.nameContractortextBox.TabIndex = 48;
            // 
            // btnAllList
            // 
            this.btnAllList.BackColor = System.Drawing.Color.DarkOrange;
            this.btnAllList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAllList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAllList.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btnAllList.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAllList.Location = new System.Drawing.Point(525, 23);
            this.btnAllList.Name = "btnAllList";
            this.btnAllList.Size = new System.Drawing.Size(281, 28);
            this.btnAllList.TabIndex = 7;
            this.btnAllList.Text = "Вывести полный список";
            this.btnAllList.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAllList.UseVisualStyleBackColor = false;
            this.btnAllList.Click += new System.EventHandler(this.btnAllList_Click);
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbName.ForeColor = System.Drawing.Color.Black;
            this.lbName.Location = new System.Drawing.Point(9, 27);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(115, 18);
            this.lbName.TabIndex = 6;
            this.lbName.Text = "Наименование:";
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
            this.findButton.Click += new System.EventHandler(this.findButton_Click);
            // 
            // dataGridViewContractor
            // 
            this.dataGridViewContractor.AllowUserToAddRows = false;
            this.dataGridViewContractor.AllowUserToDeleteRows = false;
            this.dataGridViewContractor.AutoGenerateColumns = false;
            this.dataGridViewContractor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewContractor.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewContractor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewContractor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewContractor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewContractor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.dataGridViewContractor.DataSource = this.contractorBindingSource;
            this.dataGridViewContractor.EnableHeadersVisualStyles = false;
            this.dataGridViewContractor.Location = new System.Drawing.Point(12, 137);
            this.dataGridViewContractor.MultiSelect = false;
            this.dataGridViewContractor.Name = "dataGridViewContractor";
            this.dataGridViewContractor.ReadOnly = true;
            this.dataGridViewContractor.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewContractor.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewContractor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewContractor.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewContractor.Size = new System.Drawing.Size(824, 230);
            this.dataGridViewContractor.TabIndex = 43;
            // 
            // bindingSourceContractor
            // 
            this.bindingSourceContractor.DataSource = this.accountOfGrainDataSet1;
            this.bindingSourceContractor.Position = 0;
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
            this.addButton.TabIndex = 45;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
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
            this.changeButton.TabIndex = 46;
            this.changeButton.Text = "Изменить";
            this.changeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
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
            this.deleteButton.TabIndex = 47;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // accountOfGrainDataSet1
            // 
            this.accountOfGrainDataSet1.DataSetName = "AccountOfGrainDataSet";
            this.accountOfGrainDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contractorBindingSource
            // 
            this.contractorBindingSource.DataMember = "Contractor";
            this.contractorBindingSource.DataSource = this.bindingSourceContractor;
            // 
            // contractorTableAdapter1
            // 
            this.contractorTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_contractor";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_contractor";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_contr";
            this.dataGridViewTextBoxColumn2.HeaderText = "name_contr";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "subdivision";
            this.dataGridViewTextBoxColumn3.HeaderText = "subdivision";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "jur_address";
            this.dataGridViewTextBoxColumn4.HeaderText = "jur_address";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "fact_address";
            this.dataGridViewTextBoxColumn5.HeaderText = "fact_address";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "mail_index";
            this.dataGridViewTextBoxColumn6.HeaderText = "mail_index";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "phone";
            this.dataGridViewTextBoxColumn7.HeaderText = "phone";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "inn";
            this.dataGridViewTextBoxColumn8.HeaderText = "inn";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // ContractorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(848, 379);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.dataGridViewContractor);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ContractorForm";
            this.Text = "Контрагенты";
            this.Load += new System.EventHandler(this.ContractorForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSourceContractor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contractorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnAllList;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.Button findButton;
        private System.Windows.Forms.DataGridView dataGridViewContractor;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox nameContractortextBox;
        private System.Windows.Forms.BindingSource bindingSourceContractor;
        private AccountOfGrainDataSet accountOfGrainDataSet;
        private AccountOfGrainDataSetTableAdapters.ContractorTableAdapter contractorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontractorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namecontrDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subdivisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn juraddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn factaddressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mailindexDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn innDataGridViewTextBoxColumn;
        private AccountOfGrainDataSet accountOfGrainDataSet1;
        private System.Windows.Forms.BindingSource contractorBindingSource;
        private AccountOfGrainDataSetTableAdapters.ContractorTableAdapter contractorTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}