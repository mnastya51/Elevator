namespace Elevator.AddForms
{
    partial class AddNoteForm
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
            this.fieldLabel = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.valueTextBox = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // fieldLabel
            // 
            this.fieldLabel.AutoSize = true;
            this.fieldLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fieldLabel.Location = new System.Drawing.Point(9, 12);
            this.fieldLabel.Name = "fieldLabel";
            this.fieldLabel.Size = new System.Drawing.Size(0, 20);
            this.fieldLabel.TabIndex = 60;
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.DarkOrange;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(75, 49);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 69;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // valueTextBox
            // 
            this.valueTextBox.Location = new System.Drawing.Point(120, 12);
            this.valueTextBox.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.valueTextBox.Name = "valueTextBox";
            this.valueTextBox.Size = new System.Drawing.Size(120, 20);
            this.valueTextBox.TabIndex = 70;
            this.valueTextBox.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // AddNoteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(252, 95);
            this.Controls.Add(this.valueTextBox);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.fieldLabel);
            this.Name = "AddNoteForm";
            this.Text = "Добавление";
            ((System.ComponentModel.ISupportInitialize)(this.valueTextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label fieldLabel;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.NumericUpDown valueTextBox;
    }
}