using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Traktory
{
    class MySQL
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        
        public MySQL()
        {
            Initialize();
        }
        
        private void Initialize()
        {
            server = "localhost";
            database = "traktordb";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }
        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                return false;
            }
        }
        public void Insert(string Markaa)
        {
            string query = "INSERT INTO marki(Marka) VALUES('"+ Markaa +"')";
            
            
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Taka marka już istnieje.");
                }
                this.CloseConnection();
                }
            
        }

        public void Insert(string markaa, int moc, int masa, string model)
        {
            string query;
            List<string>[] list = Select();
            query = "INSERT INTO modele(IdMarki,Moc,Masa,Model) VALUES('" + list[0][list[1].IndexOf(markaa)] + "', "+ "'" + moc + "', " + "'" + masa + "', " + "'" + model + "')";
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                try{
                    cmd.ExecuteNonQuery();
                }
                catch(Exception e)
                {
                    System.Windows.Forms.MessageBox.Show("Taki model już istnieje.");
                }
                this.CloseConnection();
            }
        }

        public List<string>[] Select()
        {
            string query = "SELECT * FROM marki";
            
            List<string>[] list = new List<string>[2];
            list[0] = new List<string>();
            list[1] = new List<string>();
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                MySqlDataReader dataReader = cmd.ExecuteReader();

                
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Id"] + "");
                    list[1].Add(dataReader["Marka"] + "");
                }

                
                dataReader.Close();
                
                this.CloseConnection();
                
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<string>[] Select2()
        {
            string query = "SELECT * FROM modele ORDER BY IdMarki";
            
            List<string>[] list = new List<string>[4];
            list[0] = new List<string>();
            list[1] = new List<string>();
            list[2] = new List<string>();
            list[3] = new List<string>();
            
            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                
                MySqlDataReader dataReader = cmd.ExecuteReader();
                
                while (dataReader.Read())
                {
                    list[0].Add(dataReader["Model"] + "");
                    list[1].Add(dataReader["IdMarki"] + "");
                    list[2].Add(dataReader["Moc"] + "");
                    list[3].Add(dataReader["Masa"] + "");
                }
                
                dataReader.Close();
                
                this.CloseConnection();
                
                return list;
            }
            else
            {
                return list;
            }
        }
        
    }
}
