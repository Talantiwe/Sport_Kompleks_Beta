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
using System.Data.SqlClient;
using System.Data;
using System.Diagnostics.Eventing.Reader;


namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для Admin.xaml
    /// </summary>
    public partial class Admin : Window
    {
        DataBase dataBase = new DataBase();

        

        public Admin()
        {
            InitializeComponent();
        }

        

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            DataBase dataBase = new DataBase();

            var fam = Fam.Text;
            var name = Name.Text;
            var dolg = Dolg.Text;


            string querstring = $"insert into Тренер(Имя, Фамилия, Должность) values('{name}', '{fam}', '{dolg}')";
            SqlCommand command = new SqlCommand(querstring, dataBase.GetConnection());
            dataBase.OpenConnection();
            command.ExecuteNonQuery();

            MessageBox.Show("Добавили тренера");
            dataBase.CloseConnection();

        }
        
      
        
        
        private void Exit_Click(object sender, MouseButtonEventArgs e)
        {
            this.Close();
        }

       

        private void Yd_Click(object sender, RoutedEventArgs e)
        {
            DataBase dataBase = new DataBase();

            var fam = Fam.Text;
            var name = Name.Text;
            var dolg = Dolg.Text;


            string querstring = $"delete Тренер where Имя = '{name}' and Фамилия = '{fam}'and Должность = '{dolg}'";
            SqlCommand command = new SqlCommand(querstring, dataBase.GetConnection());
            dataBase.OpenConnection();
            command.ExecuteNonQuery();

            MessageBox.Show("Удалили тренера");
            dataBase.CloseConnection();
        }

        private void Red_Click(object sender, RoutedEventArgs e)
        {
            if(red.Visibility==Visibility.Hidden)
            {
                red.Visibility = Visibility.Visible;
            }
            else
            {
                red.Visibility = Visibility.Hidden;
            }

        }

        private void Izmenit_Click(object sender, RoutedEventArgs e)
        {
            DataBase dataBase =new DataBase();


            var fam1 = Fam2.Text;
            var dolg1 = Dolg2.Text;


            string update = $"update Тренер set Должность = '{dolg1}' where Фамилия = '{fam1}'";
            SqlCommand command = new SqlCommand(update, dataBase.GetConnection());
            dataBase.OpenConnection();
            command.ExecuteNonQuery();

            MessageBox.Show("Изменили тренера");
            dataBase.CloseConnection();
            

        }

       
    }
}
