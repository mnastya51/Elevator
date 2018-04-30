﻿namespace Elevator.AddAndEditForms
{
    partial class AddDryForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBoxWeightBefore = new System.Windows.Forms.TextBox();
            this.textBoxWeightAfter = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxWetBefore = new System.Windows.Forms.TextBox();
            this.textBoxWetAfter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(10, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 58;
            this.label1.Text = "Дата:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(163, 11);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(137, 20);
            this.dateTimePicker.TabIndex = 59;
            // 
            // textBoxWeightBefore
            // 
            this.textBoxWeightBefore.Location = new System.Drawing.Point(163, 49);
            this.textBoxWeightBefore.Name = "textBoxWeightBefore";
            this.textBoxWeightBefore.Size = new System.Drawing.Size(137, 20);
            this.textBoxWeightBefore.TabIndex = 60;
            this.textBoxWeightBefore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeightUp_KeyPress);
            // 
            // textBoxWeightAfter
            // 
            this.textBoxWeightAfter.BackColor = System.Drawing.Color.LightBlue;
            this.textBoxWeightAfter.Location = new System.Drawing.Point(163, 86);
            this.textBoxWeightAfter.Name = "textBoxWeightAfter";
            this.textBoxWeightAfter.Size = new System.Drawing.Size(137, 20);
            this.textBoxWeightAfter.TabIndex = 61;
            this.textBoxWeightAfter.TextChanged += new System.EventHandler(this.textBoxWeightAfter_TextChanged);
            this.textBoxWeightAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxWeightAfter_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(10, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 62;
            this.label2.Text = "Вес до:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(10, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 20);
            this.label3.TabIndex = 63;
            this.label3.Text = "Вес после:";
            // 
            // textBoxWetBefore
            // 
            this.textBoxWetBefore.Location = new System.Drawing.Point(163, 126);
            this.textBoxWetBefore.Name = "textBoxWetBefore";
            this.textBoxWetBefore.Size = new System.Drawing.Size(137, 20);
            this.textBoxWetBefore.TabIndex = 64;
            this.textBoxWetBefore.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHumidityUp_KeyPress);
            // 
            // textBoxWetAfter
            // 
            this.textBoxWetAfter.Location = new System.Drawing.Point(163, 160);
            this.textBoxWetAfter.Name = "textBoxWetAfter";
            this.textBoxWetAfter.Size = new System.Drawing.Size(137, 20);
            this.textBoxWetAfter.TabIndex = 65;
            this.textBoxWetAfter.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxHumidityAfter_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(10, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 20);
            this.label4.TabIndex = 66;
            this.label4.Text = "Влажность до:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(10, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 20);
            this.label5.TabIndex = 67;
            this.label5.Text = "Влажность после:";
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.LightBlue;
            this.saveButton.Enabled = false;
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.saveButton.ForeColor = System.Drawing.SystemColors.Desktop;
            this.saveButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.saveButton.Location = new System.Drawing.Point(105, 201);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(92, 34);
            this.saveButton.TabIndex = 68;
            this.saveButton.Text = "Сохранить";
            this.saveButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // AddDryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(316, 249);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxWetAfter);
            this.Controls.Add(this.textBoxWetBefore);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxWeightAfter);
            this.Controls.Add(this.textBoxWeightBefore);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label1);
            this.Name = "AddDryForm";
            this.Text = "Добавление сырья на сушку";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.TextBox textBoxWeightBefore;
        private System.Windows.Forms.TextBox textBoxWeightAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxWetBefore;
        private System.Windows.Forms.TextBox textBoxWetAfter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButton;
    }
}