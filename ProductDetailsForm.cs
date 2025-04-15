using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;
using System.Net.Http;

namespace курсоваООП
{
    public partial class ProductDetailsForm: Form
    {
        private Computer computer;
        private static readonly HttpClient httpClient = new HttpClient();

        public ProductDetailsForm(Computer selectedComputer)
        {
            InitializeComponent();
            this.computer = selectedComputer;
            LoadComputerDetails();
            LoadBackgroundImageAsync();
        }

        private async void LoadBackgroundImageAsync()
        {
            try
            {
                // Завантажуємо фонове зображення для ProductDetailsForm (зображення Геральта)
                byte[] formBackgroundBytes = await httpClient.GetByteArrayAsync("https://wallpapercat.com/w/full/f/3/f/5549-3840x2160-desktop-4k-the-witcher-game-wallpaper-photo.jpg"); // Заміни на реальний URL із зображенням Геральта
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

        private async void LoadComputerDetails()
        {
            labelName.Text = computer.Name;
            labelPrice.Text = $"Ціна: {computer.Price} грн";
            labelProcessor.Text = $"Процесор: {computer.Processor}";
            labelRAM.Text = $"Оперативна пам’ять: {computer.RAM}";
            labelStorage.Text = $"Накопичувач: {computer.Storage}";
            labelDescription.Text = $"Опис: {computer.Description}";

            // Завантажуємо зображення асинхронно
            if (!string.IsNullOrEmpty(computer.ImageUrl))
            {
                try
                {
                    byte[] imageBytes = await httpClient.GetByteArrayAsync(computer.ImageUrl);
                    using (MemoryStream ms = new MemoryStream(imageBytes))
                    {
                        pictureBoxImage.Image = Image.FromStream(ms);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Не вдалося завантажити зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    pictureBoxImage.Image = null;
                }
            }
            else
            {
                pictureBoxImage.Image = null;
            }
        }

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = computer.PurchaseLink,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося відкрити посилання: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
