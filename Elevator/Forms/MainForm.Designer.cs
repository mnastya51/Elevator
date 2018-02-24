namespace Elevator.Forms
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справочникиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rawToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.storageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.impurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сервисToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.договорыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.поставкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.анализКачестваToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.обработкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.хранениеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отгрузкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.карточкаАнализаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.прочиеОтчетыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сменитьПользователяToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.normsImpurityToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(137)))), ((int)(((byte)(79)))));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справочникиToolStripMenuItem,
            this.сервисToolStripMenuItem,
            this.отчетыToolStripMenuItem,
            this.сменитьПользователяToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(680, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справочникиToolStripMenuItem
            // 
            this.справочникиToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeToolStripMenuItem,
            this.contractorToolStripMenuItem,
            this.rawToolStripMenuItem,
            this.storageToolStripMenuItem,
            this.impurityToolStripMenuItem,
            this.normsImpurityToolStripMenuItem});
            this.справочникиToolStripMenuItem.Name = "справочникиToolStripMenuItem";
            this.справочникиToolStripMenuItem.Size = new System.Drawing.Size(94, 20);
            this.справочникиToolStripMenuItem.Text = "Справочники";
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.employeeToolStripMenuItem.Text = "Сотрудники";
            this.employeeToolStripMenuItem.Click += new System.EventHandler(this.employeeToolStripMenuItem_Click);
            // 
            // contractorToolStripMenuItem
            // 
            this.contractorToolStripMenuItem.Name = "contractorToolStripMenuItem";
            this.contractorToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.contractorToolStripMenuItem.Text = "Контрагенты";
            this.contractorToolStripMenuItem.Click += new System.EventHandler(this.contractorToolStripMenuItem_Click);
            // 
            // rawToolStripMenuItem
            // 
            this.rawToolStripMenuItem.Name = "rawToolStripMenuItem";
            this.rawToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.rawToolStripMenuItem.Text = "Сырье";
            this.rawToolStripMenuItem.Click += new System.EventHandler(this.rawToolStripMenuItem_Click);
            // 
            // storageToolStripMenuItem
            // 
            this.storageToolStripMenuItem.Name = "storageToolStripMenuItem";
            this.storageToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.storageToolStripMenuItem.Text = "Места хранения";
            this.storageToolStripMenuItem.Click += new System.EventHandler(this.storageToolStripMenuItem_Click);
            // 
            // impurityToolStripMenuItem
            // 
            this.impurityToolStripMenuItem.Name = "impurityToolStripMenuItem";
            this.impurityToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.impurityToolStripMenuItem.Text = "Показатели качества";
            this.impurityToolStripMenuItem.Click += new System.EventHandler(this.impurityToolStripMenuItem_Click);
            // 
            // сервисToolStripMenuItem
            // 
            this.сервисToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.договорыToolStripMenuItem,
            this.поставкаToolStripMenuItem,
            this.анализКачестваToolStripMenuItem,
            this.обработкаToolStripMenuItem,
            this.хранениеToolStripMenuItem,
            this.отгрузкаToolStripMenuItem});
            this.сервисToolStripMenuItem.Name = "сервисToolStripMenuItem";
            this.сервисToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.сервисToolStripMenuItem.Text = "Сервис";
            // 
            // договорыToolStripMenuItem
            // 
            this.договорыToolStripMenuItem.Name = "договорыToolStripMenuItem";
            this.договорыToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.договорыToolStripMenuItem.Text = "Договоры";
            // 
            // поставкаToolStripMenuItem
            // 
            this.поставкаToolStripMenuItem.Name = "поставкаToolStripMenuItem";
            this.поставкаToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.поставкаToolStripMenuItem.Text = "Поставка";
            // 
            // анализКачестваToolStripMenuItem
            // 
            this.анализКачестваToolStripMenuItem.Name = "анализКачестваToolStripMenuItem";
            this.анализКачестваToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.анализКачестваToolStripMenuItem.Text = "Анализ качества";
            // 
            // обработкаToolStripMenuItem
            // 
            this.обработкаToolStripMenuItem.Name = "обработкаToolStripMenuItem";
            this.обработкаToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.обработкаToolStripMenuItem.Text = "Обработка";
            // 
            // хранениеToolStripMenuItem
            // 
            this.хранениеToolStripMenuItem.Name = "хранениеToolStripMenuItem";
            this.хранениеToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.хранениеToolStripMenuItem.Text = "Хранение";
            // 
            // отгрузкаToolStripMenuItem
            // 
            this.отгрузкаToolStripMenuItem.Name = "отгрузкаToolStripMenuItem";
            this.отгрузкаToolStripMenuItem.Size = new System.Drawing.Size(165, 22);
            this.отгрузкаToolStripMenuItem.Text = "Отгрузка";
            // 
            // отчетыToolStripMenuItem
            // 
            this.отчетыToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.карточкаАнализаToolStripMenuItem,
            this.прочиеОтчетыToolStripMenuItem});
            this.отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            this.отчетыToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // карточкаАнализаToolStripMenuItem
            // 
            this.карточкаАнализаToolStripMenuItem.Name = "карточкаАнализаToolStripMenuItem";
            this.карточкаАнализаToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.карточкаАнализаToolStripMenuItem.Text = "Карточка анализа";
            // 
            // прочиеОтчетыToolStripMenuItem
            // 
            this.прочиеОтчетыToolStripMenuItem.Name = "прочиеОтчетыToolStripMenuItem";
            this.прочиеОтчетыToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.прочиеОтчетыToolStripMenuItem.Text = "Прочие отчеты";
            // 
            // сменитьПользователяToolStripMenuItem
            // 
            this.сменитьПользователяToolStripMenuItem.Name = "сменитьПользователяToolStripMenuItem";
            this.сменитьПользователяToolStripMenuItem.Size = new System.Drawing.Size(145, 20);
            this.сменитьПользователяToolStripMenuItem.Text = "Сменить пользователя";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // normsImpurityToolStripMenuItem
            // 
            this.normsImpurityToolStripMenuItem.Name = "normsImpurityToolStripMenuItem";
            this.normsImpurityToolStripMenuItem.Size = new System.Drawing.Size(237, 22);
            this.normsImpurityToolStripMenuItem.Text = "Нормы показателей качества";
            this.normsImpurityToolStripMenuItem.Click += new System.EventHandler(this.normsImpurityToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(227)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(680, 299);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Учет хранения зерновых культур";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справочникиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rawToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem storageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem impurityToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сервисToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem договорыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem поставкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem анализКачестваToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem обработкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem хранениеToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отгрузкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem отчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem карточкаАнализаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem прочиеОтчетыToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сменитьПользователяToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem normsImpurityToolStripMenuItem;
    }
}