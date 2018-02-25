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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButtonRaw = new System.Windows.Forms.Button();
            this.changeButtonRaw = new System.Windows.Forms.Button();
            this.addButtonRaw = new System.Windows.Forms.Button();
            this.dataGridViewRaw = new System.Windows.Forms.DataGridView();
            this.idNameRawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namerawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbergostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.accountOfGrainDataSet = new Elevator.AccountOfGrainDataSet();
            this.groupBoxClass = new System.Windows.Forms.GroupBox();
            this.deleteButtonClass = new System.Windows.Forms.Button();
            this.addButtonClass = new System.Windows.Forms.Button();
            this.dataGridViewClass = new System.Windows.Forms.DataGridView();
            this.idclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNameRawDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.RawTableAdapter();
            this.classTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.ClassTableAdapter();
            this.groupBoxType = new System.Windows.Forms.GroupBox();
            this.deleteSubtypeButton = new System.Windows.Forms.Button();
            this.addSubtypeButton = new System.Windows.Forms.Button();
            this.dataGridViewSubtype = new System.Windows.Forms.DataGridView();
            this.idsubtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idtypeDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namesubtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtyperawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.deleteTypeButton = new System.Windows.Forms.Button();
            this.addTypeButton = new System.Windows.Forms.Button();
            this.dataGridViewType = new System.Windows.Forms.DataGridView();
            this.idtypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nametyperawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNameRawDataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typerawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.type_rawTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.Type_rawTableAdapter();
            this.subtype_rawTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.Subtype_rawTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).BeginInit();
            this.groupBoxClass.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.groupBoxType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtype)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtyperawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typerawBindingSource)).BeginInit();
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
            this.dataGridViewRaw.AllowUserToResizeRows = false;
            this.dataGridViewRaw.AutoGenerateColumns = false;
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
            this.idNameRawDataGridViewTextBoxColumn,
            this.namerawDataGridViewTextBoxColumn,
            this.numbergostDataGridViewTextBoxColumn});
            this.dataGridViewRaw.DataSource = this.rawBindingSource;
            this.dataGridViewRaw.EnableHeadersVisualStyles = false;
            this.dataGridViewRaw.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewRaw.MultiSelect = false;
            this.dataGridViewRaw.Name = "dataGridViewRaw";
            this.dataGridViewRaw.ReadOnly = true;
            this.dataGridViewRaw.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRaw.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRaw.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRaw.Size = new System.Drawing.Size(346, 200);
            this.dataGridViewRaw.TabIndex = 44;
            // 
            // idNameRawDataGridViewTextBoxColumn
            // 
            this.idNameRawDataGridViewTextBoxColumn.DataPropertyName = "id_NameRaw";
            this.idNameRawDataGridViewTextBoxColumn.HeaderText = "id_NameRaw";
            this.idNameRawDataGridViewTextBoxColumn.Name = "idNameRawDataGridViewTextBoxColumn";
            this.idNameRawDataGridViewTextBoxColumn.ReadOnly = true;
            this.idNameRawDataGridViewTextBoxColumn.Visible = false;
            // 
            // namerawDataGridViewTextBoxColumn
            // 
            this.namerawDataGridViewTextBoxColumn.DataPropertyName = "name_raw";
            this.namerawDataGridViewTextBoxColumn.HeaderText = "name_raw";
            this.namerawDataGridViewTextBoxColumn.Name = "namerawDataGridViewTextBoxColumn";
            this.namerawDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numbergostDataGridViewTextBoxColumn
            // 
            this.numbergostDataGridViewTextBoxColumn.DataPropertyName = "number_gost";
            this.numbergostDataGridViewTextBoxColumn.HeaderText = "number_gost";
            this.numbergostDataGridViewTextBoxColumn.Name = "numbergostDataGridViewTextBoxColumn";
            this.numbergostDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rawBindingSource
            // 
            this.rawBindingSource.DataMember = "Raw";
            this.rawBindingSource.DataSource = this.accountOfGrainDataSet;
            // 
            // accountOfGrainDataSet
            // 
            this.accountOfGrainDataSet.DataSetName = "AccountOfGrainDataSet";
            this.accountOfGrainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            this.deleteButtonClass.Click += new System.EventHandler(this.deleteButtonClass_Click);
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
            this.dataGridViewClass.AllowUserToResizeRows = false;
            this.dataGridViewClass.AutoGenerateColumns = false;
            this.dataGridViewClass.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClass.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewClass.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewClass.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewClass.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClass.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclassDataGridViewTextBoxColumn,
            this.idNameRawDataGridViewTextBoxColumn1,
            this.numberclassDataGridViewTextBoxColumn});
            this.dataGridViewClass.DataSource = this.classBindingSource;
            this.dataGridViewClass.EnableHeadersVisualStyles = false;
            this.dataGridViewClass.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewClass.MultiSelect = false;
            this.dataGridViewClass.Name = "dataGridViewClass";
            this.dataGridViewClass.ReadOnly = true;
            this.dataGridViewClass.RowHeadersVisible = false;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewClass.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewClass.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewClass.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClass.Size = new System.Drawing.Size(201, 200);
            this.dataGridViewClass.TabIndex = 44;
            // 
            // idclassDataGridViewTextBoxColumn
            // 
            this.idclassDataGridViewTextBoxColumn.DataPropertyName = "id_class";
            this.idclassDataGridViewTextBoxColumn.HeaderText = "id_class";
            this.idclassDataGridViewTextBoxColumn.Name = "idclassDataGridViewTextBoxColumn";
            this.idclassDataGridViewTextBoxColumn.ReadOnly = true;
            this.idclassDataGridViewTextBoxColumn.Visible = false;
            // 
            // idNameRawDataGridViewTextBoxColumn1
            // 
            this.idNameRawDataGridViewTextBoxColumn1.DataPropertyName = "id_NameRaw";
            this.idNameRawDataGridViewTextBoxColumn1.HeaderText = "id_NameRaw";
            this.idNameRawDataGridViewTextBoxColumn1.Name = "idNameRawDataGridViewTextBoxColumn1";
            this.idNameRawDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idNameRawDataGridViewTextBoxColumn1.Visible = false;
            // 
            // numberclassDataGridViewTextBoxColumn
            // 
            this.numberclassDataGridViewTextBoxColumn.DataPropertyName = "number_class";
            this.numberclassDataGridViewTextBoxColumn.HeaderText = "number_class";
            this.numberclassDataGridViewTextBoxColumn.Name = "numberclassDataGridViewTextBoxColumn";
            this.numberclassDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.accountOfGrainDataSet;
            // 
            // rawTableAdapter
            // 
            this.rawTableAdapter.ClearBeforeFill = true;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
            // 
            // groupBoxType
            // 
            this.groupBoxType.Controls.Add(this.deleteSubtypeButton);
            this.groupBoxType.Controls.Add(this.addSubtypeButton);
            this.groupBoxType.Controls.Add(this.dataGridViewSubtype);
            this.groupBoxType.Controls.Add(this.deleteTypeButton);
            this.groupBoxType.Controls.Add(this.addTypeButton);
            this.groupBoxType.Controls.Add(this.dataGridViewType);
            this.groupBoxType.Enabled = false;
            this.groupBoxType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBoxType.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBoxType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBoxType.Location = new System.Drawing.Point(12, 269);
            this.groupBoxType.Name = "groupBoxType";
            this.groupBoxType.Size = new System.Drawing.Size(577, 251);
            this.groupBoxType.TabIndex = 50;
            this.groupBoxType.TabStop = false;
            // 
            // deleteSubtypeButton
            // 
            this.deleteSubtypeButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteSubtypeButton.Enabled = false;
            this.deleteSubtypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteSubtypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteSubtypeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteSubtypeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteSubtypeButton.Location = new System.Drawing.Point(478, 10);
            this.deleteSubtypeButton.Name = "deleteSubtypeButton";
            this.deleteSubtypeButton.Size = new System.Drawing.Size(88, 28);
            this.deleteSubtypeButton.TabIndex = 51;
            this.deleteSubtypeButton.Text = "Удалить";
            this.deleteSubtypeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteSubtypeButton.UseVisualStyleBackColor = false;
            this.deleteSubtypeButton.Click += new System.EventHandler(this.deleteSubtypeButton_Click);
            // 
            // addSubtypeButton
            // 
            this.addSubtypeButton.BackColor = System.Drawing.Color.LightGray;
            this.addSubtypeButton.Enabled = false;
            this.addSubtypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addSubtypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addSubtypeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addSubtypeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addSubtypeButton.Location = new System.Drawing.Point(384, 10);
            this.addSubtypeButton.Name = "addSubtypeButton";
            this.addSubtypeButton.Size = new System.Drawing.Size(88, 28);
            this.addSubtypeButton.TabIndex = 50;
            this.addSubtypeButton.Text = "Добавить";
            this.addSubtypeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addSubtypeButton.UseVisualStyleBackColor = false;
            this.addSubtypeButton.Click += new System.EventHandler(this.addSubtypeButton_Click);
            // 
            // dataGridViewSubtype
            // 
            this.dataGridViewSubtype.AllowUserToAddRows = false;
            this.dataGridViewSubtype.AllowUserToDeleteRows = false;
            this.dataGridViewSubtype.AllowUserToResizeRows = false;
            this.dataGridViewSubtype.AutoGenerateColumns = false;
            this.dataGridViewSubtype.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewSubtype.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewSubtype.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewSubtype.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewSubtype.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewSubtype.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idsubtypeDataGridViewTextBoxColumn,
            this.idtypeDataGridViewTextBoxColumn1,
            this.namesubtypeDataGridViewTextBoxColumn});
            this.dataGridViewSubtype.DataSource = this.subtyperawBindingSource;
            this.dataGridViewSubtype.EnableHeadersVisualStyles = false;
            this.dataGridViewSubtype.Location = new System.Drawing.Point(370, 45);
            this.dataGridViewSubtype.MultiSelect = false;
            this.dataGridViewSubtype.Name = "dataGridViewSubtype";
            this.dataGridViewSubtype.ReadOnly = true;
            this.dataGridViewSubtype.RowHeadersVisible = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewSubtype.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewSubtype.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewSubtype.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewSubtype.Size = new System.Drawing.Size(201, 200);
            this.dataGridViewSubtype.TabIndex = 49;
            // 
            // idsubtypeDataGridViewTextBoxColumn
            // 
            this.idsubtypeDataGridViewTextBoxColumn.DataPropertyName = "id_subtype";
            this.idsubtypeDataGridViewTextBoxColumn.HeaderText = "id_subtype";
            this.idsubtypeDataGridViewTextBoxColumn.Name = "idsubtypeDataGridViewTextBoxColumn";
            this.idsubtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idsubtypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // idtypeDataGridViewTextBoxColumn1
            // 
            this.idtypeDataGridViewTextBoxColumn1.DataPropertyName = "id_type";
            this.idtypeDataGridViewTextBoxColumn1.HeaderText = "id_type";
            this.idtypeDataGridViewTextBoxColumn1.Name = "idtypeDataGridViewTextBoxColumn1";
            this.idtypeDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idtypeDataGridViewTextBoxColumn1.Visible = false;
            // 
            // namesubtypeDataGridViewTextBoxColumn
            // 
            this.namesubtypeDataGridViewTextBoxColumn.DataPropertyName = "name_subtype";
            this.namesubtypeDataGridViewTextBoxColumn.HeaderText = "name_subtype";
            this.namesubtypeDataGridViewTextBoxColumn.Name = "namesubtypeDataGridViewTextBoxColumn";
            this.namesubtypeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // subtyperawBindingSource
            // 
            this.subtyperawBindingSource.DataMember = "Subtype_raw";
            this.subtyperawBindingSource.DataSource = this.accountOfGrainDataSet;
            // 
            // deleteTypeButton
            // 
            this.deleteTypeButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteTypeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteTypeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteTypeButton.Location = new System.Drawing.Point(114, 10);
            this.deleteTypeButton.Name = "deleteTypeButton";
            this.deleteTypeButton.Size = new System.Drawing.Size(88, 28);
            this.deleteTypeButton.TabIndex = 48;
            this.deleteTypeButton.Text = "Удалить";
            this.deleteTypeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteTypeButton.UseVisualStyleBackColor = false;
            this.deleteTypeButton.Click += new System.EventHandler(this.deleteTypeButton_Click);
            // 
            // addTypeButton
            // 
            this.addTypeButton.BackColor = System.Drawing.Color.LightGray;
            this.addTypeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTypeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addTypeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addTypeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addTypeButton.Location = new System.Drawing.Point(20, 10);
            this.addTypeButton.Name = "addTypeButton";
            this.addTypeButton.Size = new System.Drawing.Size(88, 28);
            this.addTypeButton.TabIndex = 46;
            this.addTypeButton.Text = "Добавить";
            this.addTypeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addTypeButton.UseVisualStyleBackColor = false;
            this.addTypeButton.Click += new System.EventHandler(this.addTypeButton_Click);
            // 
            // dataGridViewType
            // 
            this.dataGridViewType.AllowUserToAddRows = false;
            this.dataGridViewType.AllowUserToDeleteRows = false;
            this.dataGridViewType.AllowUserToResizeRows = false;
            this.dataGridViewType.AutoGenerateColumns = false;
            this.dataGridViewType.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewType.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewType.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewType.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewType.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewType.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idtypeDataGridViewTextBoxColumn,
            this.nametyperawDataGridViewTextBoxColumn,
            this.idNameRawDataGridViewTextBoxColumn2});
            this.dataGridViewType.DataSource = this.typerawBindingSource;
            this.dataGridViewType.EnableHeadersVisualStyles = false;
            this.dataGridViewType.Location = new System.Drawing.Point(6, 45);
            this.dataGridViewType.MultiSelect = false;
            this.dataGridViewType.Name = "dataGridViewType";
            this.dataGridViewType.ReadOnly = true;
            this.dataGridViewType.RowHeadersVisible = false;
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewType.RowsDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridViewType.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewType.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewType.Size = new System.Drawing.Size(201, 200);
            this.dataGridViewType.TabIndex = 44;
            // 
            // idtypeDataGridViewTextBoxColumn
            // 
            this.idtypeDataGridViewTextBoxColumn.DataPropertyName = "id_type";
            this.idtypeDataGridViewTextBoxColumn.HeaderText = "id_type";
            this.idtypeDataGridViewTextBoxColumn.Name = "idtypeDataGridViewTextBoxColumn";
            this.idtypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.idtypeDataGridViewTextBoxColumn.Visible = false;
            // 
            // nametyperawDataGridViewTextBoxColumn
            // 
            this.nametyperawDataGridViewTextBoxColumn.DataPropertyName = "name_type_raw";
            this.nametyperawDataGridViewTextBoxColumn.HeaderText = "name_type_raw";
            this.nametyperawDataGridViewTextBoxColumn.Name = "nametyperawDataGridViewTextBoxColumn";
            this.nametyperawDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idNameRawDataGridViewTextBoxColumn2
            // 
            this.idNameRawDataGridViewTextBoxColumn2.DataPropertyName = "id_NameRaw";
            this.idNameRawDataGridViewTextBoxColumn2.HeaderText = "id_NameRaw";
            this.idNameRawDataGridViewTextBoxColumn2.Name = "idNameRawDataGridViewTextBoxColumn2";
            this.idNameRawDataGridViewTextBoxColumn2.ReadOnly = true;
            this.idNameRawDataGridViewTextBoxColumn2.Visible = false;
            // 
            // typerawBindingSource
            // 
            this.typerawBindingSource.DataMember = "Type_raw";
            this.typerawBindingSource.DataSource = this.accountOfGrainDataSet;
            // 
            // type_rawTableAdapter
            // 
            this.type_rawTableAdapter.ClearBeforeFill = true;
            // 
            // subtype_rawTableAdapter
            // 
            this.subtype_rawTableAdapter.ClearBeforeFill = true;
            // 
            // RawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(621, 535);
            this.Controls.Add(this.groupBoxType);
            this.Controls.Add(this.groupBoxClass);
            this.Controls.Add(this.groupBox1);
            this.Name = "RawForm";
            this.Text = "Сырье";
            this.Load += new System.EventHandler(this.RawForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).EndInit();
            this.groupBoxClass.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClass)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.groupBoxType.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewSubtype)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subtyperawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typerawBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRaw;
        private System.Windows.Forms.Button addButtonRaw;
        private System.Windows.Forms.Button changeButtonRaw;
        private System.Windows.Forms.Button deleteButtonRaw;
        private System.Windows.Forms.GroupBox groupBoxClass;
        private System.Windows.Forms.Button deleteButtonClass;
        private System.Windows.Forms.Button addButtonClass;
        private System.Windows.Forms.DataGridView dataGridViewClass;
        private AccountOfGrainDataSet accountOfGrainDataSet;
        private System.Windows.Forms.BindingSource rawBindingSource;
        private AccountOfGrainDataSetTableAdapters.RawTableAdapter rawTableAdapter;
        private System.Windows.Forms.BindingSource classBindingSource;
        private AccountOfGrainDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.GroupBox groupBoxType;
        private System.Windows.Forms.Button deleteTypeButton;
        private System.Windows.Forms.Button addTypeButton;
        private System.Windows.Forms.DataGridView dataGridViewType;
        private System.Windows.Forms.BindingSource typerawBindingSource;
        private AccountOfGrainDataSetTableAdapters.Type_rawTableAdapter type_rawTableAdapter;
        private System.Windows.Forms.Button deleteSubtypeButton;
        private System.Windows.Forms.Button addSubtypeButton;
        private System.Windows.Forms.DataGridView dataGridViewSubtype;
        private System.Windows.Forms.BindingSource subtyperawBindingSource;
        private AccountOfGrainDataSetTableAdapters.Subtype_rawTableAdapter subtype_rawTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameRawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namerawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbergostDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameRawDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idsubtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtypeDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn namesubtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idtypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nametyperawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameRawDataGridViewTextBoxColumn2;
    }
}