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
        





        private void Reg_Click(object sender, RoutedEventArgs e)
            {
            DataBase dataBase = new DataBase();

                //Close();

                var login = Login.Text;
                var pass = md5.GetHash(password.Password);
                var name = Name.Text;

               
                
                string querstring = $"insert into User(login, pass, Имя) values ('{login}', '{pass}','{name}')";


                SqlCommand command = new SqlCommand(querstring, dataBase.GetConnection());

                dataBase.OpenConnection();

                  User user = new User
                  {
                         //Name1 = name

                   };
            
            if (command.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Аккаунт зарегестрирован");

                    Input input = new Input(user);
                    this.Hide(); 
                    input.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Не создан");
                }
                dataBase.CloseConnection();


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
