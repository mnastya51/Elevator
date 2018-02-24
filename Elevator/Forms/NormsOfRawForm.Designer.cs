namespace Elevator.Forms
{
    partial class NormsOfRawForm
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
            this.dataGridViewNorms = new System.Windows.Forms.DataGridView();
            this.Impurity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Norm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            this.changeButton = new System.Windows.Forms.Button();
            this.addButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.showButton = new System.Windows.Forms.Button();
            this.rawComboBox = new System.Windows.Forms.ComboBox();
            this.groupComboBox = new System.Windows.Forms.ComboBox();
            this.labelName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.accountOfGrainDataSet = new Elevator.AccountOfGrainDataSet();
            this.rawBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rawTableAdapter = new Elevator.AccountOfGrainDataSetTableAdapters.RawTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorms)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewNorms
            // 
            this.dataGridViewNorms.AllowUserToAddRows = false;
            this.dataGridViewNorms.AllowUserToDeleteRows = false;
            this.dataGridViewNorms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewNorms.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.dataGridViewNorms.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewNorms.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewNorms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewNorms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Impurity,
            this.Norm});
            this.dataGridViewNorms.EnableHeadersVisualStyles = false;
            this.dataGridViewNorms.Location = new System.Drawing.Point(12, 167);
            this.dataGridViewNorms.MultiSelect = false;
            this.dataGridViewNorms.Name = "dataGridViewNorms";
            this.dataGridViewNorms.ReadOnly = true;
            this.dataGridViewNorms.RowHeadersVisible = false;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            this.dataGridViewNorms.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewNorms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dataGridViewNorms.Size = new System.Drawing.Size(425, 113);
            this.dataGridViewNorms.TabIndex = 67;
            // 
            // Impurity
            // 
            this.Impurity.HeaderText = "Показатель";
            this.Impurity.Name = "Impurity";
            this.Impurity.ReadOnly = true;
            // 
            // Norm
            // 
            this.Norm.HeaderText = "Норма";
            this.Norm.Name = "Norm";
            this.Norm.ReadOnly = true;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.LightGray;
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.deleteButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.deleteButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deleteButton.Location = new System.Drawing.Point(202, 123);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(88, 28);
            this.deleteButton.TabIndex = 66;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.deleteButton.UseVisualStyleBackColor = false;
            // 
            // changeButton
            // 
            this.changeButton.BackColor = System.Drawing.Color.LightGray;
            this.changeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.changeButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.changeButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.changeButton.Location = new System.Drawing.Point(108, 123);
            this.changeButton.Name = "changeButton";
            this.changeButton.Size = new System.Drawing.Size(88, 28);
            this.changeButton.TabIndex = 65;
            this.changeButton.Text = "Изменить";
            this.changeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.changeButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.LightGray;
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.addButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.addButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addButton.Location = new System.Drawing.Point(12, 123);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(88, 28);
            this.addButton.TabIndex = 64;
            this.addButton.Text = "Добавить";
            this.addButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.addButton.UseVisualStyleBackColor = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.showButton);
            this.groupBox1.Controls.Add(this.rawComboBox);
            this.groupBox1.Controls.Add(this.groupComboBox);
            this.groupBox1.Controls.Add(this.labelName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 105);
            this.groupBox1.TabIndex = 63;
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
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // rawComboBox
            // 
            this.rawComboBox.DataSource = this.rawBindingSource;
            this.rawComboBox.DisplayMember = "name_raw";
            this.rawComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rawComboBox.FormattingEnabled = true;
            this.rawComboBox.Location = new System.Drawing.Point(137, 21);
            this.rawComboBox.Name = "rawComboBox";
            this.rawComboBox.Size = new System.Drawing.Size(162, 24);
            this.rawComboBox.TabIndex = 55;
            // 
            // groupComboBox
            // 
            this.groupComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.groupComboBox.FormattingEnabled = true;
            this.groupComboBox.Items.AddRange(new object[] {
            "Общие показатели",
            "Вредные примеси",
            "Сорные примеси",
            "Зерновые примеси"});
            this.groupComboBox.Location = new System.Drawing.Point(137, 61);
            this.groupComboBox.Name = "groupComboBox";
            this.groupComboBox.Size = new System.Drawing.Size(162, 24);
            this.groupComboBox.TabIndex = 57;
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
            // NormsOfRawForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(451, 332);
            this.Controls.Add(this.dataGridViewNorms);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.changeButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.groupBox1);
            this.Name = "NormsOfRawForm";
            this.Text = "Нормы сырья";
            this.Load += new System.EventHandler(this.NormsOfRawForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewNorms)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountOfGrainDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rawBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewNorms;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button changeButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.ComboBox rawComboBox;
        private System.Windows.Forms.ComboBox groupComboBox;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Impurity;
        private System.Windows.Forms.DataGridViewTextBoxColumn Norm;
        private AccountOfGrainDataSet accountOfGrainDataSet;
        private System.Windows.Forms.BindingSource rawBindingSource;
        private AccountOfGrainDataSetTableAdapters.RawTableAdapter rawTableAdapter;
    }
}