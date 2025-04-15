namespace курсоваООП
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.labelWelcome = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.buttonGoToCatalog = new System.Windows.Forms.Button();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonCatalog = new System.Windows.Forms.Button();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.buttonInstructions = new System.Windows.Forms.Button();
            this.buttonAbout = new System.Windows.Forms.Button();
            this.labelMenuIcon = new System.Windows.Forms.Label();
            this.pictureBoxWitcher2 = new System.Windows.Forms.PictureBox();
            this.pictureBoxWitcher3 = new System.Windows.Forms.PictureBox();
            this.labelInfo1 = new System.Windows.Forms.Label();
            this.labelInfo2 = new System.Windows.Forms.Label();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWitcher2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWitcher3)).BeginInit();
            this.SuspendLayout();
            // 
            // labelWelcome
            // 
            this.labelWelcome.AutoSize = true;
            this.labelWelcome.Font = new System.Drawing.Font("Papyrus", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWelcome.ForeColor = System.Drawing.Color.White;
            this.labelWelcome.Location = new System.Drawing.Point(282, 9);
            this.labelWelcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelWelcome.Name = "labelWelcome";
            this.labelWelcome.Size = new System.Drawing.Size(524, 38);
            this.labelWelcome.TabIndex = 1;
            this.labelWelcome.Text = "Ласкаво просимо до каталогу товарів!";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Gold;
            this.labelDescription.Location = new System.Drawing.Point(151, 47);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(826, 27);
            this.labelDescription.TabIndex = 2;
            this.labelDescription.Text = "Ця програма — каталог товарів із характеристиками та посиланнями на покупку";
            // 
            // buttonGoToCatalog
            // 
            this.buttonGoToCatalog.BackColor = System.Drawing.Color.Transparent;
            this.buttonGoToCatalog.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonGoToCatalog.FlatAppearance.BorderSize = 2;
            this.buttonGoToCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonGoToCatalog.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGoToCatalog.ForeColor = System.Drawing.Color.Gold;
            this.buttonGoToCatalog.Location = new System.Drawing.Point(382, 495);
            this.buttonGoToCatalog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonGoToCatalog.Name = "buttonGoToCatalog";
            this.buttonGoToCatalog.Size = new System.Drawing.Size(267, 37);
            this.buttonGoToCatalog.TabIndex = 3;
            this.buttonGoToCatalog.Text = "Перейти до каталогу";
            this.buttonGoToCatalog.UseVisualStyleBackColor = false;
            this.buttonGoToCatalog.Click += new System.EventHandler(this.buttonGoToCatalog_Click);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelMenu.Controls.Add(this.buttonCatalog);
            this.panelMenu.Controls.Add(this.buttonRegister);
            this.panelMenu.Controls.Add(this.buttonInstructions);
            this.panelMenu.Controls.Add(this.buttonAbout);
            this.panelMenu.Location = new System.Drawing.Point(1067, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(267, 554);
            this.panelMenu.TabIndex = 4;
            this.panelMenu.MouseEnter += new System.EventHandler(this.panelMenu_MouseEnter);
            this.panelMenu.MouseLeave += new System.EventHandler(this.panelMenu_MouseLeave);
            // 
            // buttonCatalog
            // 
            this.buttonCatalog.BackColor = System.Drawing.Color.Transparent;
            this.buttonCatalog.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCatalog.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCatalog.ForeColor = System.Drawing.Color.Gold;
            this.buttonCatalog.Location = new System.Drawing.Point(27, 246);
            this.buttonCatalog.Margin = new System.Windows.Forms.Padding(4);
            this.buttonCatalog.Name = "buttonCatalog";
            this.buttonCatalog.Size = new System.Drawing.Size(213, 49);
            this.buttonCatalog.TabIndex = 3;
            this.buttonCatalog.Text = "Каталог";
            this.buttonCatalog.UseVisualStyleBackColor = false;
            this.buttonCatalog.Click += new System.EventHandler(this.buttonCatalog_Click);
            this.buttonCatalog.MouseEnter += new System.EventHandler(this.panelMenu_MouseEnter);
            this.buttonCatalog.MouseLeave += new System.EventHandler(this.panelMenu_MouseLeave);
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.Transparent;
            this.buttonRegister.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegister.ForeColor = System.Drawing.Color.Gold;
            this.buttonRegister.Location = new System.Drawing.Point(27, 185);
            this.buttonRegister.Margin = new System.Windows.Forms.Padding(4);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(213, 49);
            this.buttonRegister.TabIndex = 2;
            this.buttonRegister.Text = "Реєстрація";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            this.buttonRegister.MouseEnter += new System.EventHandler(this.panelMenu_MouseEnter);
            this.buttonRegister.MouseLeave += new System.EventHandler(this.panelMenu_MouseLeave);
            // 
            // buttonInstructions
            // 
            this.buttonInstructions.BackColor = System.Drawing.Color.Transparent;
            this.buttonInstructions.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonInstructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInstructions.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInstructions.ForeColor = System.Drawing.Color.Gold;
            this.buttonInstructions.Location = new System.Drawing.Point(27, 123);
            this.buttonInstructions.Margin = new System.Windows.Forms.Padding(4);
            this.buttonInstructions.Name = "buttonInstructions";
            this.buttonInstructions.Size = new System.Drawing.Size(213, 49);
            this.buttonInstructions.TabIndex = 1;
            this.buttonInstructions.Text = "Інструкція";
            this.buttonInstructions.UseVisualStyleBackColor = false;
            this.buttonInstructions.Click += new System.EventHandler(this.buttonInstructions_Click);
            this.buttonInstructions.MouseEnter += new System.EventHandler(this.panelMenu_MouseEnter);
            this.buttonInstructions.MouseLeave += new System.EventHandler(this.panelMenu_MouseLeave);
            // 
            // buttonAbout
            // 
            this.buttonAbout.BackColor = System.Drawing.Color.Transparent;
            this.buttonAbout.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAbout.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAbout.ForeColor = System.Drawing.Color.Gold;
            this.buttonAbout.Location = new System.Drawing.Point(27, 62);
            this.buttonAbout.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAbout.Name = "buttonAbout";
            this.buttonAbout.Size = new System.Drawing.Size(213, 49);
            this.buttonAbout.TabIndex = 0;
            this.buttonAbout.Text = "Про програму";
            this.buttonAbout.UseVisualStyleBackColor = false;
            this.buttonAbout.Click += new System.EventHandler(this.buttonAbout_Click);
            this.buttonAbout.MouseEnter += new System.EventHandler(this.panelMenu_MouseEnter);
            this.buttonAbout.MouseLeave += new System.EventHandler(this.panelMenu_MouseLeave);
            // 
            // labelMenuIcon
            // 
            this.labelMenuIcon.AutoSize = true;
            this.labelMenuIcon.Font = new System.Drawing.Font("Arial", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenuIcon.ForeColor = System.Drawing.Color.Gold;
            this.labelMenuIcon.Location = new System.Drawing.Point(1000, 12);
            this.labelMenuIcon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMenuIcon.Name = "labelMenuIcon";
            this.labelMenuIcon.Size = new System.Drawing.Size(37, 40);
            this.labelMenuIcon.TabIndex = 5;
            this.labelMenuIcon.Text = "≡";
            this.labelMenuIcon.MouseEnter += new System.EventHandler(this.labelMenuIcon_MouseEnter);
            // 
            // pictureBoxWitcher2
            // 
            this.pictureBoxWitcher2.Location = new System.Drawing.Point(50, 331);
            this.pictureBoxWitcher2.Name = "pictureBoxWitcher2";
            this.pictureBoxWitcher2.Size = new System.Drawing.Size(219, 126);
            this.pictureBoxWitcher2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWitcher2.TabIndex = 7;
            this.pictureBoxWitcher2.TabStop = false;
            // 
            // pictureBoxWitcher3
            // 
            this.pictureBoxWitcher3.Location = new System.Drawing.Point(674, 346);
            this.pictureBoxWitcher3.Name = "pictureBoxWitcher3";
            this.pictureBoxWitcher3.Size = new System.Drawing.Size(170, 111);
            this.pictureBoxWitcher3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxWitcher3.TabIndex = 8;
            this.pictureBoxWitcher3.TabStop = false;
            // 
            // labelInfo1
            // 
            this.labelInfo1.AutoSize = true;
            this.labelInfo1.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo1.ForeColor = System.Drawing.Color.Gold;
            this.labelInfo1.Location = new System.Drawing.Point(46, 460);
            this.labelInfo1.Name = "labelInfo1";
            this.labelInfo1.Size = new System.Drawing.Size(304, 72);
            this.labelInfo1.TabIndex = 9;
            this.labelInfo1.Text = "Цей каталог допоможе вам знайти\r\nідеальний комп’ютер для ігор,\r\nтаких як Відьмак " +
    "3!";
            // 
            // labelInfo2
            // 
            this.labelInfo2.AutoSize = true;
            this.labelInfo2.Font = new System.Drawing.Font("Papyrus", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInfo2.ForeColor = System.Drawing.Color.Gold;
            this.labelInfo2.Location = new System.Drawing.Point(670, 460);
            this.labelInfo2.Name = "labelInfo2";
            this.labelInfo2.Size = new System.Drawing.Size(307, 72);
            this.labelInfo2.TabIndex = 10;
            this.labelInfo2.Text = "Дізнайтесь, які характеристики\r\nпотрібні для максимальної графіки\r\nу Відьмаку 3!";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.labelInfo2);
            this.Controls.Add(this.labelInfo1);
            this.Controls.Add(this.pictureBoxWitcher3);
            this.Controls.Add(this.pictureBoxWitcher2);
            this.Controls.Add(this.labelMenuIcon);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.buttonGoToCatalog);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelWelcome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Каталог товарів";
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWitcher2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWitcher3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelWelcome;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.Button buttonGoToCatalog;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button buttonAbout;
        private System.Windows.Forms.Button buttonInstructions;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Button buttonCatalog;
        private System.Windows.Forms.Label labelMenuIcon;
        private System.Windows.Forms.PictureBox pictureBoxWitcher2;
        private System.Windows.Forms.PictureBox pictureBoxWitcher3;
        private System.Windows.Forms.Label labelInfo1;
        private System.Windows.Forms.Label labelInfo2;
    }
}

