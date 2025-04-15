using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace курсоваООП
{
    public partial class RegistrationForm : Form
    {
        private string userDataFilePath = "users.txt"; // Змінено з JSON на текстовий файл
        private static readonly HttpClient httpClient = new HttpClient();

        public RegistrationForm()
        {
            InitializeComponent();
            LoadUserData();
            LoadBackgroundImageAsync();
        }

        private async void LoadBackgroundImageAsync()
        {
            try
            {
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

        private void LoadUserData()
        {
            if (File.Exists(userDataFilePath))
            {
                try
                {
                    string[] lines = File.ReadAllLines(userDataFilePath);
                    if (lines.Length > 0)
                    {
                        string[] parts = lines[lines.Length - 1].Split(':'); // Останній запис
                        if (parts.Length >= 3)
                        {
                            textBoxLogin.Text = parts[0];
                            textBoxPassword.Text = parts[1];
                            textBoxEmail.Text = parts[2];
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Помилка при зчитуванні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;
            string email = textBoxEmail.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password) || string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Будь ласка, заповніть усі поля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(userDataFilePath, true))
                {
                    writer.WriteLine($"{login}:{password}:{email}");
                }
                MessageBox.Show("Реєстрація успішна!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при збереженні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Будь ласка, заповніть поля логіну та пароля!", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!File.Exists(userDataFilePath))
            {
                MessageBox.Show("Файл із користувачами не знайдено. Спочатку зареєструйтесь.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string[] lines = File.ReadAllLines(userDataFilePath);
                bool loginSuccessful = false;

                foreach (string line in lines)
                {
                    string[] parts = line.Split(':');
                    if (parts.Length >= 2 && parts[0] == login && parts[1] == password)
                    {
                        loginSuccessful = true;
                        break;
                    }
                }

                if (loginSuccessful)
                {
                    MessageBox.Show("Вхід успішний!", "Успіх", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    MainForm mainForm = new MainForm();
                    mainForm.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Невірне ім’я користувача або пароль.", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Помилка при зчитуванні даних: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}