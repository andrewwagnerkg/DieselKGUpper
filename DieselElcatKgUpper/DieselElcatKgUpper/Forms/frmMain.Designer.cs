namespace DieselElcatKgUpper
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.pnlMenu = new System.Windows.Forms.Panel();
            this.btnSettings = new FontAwesome.Sharp.IconButton();
            this.btnAddAccount = new FontAwesome.Sharp.IconButton();
            this.btnAddTheme = new FontAwesome.Sharp.IconButton();
            this.btnRecords = new FontAwesome.Sharp.IconButton();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.pnlMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenu
            // 
            this.pnlMenu.Controls.Add(this.btnSettings);
            this.pnlMenu.Controls.Add(this.btnAddAccount);
            this.pnlMenu.Controls.Add(this.btnAddTheme);
            this.pnlMenu.Controls.Add(this.btnRecords);
            this.pnlMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(1043, 96);
            this.pnlMenu.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSettings.IconChar = FontAwesome.Sharp.IconChar.Cogs;
            this.btnSettings.IconColor = System.Drawing.Color.Gray;
            this.btnSettings.IconSize = 48;
            this.btnSettings.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSettings.Location = new System.Drawing.Point(956, 12);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Rotation = 0D;
            this.btnSettings.Size = new System.Drawing.Size(75, 75);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Настройки";
            this.btnSettings.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnAddAccount
            // 
            this.btnAddAccount.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddAccount.IconChar = FontAwesome.Sharp.IconChar.User;
            this.btnAddAccount.IconColor = System.Drawing.Color.Maroon;
            this.btnAddAccount.IconSize = 48;
            this.btnAddAccount.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddAccount.Location = new System.Drawing.Point(174, 12);
            this.btnAddAccount.Name = "btnAddAccount";
            this.btnAddAccount.Rotation = 0D;
            this.btnAddAccount.Size = new System.Drawing.Size(75, 75);
            this.btnAddAccount.TabIndex = 0;
            this.btnAddAccount.Text = "Добавить аккаунт";
            this.btnAddAccount.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddAccount.UseVisualStyleBackColor = true;
            this.btnAddAccount.Visible = false;
            this.btnAddAccount.Click += new System.EventHandler(this.btnAddAccount_Click);
            // 
            // btnAddTheme
            // 
            this.btnAddTheme.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnAddTheme.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnAddTheme.IconColor = System.Drawing.Color.DodgerBlue;
            this.btnAddTheme.IconSize = 48;
            this.btnAddTheme.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnAddTheme.Location = new System.Drawing.Point(93, 12);
            this.btnAddTheme.Name = "btnAddTheme";
            this.btnAddTheme.Rotation = 0D;
            this.btnAddTheme.Size = new System.Drawing.Size(75, 75);
            this.btnAddTheme.TabIndex = 0;
            this.btnAddTheme.Text = "Добавить тему";
            this.btnAddTheme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAddTheme.UseVisualStyleBackColor = true;
            this.btnAddTheme.Click += new System.EventHandler(this.btnAddTheme_Click);
            // 
            // btnRecords
            // 
            this.btnRecords.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnRecords.IconChar = FontAwesome.Sharp.IconChar.AlignJustify;
            this.btnRecords.IconColor = System.Drawing.Color.Tomato;
            this.btnRecords.IconSize = 48;
            this.btnRecords.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnRecords.Location = new System.Drawing.Point(12, 12);
            this.btnRecords.Name = "btnRecords";
            this.btnRecords.Rotation = 0D;
            this.btnRecords.Size = new System.Drawing.Size(75, 75);
            this.btnRecords.TabIndex = 0;
            this.btnRecords.Text = "Записи тем";
            this.btnRecords.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRecords.UseVisualStyleBackColor = true;
            this.btnRecords.Click += new System.EventHandler(this.btnRecords_Click);
            // 
            // pnlContent
            // 
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 96);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Padding = new System.Windows.Forms.Padding(5);
            this.pnlContent.Size = new System.Drawing.Size(1043, 541);
            this.pnlContent.TabIndex = 1;
            // 
            // notifyIcon
            // 
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "DieselElcatKgUpper";
            this.notifyIcon.Visible = true;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 637);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.pnlMenu);
            this.MinimumSize = new System.Drawing.Size(520, 39);
            this.Name = "frmMain";
            this.Text = "Diesel kg Upper";
            this.pnlMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Panel pnlContent;
        private FontAwesome.Sharp.IconButton btnSettings;
        private FontAwesome.Sharp.IconButton btnAddAccount;
        private FontAwesome.Sharp.IconButton btnAddTheme;
        private FontAwesome.Sharp.IconButton btnRecords;
        private System.Windows.Forms.NotifyIcon notifyIcon;
    }
}

