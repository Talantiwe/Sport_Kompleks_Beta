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
using System.Data;
using System.Data.SqlClient;
using System.Xml.Linq;
using static Sport.Trener;
using System.IO;
using System.Data.Entity;

namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для Raspisanie.xaml
    /// </summary>
    public partial class RAspisanie : Window
    {
        public RAspisanie()
        {
            InitializeComponent();
            //AddButton.Click += AddButton_Click;
        }

        private void Zad_MouseDown(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

        /*
        private void Ras1_Click(object sender, RoutedEventArgs e)
        {
            // Получите данные для записи в базу данных из вашего приложения
            string dataToInsert = GetDataToInsert();
            string timeToImsert = GetTimeToInsert();

            // Создайте MessageBox с вопросом пользователю
            MessageBoxResult result = MessageBox.Show("Вы уверены, что хотите добавить данные в базу данных?", "Подтверждение", MessageBoxButton.YesNo, MessageBoxImage.Question);

            // Проверьте, что пользователь выбрал "Да"
            if (result == MessageBoxResult.Yes)
            {
                // Выполните добавление данных в базу данных
                if (InsertDataIntoDatabase(dataToInsert, timeToImsert))
                {
                    MessageBox.Show("Данные успешно добавлены в базу данных.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Произошла ошибка при добавлении данных в базу данных.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
        }

        
        private string GetDataToInsert()
        {
            // Здесь вы можете получить данные, которые вы хотите добавить в базу данных, из элементов вашего WPF-приложения
            // Например:
            // string data = yourTextBox.Text;
            // return data;
            string data = r1.Content.ToString();
            // Верните данные для вставки (замените на свой код)
            return data;
        }

        private string GetTimeToInsert()
        {
            // Здесь получите значение времени из элемента Label t1
            string time = t1.Content.ToString();
            // Верните значение времени
            return time;
        }
        */
      


        public class SportsDataContext : DbContext
        {

            public DbSet<Raspisanie> Raspisanie { get; set; }
            public DbSet<Zapis> Zapis { get; set; }
            

            public SportsDataContext() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=SportKompleks2;Integrated Security=True")
            {

            }
        }
        private void calendarControl_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            DateTime? selectedDate = calendarControl.SelectedDate;

            if (selectedDate.HasValue)
            {
                DateTime selectedDateTime = selectedDate.Value.Date;
                UpdateData(selectedDateTime);
            }
        }

        private void UpdateData(DateTime selectedDate)
        {
            try
            { 
                using (var context = new SportsDataContext())
                {
                    var rasp = from Raspisanie in context.Raspisanie
                               where DbFunctions.TruncateTime(Raspisanie.Data) == selectedDate
                               select new { Raspisanie.Name_Rasp, Raspisanie.Time };

                    // Очищаем текстовые блоки перед обновлением данных
                    name_Rasp_TextBlock.Text = string.Empty;
                    time_Rasp_TextBlock.Text = string.Empty;

                    foreach (var Raspisanie in rasp)
                    {
                        name_Rasp_TextBlock.Text += $"{Raspisanie.Name_Rasp}{Environment.NewLine}";
                        time_Rasp_TextBlock.Text += $"{Convert.ToString(Raspisanie.Time)}{Environment.NewLine}";

                        string nameRasp = Raspisanie.Name_Rasp;
                        Zapis newZapis = new Zapis
                        {
                            Name = nameRasp,
                            // Предполагается, что Time в базе данных имеет тип DateTime, поэтому используем DateTime.Parse для преобразования строки в DateTime
                            // Добавьте другие свойства, если они есть
                        };
                        context.Zapis.Add(newZapis);

                        // Сохраняем изменения в базе данных
                        


                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                // Добавьте этот код для вывода дополнительной информации об ошибке
                if (ex.InnerException != null)
                {
                    MessageBox.Show($"Inner Exception: {ex.InnerException.Message}");
                }
            }

        }
        /*
        private void AddButton_Click(object sender, RoutedEventArgs e)
        {
            // Получите выбранную запись
            string selectedName = name_Rasp_TextBlock.Text;
            string selectedTime = time_Rasp_TextBlock.Text;

            // Проверьте, что выбранная запись не пуста
            if (!string.IsNullOrEmpty(selectedName) && !string.IsNullOrEmpty(selectedTime))
            {
                try
                {
                    using (var context = new SportsDataContext())
                    {
                        if (TimeSpan.TryParse(selectedTime.Time, out TimeSpan timeSpan))
                        {
                            context.Zapis.Add(new Zapis
                            {
                                Name = selectedName.Name,
                                Time = timeSpan
                            });

                            // Сохраняем изменения в базе данных
                            context.SaveChanges();
                        }

                        // Сохраняем изменения в базе данных
                        context.SaveChanges();
                    }

                    MessageBox.Show("Запись успешно добавлена в базу данных.", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            else
            {
                MessageBox.Show("Выберите запись перед добавлением в базу данных.", "Предупреждение", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }*/


    }
}





    

