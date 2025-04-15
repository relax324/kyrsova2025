namespace курсоваООП
{
    partial class ProductDetailsForm
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
            this.labelName = new System.Windows.Forms.Label();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelProcessor = new System.Windows.Forms.Label();
            this.labelRAM = new System.Windows.Forms.Label();
            this.labelStorage = new System.Windows.Forms.Label();
            this.labelDescription = new System.Windows.Forms.Label();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.buttonBuy = new System.Windows.Forms.Button();
            this.buttonClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.SuspendLayout();

            // labelName
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.Color.White;
            this.labelName.Location = new System.Drawing.Point(12, 20);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(35, 13);
            this.labelName.TabIndex = 0;
            this.labelName.Text = "[Name]";

            // labelPrice
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.Color.Gold;
            this.labelPrice.Location = new System.Drawing.Point(12, 50);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(35, 13);
            this.labelPrice.TabIndex = 1;
            this.labelPrice.Text = "Ціна:";

            // labelProcessor
            this.labelProcessor.AutoSize = true;
            this.labelProcessor.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelProcessor.ForeColor = System.Drawing.Color.Gold;
            this.labelProcessor.Location = new System.Drawing.Point(12, 80);
            this.labelProcessor.Name = "labelProcessor";
            this.labelProcessor.Size = new System.Drawing.Size(55, 13);
            this.labelProcessor.TabIndex = 2;
            this.labelProcessor.Text = "Процесор:";

            // labelRAM
            this.labelRAM.AutoSize = true;
            this.labelRAM.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRAM.ForeColor = System.Drawing.Color.Gold;
            this.labelRAM.Location = new System.Drawing.Point(12, 110);
            this.labelRAM.Name = "labelRAM";
            this.labelRAM.Size = new System.Drawing.Size(85, 13);
            this.labelRAM.TabIndex = 3;
            this.labelRAM.Text = "Оперативна пам’ять:";

            // labelStorage
            this.labelStorage.AutoSize = true;
            this.labelStorage.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelStorage.ForeColor = System.Drawing.Color.Gold;
            this.labelStorage.Location = new System.Drawing.Point(12, 140);
            this.labelStorage.Name = "labelStorage";
            this.labelStorage.Size = new System.Drawing.Size(65, 13);
            this.labelStorage.TabIndex = 4;
            this.labelStorage.Text = "Накопичувач:";

            // labelDescription
            this.labelDescription.AutoSize = true;
            this.labelDescription.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDescription.ForeColor = System.Drawing.Color.Gold;
            this.labelDescription.Location = new System.Drawing.Point(12, 170);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(40, 13);
            this.labelDescription.TabIndex = 5;
            this.labelDescription.Text = "Опис:";

            // pictureBoxImage
            this.pictureBoxImage.Location = new System.Drawing.Point(300, 20);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(200, 200);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 6;
            this.pictureBoxImage.TabStop = false;

            // buttonBuy
            this.buttonBuy.BackColor = System.Drawing.Color.Transparent;
            this.buttonBuy.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonBuy.FlatAppearance.BorderSize = 2;
            this.buttonBuy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonBuy.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonBuy.ForeColor = System.Drawing.Color.Gold;
            this.buttonBuy.Location = new System.Drawing.Point(12, 300);
            this.buttonBuy.Name = "buttonBuy";
            this.buttonBuy.Size = new System.Drawing.Size(100, 30);
            this.buttonBuy.TabIndex = 7;
            this.buttonBuy.Text = "Купити";
            this.buttonBuy.UseVisualStyleBackColor = false;
            this.buttonBuy.Click += new System.EventHandler(this.buttonBuy_Click);

            // buttonClose
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Gold;
            this.buttonClose.Location = new System.Drawing.Point(400, 300);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(100, 30);
            this.buttonClose.TabIndex = 8;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);

            // ProductDetailsForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(520, 350);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.buttonBuy);
            this.Controls.Add(this.pictureBoxImage);
            this.Controls.Add(this.labelDescription);
            this.Controls.Add(this.labelStorage);
            this.Controls.Add(this.labelRAM);
            this.Controls.Add(this.labelProcessor);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.labelName);
            this.Name = "ProductDetailsForm";
            this.Text = "Деталі товару";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelProcessor;
        private System.Windows.Forms.Label labelRAM;
        private System.Windows.Forms.Label labelStorage;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Button buttonBuy;
        private System.Windows.Forms.Button buttonClose;
    }
}