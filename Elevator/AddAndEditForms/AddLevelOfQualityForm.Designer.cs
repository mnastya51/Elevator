namespace Elevator.AddAndEditForms
{
    partial class AddLevelOfQualityForm
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
            this.saveButton = new System.Windows.Forms.Button();
            this.impurityLabel = new System.Windows.Forms.Label();
            this.textBoxImpurity = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(161, 48);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 72;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // impurityLabel
            // 
            this.impurityLabel.AutoSize = true;
            this.impurityLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.impurityLabel.Location = new System.Drawing.Point(12, 9);
            this.impurityLabel.Name = "impurityLabel";
            this.impurityLabel.Size = new System.Drawing.Size(111, 20);
            this.impurityLabel.TabIndex = 71;
            this.impurityLabel.Text = "Показатель*:";
            // 
            // textBoxImpurity
            // 
            this.textBoxImpurity.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxImpurity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBoxImpurity.Location = new System.Drawing.Point(124, 9);
            this.textBoxImpurity.MaxLength = 20;
            this.textBoxImpurity.Name = "textBoxImpurity";
            this.textBoxImpurity.Size = new System.Drawing.Size(269, 22);
            this.textBoxImpurity.TabIndex = 73;
            this.textBoxImpurity.TextChanged += new System.EventHandler(this.textBoxImpurity_TextChanged);
            this.textBoxImpurity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxImpurity_KeyPress);
            // 
            // AddLevelOfQualityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(405, 94);
            this.Controls.Add(this.textBoxImpurity);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.impurityLabel);
            this.Name = "AddLevelOfQualityForm";
            this.Text = "Добавление показателя качества";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label impurityLabel;
        private System.Windows.Forms.TextBox textBoxImpurity;
    }
}