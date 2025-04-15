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
    public partial class MainForm : Form
    {
        private Timer slideTimer;
        private bool isMenuVisible = false;
        private const int menuWidth = 200; // Ширина меню
        private const int slideSpeed = 10; // Швидкість анісації
        private static readonly HttpClient httpClient = new HttpClient();

        public MainForm()
        {
            InitializeComponent();
            LoadBackgroundImagesAsync();

            // Налаштування таймера для анісації
            slideTimer = new Timer();
            slideTimer.Interval = 20; 
            slideTimer.Tick += SlideTimer_Tick;
            labelMenuIcon.Visible = true;
        }

        private async void LoadBackgroundImagesAsync()
        {
            try
            {
                
                byte[] formBackgroundBytes = await httpClient.GetByteArrayAsync("https://wallpapercat.com/w/full/f/3/f/5549-3840x2160-desktop-4k-the-witcher-game-wallpaper-photo.jpg");
                using (var ms = new System.IO.MemoryStream(formBackgroundBytes))
                {
                    this.BackgroundImage = Image.FromStream(ms);
                }

                
                byte[] menuBackgroundBytes = await httpClient.GetByteArrayAsync("https://c4.wallpaperflare.com/wallpaper/850/453/285/the-witcher-3-wild-hunt-the-witcher-wallpaper-preview.jpg");
                using (var ms = new System.IO.MemoryStream(menuBackgroundBytes))
                {
                    panelMenu.BackgroundImage = Image.FromStream(ms);
                }

                

                
                byte[] witcherImageBytes2 = await httpClient.GetByteArrayAsync("https://www.vodafone.ua/shop/media/blog/_1__7.jpg");
                using (var ms = new System.IO.MemoryStream(witcherImageBytes2))
                {
                    pictureBoxWitcher2.Image = Image.FromStream(ms);
                }

                
                byte[] witcherImageBytes3 = await httpClient.GetByteArrayAsync("https://ua.games/image/game/19.jpg");
                using (var ms = new System.IO.MemoryStream(witcherImageBytes3))
                {
                    pictureBoxWitcher3.Image = Image.FromStream(ms);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Не вдалося завантажити зображення: {ex.Message}", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SlideTimer_Tick(object sender, EventArgs e)
        {
            if (isMenuVisible)
            {
               
                if (panelMenu.Location.X > this.ClientSize.Width - menuWidth)
                {
                    panelMenu.Location = new Point(panelMenu.Location.X - slideSpeed, 0);
                }
                else
                {
                    slideTimer.Stop();
                    panelMenu.Location = new Point(this.ClientSize.Width - menuWidth, 0);
                    labelMenuIcon.Visible = false; 
                }
            }
            else
            {
                // Заїжджаємо вправо (ховаємо меню)
                if (panelMenu.Location.X < this.ClientSize.Width)
                {
                    panelMenu.Location = new Point(panelMenu.Location.X + slideSpeed, 0);
                }
                else
                {
                    slideTimer.Stop();
                    panelMenu.Location = new Point(this.ClientSize.Width, 0);
                    labelMenuIcon.Visible = true; 
                }
            }
        }

        private void panelMenu_MouseEnter(object sender, EventArgs e)
        {
            isMenuVisible = true;
            slideTimer.Start();
        }

        private void panelMenu_MouseLeave(object sender, EventArgs e)
        {
            // Перевіряємо, чи курсор дійсно покинув межі меню
            Point mousePosition = panelMenu.PointToClient(Cursor.Position);
            if (!panelMenu.ClientRectangle.Contains(mousePosition))
            {
                isMenuVisible = false;
                slideTimer.Start();
            }
        }

        private void labelMenuIcon_MouseEnter(object sender, EventArgs e)
        {
            isMenuVisible = true;
            slideTimer.Start();
        }

        private void buttonAbout_Click(object sender, EventArgs e)
        {
            // Відкриваємо нову форму AboutForm
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void buttonInstructions_Click(object sender, EventArgs e)
        {
            // Відкриваємо нову форму InstructionsForm
            InstructionsForm instructionsForm = new InstructionsForm();
            instructionsForm.ShowDialog();
        }

        private void buttonRegister_Click(object sender, EventArgs e)
        {
            RegistrationForm regForm = new RegistrationForm();
            regForm.ShowDialog();
        }

        private void buttonCatalog_Click(object sender, EventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.ShowDialog();
        }

        private void buttonGoToCatalog_Click(object sender, EventArgs e)
        {
            CatalogForm catalogForm = new CatalogForm();
            catalogForm.ShowDialog();
        }
    }
}

