namespace курсоваООП
{
    partial class CatalogForm
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
            this.listBoxComputers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();

            // listBoxComputers
            this.listBoxComputers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.listBoxComputers.ForeColor = System.Drawing.Color.Gold;
            this.listBoxComputers.Font = new System.Drawing.Font("Papyrus", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBoxComputers.FormattingEnabled = true;
            this.listBoxComputers.Location = new System.Drawing.Point(12, 12);
            this.listBoxComputers.Name = "listBoxComputers";
            this.listBoxComputers.Size = new System.Drawing.Size(776, 426);
            this.listBoxComputers.TabIndex = 0;
            this.listBoxComputers.DoubleClick += new System.EventHandler(this.listBoxComputers_DoubleClick);

            // CatalogForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBoxComputers);
            this.Name = "CatalogForm";
            this.Text = "Каталог";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBoxComputers;
    }
}