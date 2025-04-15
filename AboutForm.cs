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
    public partial class AboutForm: Form
    {
        private static readonly HttpClient httpClient = new HttpClient();

        public AboutForm()
        {
            InitializeComponent();
            
            this.BackgroundImageLayout = ImageLayout.Stretch;
            labelAbout.Text = "Ця програма розроблена для зручного перегляду та вибору товарів із детальними \nхарактеристиками. Кожен товар у каталозі має опис, технічні параметри, \nціну та доступність. Користувач може ознайомитись з товарами, порівняти їх \nміж собою та прийняти рішення щодо покупки.\r\n\r\nПрограма також передбачає простий та інтуїтивно зрозумілий інтерфейс, який \nзабезпечує швидкий доступ до інформації про кожен продукт. \nТакий каталог може бути корисним для інтернет-магазинів, торгових \nмайданчиків або демонстраційних систем.\r\n\r\n.\r\n" +
                             "Розробник: [Тополюк Іван]\r\n" +
                             "Версія: 1.0\r\n" +
                             "Дата: 20 березня 2025";
            labelAbout.Font = new Font("Papyrus", 12);
            labelAbout.ForeColor = Color.Gold;
            buttonClose.Text = "Закрити";
            buttonClose.Font = new Font("Papyrus", 12);
            buttonClose.ForeColor = Color.Gold;
        }

        private async void LoadBackgroundImageAsync()
        {
            try
            {
                // Завантажуємо фонове зображення для AboutForm (зображення Геральта)
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
