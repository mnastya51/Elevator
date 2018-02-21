namespace Elevator.Forms
{
    partial class RawForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButtonRaw = new System.Windows.Forms.Button();
            this.changeButtonRaw = new System.Windows.Forms.Button();
            this.addButtonRaw = new System.Windows.Forms.Button();
            this.dataGridViewRaw = new System.Windows.Forms.DataGridView();
            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.deleteButtonClass = new System.Windows.Forms.Button();
            this.addButtonClass = new System.Windows.Forms.Button();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.accountOfGrainDataSet2 = new Elevator.AccountOfGrainDataSet();
            this.rawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawTableAdapter1 = new Elevator.AccountOfGrainDataSetTableAdapters.RawTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter1 = new Elevator.AccountOfGrainDataSetTableAdapters.ClassTableAdapter();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).BeginInit();
            this.groupBoxClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButtonRaw);
            this.groupBox1.Controls.Add(this.changeButtonRaw);
            this.groupBox1.Controls.Add(this.addButtonRaw);
            this.groupBox1.Controls.Add(this.dataGridViewRaw);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(358, 251);
            this.groupBox1.TabIndex = 43;
            this.groupBox1.TabStop = false;
            // 
            // deleteButtonRaw
            // 
            this.deleteButtonRaw.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteButtonRaw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButtonRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButtonRaw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButtonRaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButtonRaw.Location = new System.Drawing.Point(226, 10);
            this.deleteButtonRaw.Name = "deleteButtonRaw";
            this.deleteButtonRaw.Size = new System.Drawing.Size(88, 28);
            this.deleteButtonRaw.TabIndex = 48;
            this.deleteButtonRaw.Text = "Удалить";
            this.deleteButtonRaw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButtonRaw.UseVisualStyleBackColor = false;
            this.deleteButtonRaw.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButtonRaw
            // 
            this.changeButtonRaw.BackColor = System.Drawing.Color.DarkOrange;
            this.changeButtonRaw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButtonRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButtonRaw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeButtonRaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButtonRaw.Location = new System.Drawing.Point(132, 10);
            this.changeButtonRaw.Name = "changeButtonRaw";
            this.changeButtonRaw.Size = new System.Drawing.Size(88, 28);
            this.changeButtonRaw.TabIndex = 47;
            this.changeButtonRaw.Text = "Изменить";
            this.changeButtonRaw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButtonRaw.UseVisualStyleBackColor = false;
            this.changeButtonRaw.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButtonRaw
            // 
            this.addButtonRaw.BackColor = System.Drawing.Color.DarkOrange;
            this.addButtonRaw.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButtonRaw.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButtonRaw.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButtonRaw.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButtonRaw.Location = new System.Drawing.Point(38, 11);
            this.addButtonRaw.Name = "addButtonRaw";
            this.addButtonRaw.Size = new System.Drawing.Size(88, 28);
            this.addButtonRaw.TabIndex = 46;
            this.addButtonRaw.Text = "Добавить";
            this.addButtonRaw.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButtonRaw.UseVisualStyleBackColor = false;
            this.addButtonRaw.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridViewRaw
            // 
            this.dataGridViewRaw.AllowUserToAddRows = false;
            this.dataGridViewRaw.AllowUserToDeleteRows = false;
            this.dataGridViewRaw.AutoGenerateColumns = false;
            this.dataGridViewRaw.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewRaw.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewRaw.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewRaw.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dataGridViewRaw.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRaw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dataGridViewRaw.DataSource = this.rawBindingSource;
            this.dataGridViewRaw.EnableHeadersVisualStyles = false;
            this.dataGridViewRaw.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewRaw.MultiSelect = false;
            this.dataGridViewRaw.Name = "dataGridViewRaw";
            this.dataGridViewRaw.ReadOnly = true;
            this.dataGridViewRaw.RowHeadersVisible = false;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRaw.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dataGridViewRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRaw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRaw.Size = new System.Drawing.Size(346, 200);
            this.dataGridViewRaw.TabIndex = 44;
            // 
            // groupBoxClass
            // 
            this.groupBoxClass.Controls.Add(this.deleteButtonClass);
            this.groupBoxClass.Controls.Add(this.addButtonClass);
            this.groupBoxClass.Controls.Add(this.dataGridViewClass);
            this.groupBoxClass.Enabled = false;
            this.groupBoxClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxClass.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxClass.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxClass.Location = new System.Drawing.Point(376, 12);
            this.groupBoxClass.Name = "groupBoxClass";
            this.groupBoxClass.Size = new System.Drawing.Size(213, 251);
            this.groupBoxClass.TabIndex = 49;
            this.groupBoxClass.TabStop = false;
            // 
            // deleteButtonClass
            // 
            this.deleteButtonClass.BackColor = System.Drawing.Color.LightGray;
            this.deleteButtonClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButtonClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButtonClass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButtonClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButtonClass.Location = new System.Drawing.Point(114, 10);
            this.deleteButtonClass.Name = "deleteButtonClass";
            this.deleteButtonClass.Size = new System.Drawing.Size(88, 28);
            this.deleteButtonClass.TabIndex = 48;
            this.deleteButtonClass.Text = "Удалить";
            this.deleteButtonClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButtonClass.UseVisualStyleBackColor = false;
            // 
            // addButtonClass
            // 
            this.addButtonClass.BackColor = System.Drawing.Color.LightGray;
            this.addButtonClass.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButtonClass.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButtonClass.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButtonClass.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButtonClass.Location = new System.Drawing.Point(20, 10);
            this.addButtonClass.Name = "addButtonClass";
            this.addButtonClass.Size = new System.Drawing.Size(88, 28);
            this.addButtonClass.TabIndex = 46;
            this.addButtonClass.Text = "Добавить";
            this.addButtonClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButtonClass.UseVisualStyleBackColor = false;
            this.addButtonClass.Click += new System.EventHandler(this.addButtonClass_Click);
            // 
            // dataGridViewClass
            // 
            this.dataGridViewClass.AllowUserToAddRows = false;
            this.dataGridViewClass.AllowUserToDeleteRows = false;
            this.dataGridViewClass.AutoGenerateColumns = false;
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle19;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.dataGridViewClass.DataSource = this.classBindingSource;
            this.dataGridViewClass.EnableHeadersVisualStyles = false;
            this.dataGridViewClass.Location = new System.Drawing.Point(34, 45);
            this.dataGridViewClass.MultiSelect = false;
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.RowHeadersVisible = false;
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClass.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dataGridViewClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClass.Size = new System.Drawing.Size(145, 200);
            this.dataGridViewClass.TabIndex = 44;
            // 
            // accountOfGrainDataSet2
            // 
            this.accountOfGrainDataSet2.DataSetName = "AccountOfGrainDataSet";
            this.accountOfGrainDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rawBindingSource
            // 
            this.rawBindingSource.DataMember = "Raw";
            this.rawBindingSource.DataSource = this.accountOfGrainDataSet2;
            // 
            // rawTableAdapter1
            // 
            this.rawTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id_NameRaw";
            this.dataGridViewTextBoxColumn1.HeaderText = "id_NameRaw";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "name_raw";
            this.dataGridViewTextBoxColumn2.HeaderText = "name_raw";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "number_gost";
            this.dataGridViewTextBoxColumn3.HeaderText = "number_gost";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.accountOfGrainDataSet2;
            // 
            // classTableAdapter1
            // 
            this.classTableAdapter1.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "id_class";
            this.dataGridViewTextBoxColumn4.HeaderText = "id_class";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "id_NameRaw";
            this.dataGridViewTextBoxColumn5.HeaderText = "id_NameRaw";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Visible = false;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "number_class";
            this.dataGridViewTextBoxColumn6.HeaderText = "number_class";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // RawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(621, 411);
            this.Controls.Add(this.groupBoxClass);
            this.Controls.Add(this.groupBox1);
            this.Name = "RawForm";
            this.Text = "Сырье";
            this.Load += new System.EventHandler(this.RawForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).EndInit();
            this.groupBoxClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRaw;
        private System.Windows.Forms.Button addButtonRaw;
        private System.Windows.Forms.Button changeButtonRaw;
        private System.Windows.Forms.Button deleteButtonRaw;
        private AccountOfGrainDataSet accountOfGrainDataSet;
        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.Button deleteButtonClass;
        private System.Windows.Forms.Button addButtonClass;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private AccountOfGrainDataSet accountOfGrainDataSet1;
        private AccountOfGrainDataSetTableAdapters.RawTableAdapter rawTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameRawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namerawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbergostDataGridViewTextBoxColumn;
        private AccountOfGrainDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameRawDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberclassDataGridViewTextBoxColumn;
        private AccountOfGrainDataSet accountOfGrainDataSet2;
        private System.Windows.Forms.BindingSource rawBindingSource;
        private AccountOfGrainDataSetTableAdapters.RawTableAdapter rawTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource classBindingSource;
        private AccountOfGrainDataSetTableAdapters.ClassTableAdapter classTableAdapter1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
    }
}