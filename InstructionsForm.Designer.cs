namespace курсоваООП
{
    partial class InstructionsForm
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
            this.labelInstructions = new System.Windows.Forms.Label();
            this.buttonClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelInstructions
            // 
            this.labelInstructions.AutoSize = true;
            this.labelInstructions.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInstructions.ForeColor = System.Drawing.Color.Gold;
            this.labelInstructions.Location = new System.Drawing.Point(27, 25);
            this.labelInstructions.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelInstructions.Name = "labelInstructions";
            this.labelInstructions.Size = new System.Drawing.Size(543, 108);
            this.labelInstructions.TabIndex = 0;
            this.labelInstructions.Text = "1. Зареєструйтесь, щоб зберегти свої дані.\r\n2. Перейдіть до каталогу, натиснувши " +
    "кнопку нижче.\r\n3. Оберіть товар для перегляду деталей.\r\n4. Натисніть \'Купити\', щ" +
    "об перейти за посиланням.";
            // 
            // buttonClose
            // 
            this.buttonClose.BackColor = System.Drawing.Color.Transparent;
            this.buttonClose.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.buttonClose.FlatAppearance.BorderSize = 2;
            this.buttonClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClose.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonClose.ForeColor = System.Drawing.Color.Gold;
            this.buttonClose.Location = new System.Drawing.Point(243, 217);
            this.buttonClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.buttonClose.Name = "buttonClose";
            this.buttonClose.Size = new System.Drawing.Size(133, 37);
            this.buttonClose.TabIndex = 1;
            this.buttonClose.Text = "Закрити";
            this.buttonClose.UseVisualStyleBackColor = false;
            this.buttonClose.Click += new System.EventHandler(this.buttonClose_Click);
            // 
            // InstructionsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(650, 334);
            this.Controls.Add(this.buttonClose);
            this.Controls.Add(this.labelInstructions);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "InstructionsForm";
            this.Text = "Інструкція";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label labelInstructions;
        private System.Windows.Forms.Button buttonClose;
    }
}