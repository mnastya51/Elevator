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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.dataGridViewRaw = new System.Windows.Forms.DataGridView();
            this.accountOfGrainDataSet = new Elevator.AccountOfGrainDataSet();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.RawTableAdapter();
            this.idNameRawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.namerawDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numbergostDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.classTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.ClassTableAdapter();
            this.idclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNameRawDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numberclassDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.deleteButton);
            this.groupBox1.Controls.Add(this.changeButton);
            this.groupBox1.Controls.Add(this.addButton);
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
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.DarkOrange;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(226, 10);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 28);
            this.deleteButton.TabIndex = 48;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.DarkOrange;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.Location = new System.Drawing.Point(132, 10);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 28);
            this.changeButton.TabIndex = 47;
            this.changeButton.Text = "Изменить";
            this.changeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButton.UseVisualStyleBackColor = false;
            this.changeButton.Click += new System.EventHandler(this.changeButton_Click);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.DarkOrange;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(38, 11);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 28);
            this.addButton.TabIndex = 46;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // dataGridViewRaw
            // 
            this.dataGridViewRaw.AllowUserToAddRows = false;
            this.dataGridViewRaw.AllowUserToDeleteRows = false;
            this.dataGridViewRaw.AutoGenerateColumns = false;
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
            this.dataGridViewRaw.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idNameRawDataGridViewTextBoxColumn,
            this.namerawDataGridViewTextBoxColumn,
            this.numbergostDataGridViewTextBoxColumn});
            this.dataGridViewRaw.DataSource = this.rawBindingSource;
            this.dataGridViewRaw.EnableHeadersVisualStyles = false;
            this.dataGridViewRaw.Location = new System.Drawing.Point(6, 44);
            this.dataGridViewRaw.Name = "dataGridViewRaw";
            this.dataGridViewRaw.ReadOnly = true;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewRaw.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewRaw.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewRaw.Size = new System.Drawing.Size(346, 200);
            this.dataGridViewRaw.TabIndex = 44;
            // 
            // accountOfGrainDataSet
            // 
            this.accountOfGrainDataSet.DataSetName = "AccountOfGrainDataSet";
            this.accountOfGrainDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.InfoText;
            this.groupBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.groupBox2.Location = new System.Drawing.Point(381, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(213, 251);
            this.groupBox2.TabIndex = 49;
            this.groupBox2.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOrange;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(114, 10);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 28);
            this.button1.TabIndex = 48;
            this.button1.Text = "Удалить";
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.DarkOrange;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.Location = new System.Drawing.Point(20, 10);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(88, 28);
            this.button3.TabIndex = 46;
            this.button3.Text = "Добавить";
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idclassDataGridViewTextBoxColumn,
            this.idNameRawDataGridViewTextBoxColumn1,
            this.numberclassDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.classBindingSource;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(34, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridView1.Size = new System.Drawing.Size(145, 200);
            this.dataGridView1.TabIndex = 44;
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
            // classBindingSource
            // 
            this.classBindingSource.DataMember = "Class";
            this.classBindingSource.DataSource = this.accountOfGrainDataSet;
            // 
            // classTableAdapter
            // 
            this.classTableAdapter.ClearBeforeFill = true;
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
            // RawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(621, 411);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "RawForm";
            this.Text = "Сырье";
            this.Load += new System.EventHandler(this.RawForm_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRaw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewRaw;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button deleteButton;
        private AccountOfGrainDataSet accountOfGrainDataSet;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource rawBindingSource;
        private AccountOfGrainDataSetTableAdapters.RawTableAdapter rawTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameRawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn namerawDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numbergostDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource classBindingSource;
        private AccountOfGrainDataSetTableAdapters.ClassTableAdapter classTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idclassDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNameRawDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numberclassDataGridViewTextBoxColumn;
    }
}