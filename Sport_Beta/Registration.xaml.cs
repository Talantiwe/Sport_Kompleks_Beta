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
using System.Windows.Shapes;
using System.Data.SqlClient;
using System.Data;
using md5_sql_hash;
using System.Data.Entity;

namespace Sport
{
    /// <summary>
    /// Логика взаимодействия для Registration.xaml
    /// </summary>
    public partial class Registration : Window
    {
        DataBase dataBase = new DataBase();
        public Registration()
        {
            InitializeComponent();
            
        }
        public class SportsDataContextt : DbContext
        {

            public DbSet<User> Users { get; set; }

            public SportsDataContextt() : base("Data Source=DESKTOP-JT2CST3;Initial Catalog=SportKompleks2;Integrated Security=True")
            {

            }

        }





        private void Reg_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                using (SportsDataContextt context = new SportsDataContextt())
                {

                    var login = Login.Text;
                    var pass = md5.GetHash(password.Password);
                    var name = Name.Text;

                    var newUser = new User
                    {
                        login = login,
                        pass = pass,
                        Name = name
                    };
                    context.Users.Add(newUser);

                    context.SaveChanges();
                    MessageBox.Show("Вы успешно зарегестрировались");
                    Input input = new Input();
                    input.Show();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Произошла ошибка: {ex.Message}");
            }
        }

        private Boolean Checkuser()
            {
                var login = Login.Text;
                var pass = md5.GetHash(password.Password);
                var name = Name.Text;


                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();


                string querystring = $"select КодПоситителя, login, pass, Имя from Посититель where login = '{login}' and pass = '{pass}'";


                SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());


                adapter.SelectCommand = command;
                adapter.Fill(table);


                if (table.Rows.Count > 0)
                {
                    MessageBox.Show("Есть  запись");
                    return true;
                }
                else
                {
                    return false;
                }


            }
            private void Exit_Click_MouseDown(object sender, MouseButtonEventArgs e)
            {
                this.Close();
            }


        
    }
}
