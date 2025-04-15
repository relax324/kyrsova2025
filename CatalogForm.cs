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
    public partial class CatalogForm: Form
    {
        private static readonly HttpClient httpClient = new HttpClient();
        private List<Computer> computers = new List<Computer>
        {
            new Computer
            {
                Id = 1,
                Name = "Ноутбук ASUS ROG Strix G16",
                Price = 54999,
                Processor = "Intel Core i7-13650HX",
                RAM = "16 GB",
                Storage = "1 TB SSD",
                Description = "Ігровий ноутбук із потужною\nграфікою NVIDIA RTX 4060.",
                PurchaseLink = "https://rozetka.com.ua/ua/asus-90nr0ch5-m00720/p414981579/?gad_source=1&gclid=CjwKCAjw7pO_BhAlEiwA4pMQvMyN2H_T57WwJMm00iEaWL9wgYWqU-VMXy9oSvSEG4aLTEznuzAwXxoCZIEQAvD_BwE",
                ImageUrl = "https://www.notebookcheck-ru.com/fileadmin/_processed_/b/3/csm_Asus_ROG_Strix_14_5b24d8336e.jpg"
            },
            new Computer
            {
                 Id = 2,
                Name = "ПК ARTLINE Gaming X77",
                Price = 42999,
                Processor = "AMD Ryzen 5 5600X",
                RAM = "32 GB",
                Storage = "1 TB SSD",
                Description = "Стаціонарний ПК для геймерів\n із відеокартою RTX 3060.",
                PurchaseLink = "https://ktc.ua/goods/personalnij_kompyuter_artline_gaming_x77__x77v102.html?_ac=gagds&utm_id=18958942281&utm_content=18958942281&gad_source=1&gclid=CjwKCAjw7pO_BhAlEiwA4pMQvNVmyEnel5rDuzrF3eRwH9cH7gHez3pO7tHXdkvZbExkO2JnsJ91cRoCAKcQAvD_BwE",
                ImageUrl = "https://c.428.ua/img/4132124/3000/2000/kompyuter_artline_gaming_x77_white_x77whitev114~1080~1195.jpg"
            },
            new Computer
            {
                 Id = 3,
                Name = "Ноутбук Lenovo Legion 5 Pro",
                Price = 61999,
                Processor = "AMD Ryzen 7 5800H",
                RAM = "16 GB",
                Storage = "512 GB SSD",
                Description = "Ноутбук для геймерів і роботи\n з RTX 3070.",
                PurchaseLink = "https://rozetka.com.ua/ua/lenovo-83dg0079ra/p426915686/?gad_source=1&gclid=CjwKCAjw7pO_BhAlEiwA4pMQvChxn1fzSuDSaeAE0VfS_jnnIMBb43AyJkRmO356o0aiUplgw2-eNBoCzSoQAvD_BwE",
                ImageUrl = "https://kievmag.com.ua/image/cache/catalog/00/00/Legion%205%20Pro%2016%202023/legion-pro-5-gen-8-16irx8-kievmag-6-680x630.jpeg"
            },
            new Computer
            {
                 Id = 4,
                Name = "Ноутбук HP Pavilion Aero 13",
                Price = 34999,
                Processor = "AMD Ryzen 5 7535U",
                RAM = "8 GB",
                Storage = "512 GB SSD",
                Description = "Легкий ноутбук для\n роботи та навчання.",
                PurchaseLink = "https://rozetka.com.ua/ua/hp-8f2b8ea/p394914846/?gad_source=1&gclid=CjwKCAjw7pO_BhAlEiwA4pMQvAdXR2Ls1RM8MBvH_d8gV6AqSe4AufbqD2RqmqBmHZwRqOlC4OguOxoCUuoQAvD_BwE",
                ImageUrl = "https://cdn.mos.cms.futurecdn.net/iqX7QReNkzAGVf7sD2FDAT.jpg"
            },
            new Computer
            {
                 Id = 5,
                Name = "ПК 2E Gaming Phantom",
                Price = 47999,
                Processor = "Intel Core i5-12400F",
                RAM = "16 GB",
                Storage = "1 TB SSD",
                Description = "Ігровий ПК із підсвіткою\n та RTX 3060 Ti.",
                PurchaseLink = "https://hard.rozetka.com.ua/ua/411895077/p411895077/?srsltid=AfmBOorNypov9XDK9NZSu-zo2BxwnVOMDneHp7fzbXkMQcrBjEiSQwpRwHY",
                ImageUrl = "https://2egaming.com/wp-content/uploads/2e-gk701b_main.png"
            },
            new Computer
            {
                 Id = 6,
                Name = "Ноутбук ASUS TUF Gaming F15",
                Price = 36000,
                Processor = " Intel Core i5-12500H (2.5 - 4.5 ГГц)",
                RAM = "16 GB",
                Storage = "512 ГБ SSD",
                Description = "Ігровий ПК із підсвіткою\n та nVidia GeForce RTX 3050, 4 ГБ.",
                PurchaseLink = "https://rozetka.com.ua/ua/asus-90nr0gw1-m006e0/p387371961/",
                ImageUrl = "https://idrop.com.ua/image/cache/catalog/26.04.2024/nout/47%281%29-1500x1500.jpg"
            },
            new Computer
            {
                 Id = 7,
                Name = "Ноутбук ASUS TUF Gaming A15 ",
                Price = 49999,
                Processor = "AMD Ryzen 7 7435HS",
                RAM = "16 GB",
                Storage = "512 гб SSD",
                Description = "Ігровий ПК із підсвіткою\n та  GeForce RTX 4060, 8 ГБ.",
                PurchaseLink = "https://rozetka.com.ua/ua/asus-90nr0jk8-m00550/p451348847/",
                ImageUrl = "https://dlcdnwebimgs.asus.com/gain/6c49e355-de25-403c-b8c2-eb0ad4cc8a78/"
            },
            new Computer
            {
                 Id = 8,
                Name = "ПК 2E Gaming Phantom",
                Price = 47999,
                Processor = "Intel Core i5-12400F",
                RAM = "16 GB",
                Storage = "1 TB SSD",
                Description = "Ігровий ПК із підсвіткою\n та RTX 3060 Ti.",
                PurchaseLink = "https://hard.rozetka.com.ua/ua/411895077/p411895077/?srsltid=AfmBOorNypov9XDK9NZSu-zo2BxwnVOMDneHp7fzbXkMQcrBjEiSQwpRwHY",
                ImageUrl = "https://2egaming.com/wp-content/uploads/2e-gk701b_main.png"
            },
            new Computer
            {
                 Id = 9,
                Name = "ПК 2E Gaming Phantom",
                Price = 47999,
                Processor = "Intel Core i5-12400F",
                RAM = "16 GB",
                Storage = "1 TB SSD",
                Description = "Ігровий ПК із підсвіткою\n та RTX 3060 Ti.",
                PurchaseLink = "https://hard.rozetka.com.ua/ua/411895077/p411895077/?srsltid=AfmBOorNypov9XDK9NZSu-zo2BxwnVOMDneHp7fzbXkMQcrBjEiSQwpRwHY",
                ImageUrl = "https://2egaming.com/wp-content/uploads/2e-gk701b_main.png"
            },
            new Computer
            {
                 Id = 10,
                Name = "ПК 2E Gaming Phantom",
                Price = 47999,
                Processor = "Intel Core i5-12400F",
                RAM = "16 GB",
                Storage = "1 TB SSD",
                Description = "Ігровий ПК із підсвіткою\n та RTX 3060 Ti.",
                PurchaseLink = "https://hard.rozetka.com.ua/ua/411895077/p411895077/?srsltid=AfmBOorNypov9XDK9NZSu-zo2BxwnVOMDneHp7fzbXkMQcrBjEiSQwpRwHY",
                ImageUrl = "https://2egaming.com/wp-content/uploads/2e-gk701b_main.png"
            }
        };

        public CatalogForm()
        {
            InitializeComponent();
            listBoxComputers.DataSource = computers;
            LoadBackgroundImageAsync();
        }

        private async void LoadBackgroundImageAsync()
        {
            try
            {
                // Завантажуємо фонове зображення для CatalogForm (зображення Геральта)
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

        private void listBoxComputers_DoubleClick(object sender, EventArgs e)
        {
            if (listBoxComputers.SelectedItem != null)
            {
                Computer selectedComputer = (Computer)listBoxComputers.SelectedItem;
                ProductDetailsForm detailsForm = new ProductDetailsForm(selectedComputer);
                detailsForm.ShowDialog();
            }
        }
    }

    public class Computer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string Processor { get; set; }
        public string RAM { get; set; }
        public string Storage { get; set; }
        public string Description { get; set; }
        public string PurchaseLink { get; set; }
        public string ImageUrl { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
