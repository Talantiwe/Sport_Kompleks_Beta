using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;
using static Sport.Trainer;
using System.IO;


namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для Trener.xaml
    /// </summary>
    public partial class Trener : Window
    {

        private void Zad_Trener_Click(object sender, MouseButtonEventArgs e)
        {
            /*
            if (p1.Visibility == Visibility.Hidden)
            {
                p1.Visibility = Visibility.Visible;
            }
            else
            {
                p1.Visibility = Visibility.Hidden;
            }*/

            Trener trener = new Trener();
            trener.Show();
            this.Close();
        }

        public Trener()
        {
            InitializeComponent();
            primer(null, null);

        }
        

        public class SportsDataContext : DbContext
        {

            public DbSet<Trainer> Trainer { get; set; }

            public SportsDataContext() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=SportKompleks2;Integrated Security=True")
            {
                
            }
        }

        private void primer(object sender, RoutedEventArgs e)
        {
            try
            {
                using (var context = new SportsDataContext())
                {
                    var trainers = from trainer in context.Trainer
                                   select new { trainer.Name, trainer.FirstName, trainer.LastName, trainer.Spezialist};
                     
                    //trainersTextBlock.Text = "Name and FirstName:" + Environment.NewLine;

                    foreach (var trainer in trainers)
                    {
                        trainersTextBlock.Text += $"  {trainer.FirstName} {trainer.Name} {trainer.LastName}  \n";
                        trainersTextBlock_Spezialist.Text += $"  {trainer.Spezialist} \n";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
            
        }

       

        private void proba(object sender, MouseButtonEventArgs e)
        {
            if (p1.Visibility == Visibility.Hidden)
            {
                p1.Visibility = Visibility.Visible;
            }
            else
            {
                p1.Visibility = Visibility.Hidden;
            }

            try
            {

                using (var context = new SportsDataContext())
                {

                    var trainers = from trainer in context.Trainer
                                   where trainer.Name == "Вячеслав" && trainer.FirstName == "Колосов"
                                   select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };

                    foreach (var trainer in trainers)
                    {
                        t1_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                        s1.Content += $"Персональный тренер по  {trainer.Spezialist}y{Environment.NewLine}";
                        e1.Content += $"Окончил  {trainer.Education}{Environment.NewLine}";
                        st1.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                        h1.Content += $"{trainer.History}{Environment.NewLine}";

                        byte[] imageData = trainer.Photo;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo1.Content = photoImage;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }
        private void proba2(object sender, MouseButtonEventArgs e)
        {
            if (p2.Visibility == Visibility.Hidden)
            {
                p2.Visibility = Visibility.Visible;
            }
            else
            {
                p2.Visibility = Visibility.Hidden;
            }

            try
            {

                using (var context = new SportsDataContext())
                {

                    var trainers = from trainer in context.Trainer
                                   where trainer.Name == "Александра" && trainer.FirstName == "Воробьева"
                                   select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };

                    foreach (var trainer in trainers)
                    {
                        t2_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                        s2.Content += $"Персональный тренер по  {trainer.Spezialist}{Environment.NewLine}";
                        e2.Content += $"Окончила  {trainer.Education}{Environment.NewLine}";
                        st2.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                        h2.Content += $"{trainer.History}{Environment.NewLine}";

                        byte[] imageData = trainer.Photo;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo2.Content = photoImage;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void proba3(object sender, MouseButtonEventArgs e)
        {
            if (p3.Visibility == Visibility.Hidden)
            {
                p3.Visibility = Visibility.Visible;
            }
            else
            {
                p3.Visibility = Visibility.Hidden;
            }

            try
            {

                using (var context = new SportsDataContext())
                {

                    var trainers = from trainer in context.Trainer
                                   where trainer.Name == "Максим" && trainer.FirstName == "Смирнов"
                                   select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };

                    foreach (var trainer in trainers)
                    {
                        t3_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                        s3.Content += $"Тренер по  {trainer.Spezialist}у{Environment.NewLine}";
                        e3.Content += $"Звание {trainer.Education}{Environment.NewLine}";
                        st3.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                        h3.Content += $"{trainer.History}{Environment.NewLine}";

                        byte[] imageData = trainer.Photo;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo3.Content = photoImage;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void proba4(object sender, MouseButtonEventArgs e)
        {
            if (p4.Visibility == Visibility.Hidden)
            {
                p4.Visibility = Visibility.Visible;
            }
            else
            {
                p4.Visibility = Visibility.Hidden;
            }

            try
            {

                using (var context = new SportsDataContext())
                {

                    var trainers = from trainer in context.Trainer
                                   where trainer.Name == "Лев" && trainer.FirstName == "Дружинин"
                                   select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };

                    foreach (var trainer in trainers)
                    {
                        t4_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                        s4.Content += $"Тренер по  {trainer.Spezialist}у{Environment.NewLine}";
                        e4.Content += $"Окончил  {trainer.Education}{Environment.NewLine}";
                        st4.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                        h4.Content += $"{trainer.History}{Environment.NewLine}";

                        byte[] imageData = trainer.Photo;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo4.Content = photoImage;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void proba5(object sender, MouseButtonEventArgs e)
        {
            if (p5.Visibility == Visibility.Hidden)
            {
                p5.Visibility = Visibility.Visible;
            }
            else
            {
                p5.Visibility = Visibility.Hidden;
            }

            try
            {

                using (var context = new SportsDataContext())
                {

                    var trainers = from trainer in context.Trainer
                                   where trainer.Name == "Анастасия" && trainer.FirstName == "Никулина"
                                   select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };

                    foreach (var trainer in trainers)
                    {
                        t5_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                        s5.Content += $"Тренер  {trainer.Spezialist}{Environment.NewLine}";
                        e5.Content += $"Звание  {trainer.Education}{Environment.NewLine}";
                        st5.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                        h5.Content += $"{trainer.History}{Environment.NewLine}";

                        byte[] imageData = trainer.Photo;

                        if (imageData != null && imageData.Length > 0)
                        {
                            using (MemoryStream stream = new MemoryStream(imageData))
                            {
                                BitmapImage image = new BitmapImage();
                                image.BeginInit();
                                image.StreamSource = stream;
                                image.CacheOption = BitmapCacheOption.OnLoad;
                                image.EndInit();

                                Image photoImage = new Image();
                                photoImage.Source = image;

                                // Ваш элемент управления для отображения изображения, например, Image
                                photo5.Content = photoImage;
                            }
                        }
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }

        }

        private void proba6(object sender, MouseButtonEventArgs e)
        {
            if(p6.Visibility==Visibility.Hidden)
            {
                p6.Visibility = Visibility.Visible;
            }
            else
            {
                p6.Visibility = Visibility.Hidden;
            }

            using (var context = new SportsDataContext())
            {
                var trainers = from trainer in context.Trainer
                               where trainer.Name == "Давид" && trainer.FirstName == "Колесников"
                               select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };
                foreach (var trainer in trainers)
                {
                    t6_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                    s6.Content += $"{trainer.Spezialist}а{Environment.NewLine}";
                    e6.Content += $"Звание  {trainer.Education}{Environment.NewLine}";
                    st6.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                    h6.Content += $"{trainer.History}{Environment.NewLine}";

                    byte[] imageData = trainer.Photo;

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.StreamSource = stream;
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.EndInit();

                            Image photoImage = new Image();
                            photoImage.Source = image;

                            // Ваш элемент управления для отображения изображения, например, Image
                            photo6.Content = photoImage;
                        }
                    }
                }
            }
        }

        private void proba7(object sender, MouseButtonEventArgs e)
        {
            if (p7.Visibility == Visibility.Hidden)
            {
                p7.Visibility = Visibility.Visible;
            }
            else
            {
                p7.Visibility = Visibility.Hidden;
            }

            using (var context = new SportsDataContext())
            {
                var trainers = from trainer in context.Trainer
                               where trainer.Name == "Павел" && trainer.FirstName == "Патопав"
                               select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };
                foreach (var trainer in trainers)
                {
                    t7_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                    s7.Content += $"Тренер по {trainer.Spezialist}у{Environment.NewLine}";
                    e7.Content += $"{trainer.Education}{Environment.NewLine}";
                    st7.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                    h7.Content += $"{trainer.History}{Environment.NewLine}";

                    byte[] imageData = trainer.Photo;

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.StreamSource = stream;
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.EndInit();

                            Image photoImage = new Image();
                            photoImage.Source = image;

                            // Ваш элемент управления для отображения изображения, например, Image
                            photo7.Content = photoImage;
                        }
                    }
                }
            }
        }

        private void proba8(object sender, MouseButtonEventArgs e)
        {
            if (p8.Visibility == Visibility.Hidden)
            {
                p8.Visibility = Visibility.Visible;
            }
            else
            {
                p8.Visibility = Visibility.Hidden;
            }

            using (var context = new SportsDataContext())
            {
                var trainers = from trainer in context.Trainer
                               where trainer.Name == "Леонид " && trainer.FirstName == "Слуцкий"
                               select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };
                foreach (var trainer in trainers)
                {
                    t8_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                    s8.Content += $"Тренер по {trainer.Spezialist}у{Environment.NewLine}";
                    e8.Content += $"Звание  {trainer.Education}{Environment.NewLine}";
                    st8.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                    h8.Content += $"{trainer.History}{Environment.NewLine}";

                    byte[] imageData = trainer.Photo;

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.StreamSource = stream;
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.EndInit();

                            Image photoImage = new Image();
                            photoImage.Source = image;

                            // Ваш элемент управления для отображения изображения, например, Image
                            photo8.Content = photoImage;
                        }
                    }
                }
            }
        }

        private void proba9(object sender, MouseButtonEventArgs e)
        {
            if (p9.Visibility == Visibility.Hidden)
            {
                p9.Visibility = Visibility.Visible;
            }
            else
            {
                p9.Visibility = Visibility.Hidden;
            }

            using (var context = new SportsDataContext())
            {
                var trainers = from trainer in context.Trainer
                               where trainer.Name == "Артём " && trainer.FirstName == "Вахитов"
                               select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };
                foreach (var trainer in trainers)
                {
                    t9_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                    s9.Content += $"Тренер по {trainer.Spezialist}а{Environment.NewLine}";
                    e9.Content += $"{trainer.Education}{Environment.NewLine}";
                    st9.Content += $"Тренерский стаж  {trainer.Expirience} лет{Environment.NewLine}";
                    h9.Content += $"{trainer.History}{Environment.NewLine}";

                    byte[] imageData = trainer.Photo;

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.StreamSource = stream;
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.EndInit();

                            Image photoImage = new Image();
                            photoImage.Source = image;

                            // Ваш элемент управления для отображения изображения, например, Image
                            photo9.Content = photoImage;
                        }
                    }
                }
            }
        }

        private void proba10(object sender, MouseButtonEventArgs e)
        {
            if (p10.Visibility == Visibility.Hidden)
            {
                p10.Visibility = Visibility.Visible;
            }
            else
            {
                p10.Visibility = Visibility.Hidden;
            }

            using (var context = new SportsDataContext())
            {
                var trainers = from trainer in context.Trainer
                               where trainer.Name == "Александр" && trainer.FirstName == "Белов"
                               select new { trainer.Name, trainer.FirstName, trainer.Spezialist, trainer.Education, trainer.Expirience, trainer.History, trainer.Photo };
                foreach (var trainer in trainers)
                {
                    t10_Name_TextBlock.Text += $" {trainer.Name}  {trainer.FirstName}{Environment.NewLine}";
                    s10.Content += $"{trainer.Spezialist} посещение{Environment.NewLine}";
                    e10.Content += $"{trainer.Education}{Environment.NewLine}";
                    st10.Content += $"Тренерский стаж  {trainer.Expirience} года{Environment.NewLine}";
                    h10.Content += $"{trainer.History}{Environment.NewLine}";

                    byte[] imageData = trainer.Photo;

                    if (imageData != null && imageData.Length > 0)
                    {
                        using (MemoryStream stream = new MemoryStream(imageData))
                        {
                            BitmapImage image = new BitmapImage();
                            image.BeginInit();
                            image.StreamSource = stream;
                            image.CacheOption = BitmapCacheOption.OnLoad;
                            image.EndInit();

                            Image photoImage = new Image();
                            photoImage.Source = image;

                            // Ваш элемент управления для отображения изображения, например, Image
                            photo10.Content = photoImage;
                        }
                    }
                }
            }
        }



    }
}

