using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace курсоваООП
{
    public partial class InstructionsForm: Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public InstructionsForm()
        {
            InitializeComponent();
            LoadBackgroundImageAsync();
            this.BackgroundImageLayout = ImageLayout.Stretch;
            labelInstructions.Text = "Інструкція з використання:\r\n" +
                                    "1. Відкрийте каталог, натиснувши кнопку 'Перейти до каталогу'.\r\n" +
                                    "2. Оберіть товар зі списку.\r\n" +
                                    "3. Двічі клікніть на товар, щоб переглянути деталі.\r\n" +
                                    "4. Натисніть 'Купити', щоб перейти за посиланням для покупки.";
            labelInstructions.Font = new Font("Papyrus", 12);
            labelInstructions.ForeColor = Color.Gold;
            buttonClose.Text = "Закрити";
            buttonClose.Font = new Font("Papyrus", 12);
            buttonClose.ForeColor = Color.Gold;
        }

        private async void LoadBackgroundImageAsync()
        {
            try
            {
                // Завантажуємо фонове зображення для InstructionsForm (зображення Геральта)
                byte[] formBackgroundBytes = await httpClient.GetByteArrayAsync("https://wallpapercat.com/w/full/f/3/f/5549-3840x2160-desktop-4k-the-witcher-game-wallpaper-photo.jpg");
                using (var ms = new System.IO.MemoryStream(formBackgroundBytes))
                {
                    this.BackgroundImage = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити фонове зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
