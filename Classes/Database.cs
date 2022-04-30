using System.Reflection;
using Microsoft.Data.Sqlite;
using System.Data;

namespace SantoAndre
{
    public class Database
    {
        public long LastID { get; set; }


        public void ObjectCreateTable(Object obj, string tabela = "defaultTable")
        {
            string queryString = string.Empty;
            PropertyInfo[] properties = obj.GetType().GetProperties();


            if (tabela == "defaultTable")
            {
                queryString = $"CREATE TABLE IF NOT EXISTS {obj.GetType().Name}s (" +
                              $"id INT NOT NULL AUTO_INCREMENT, ";
            }
            else
            {
                queryString = $"CREATE TABLE IF NOT EXISTS {tabela} (" +
                              $"id INT NOT NULL AUTO_INCREMENT, ";
            }


            foreach (PropertyInfo prop in properties)
            {
                switch (prop.PropertyType.ToString())
                {
                    case "System.String":
                        string mem = prop.GetValue(obj)?.ToString() ?? " ";
                        if ( mem.Length < 255)
                        {
                            queryString += $"{prop.Name} VARCHAR(255) NOT NULL, ";
                        }
                        else
                        {
                            queryString += $"{prop.Name} TEXT NOT NULL, ";
                        }
                        break;

                    case "System.Int32":
                        queryString += $"{prop.Name} INT NOT NULL, ";
                        break;

                    case "System.Boolean":
                        queryString += $"{prop.Name} BOOLEAN NOT NULL";
                        break;

                    case "System.Decimal":
                        queryString += $"{prop.Name} DECIMAL NOT NULL";
                        break;

                    case "System.DateTime":
                        queryString += $"{prop.Name} DATETIME NOT NULL";
                        break;
                }
            }
            queryString += "PRIMARY KEY (`id`)) "+
                           "ENGINE = MyISAM;";

            NonQuery(queryString);
        }
        public void InsertObject(Object obj, string tabela = "defaultTable")
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            string queryString = string.Empty;

            if (tabela == "defaultTable")
            {
                queryString = $"INSERT INTO `{obj.GetType().Name}s` (";
            }
            else
            {
                queryString = $"INSERT INTO `{tabela}` (";
            }

            foreach (PropertyInfo prop in properties)
            {
                queryString += $"`{prop.Name}`, ";
            }

            queryString += "`id`) VALUES (";

            foreach (PropertyInfo prop in properties)
            {
                queryString += $"'{prop.GetValue(obj)}', ";
            }

            queryString += "DEFAULT);";

            NonQuery(queryString);
        }


        public void UpdateObject(Object obj, int id, string tabela = "defaultTable")
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();

            string queryString = string.Empty;

            if (tabela == "defaultTable")
            {
                queryString = $"UPDATE {obj.GetType().Name}s SET ";
            }
            else
            {
                queryString = $"UPDATE {tabela} SET ";
            }

            foreach (PropertyInfo prop in properties)
            {
                queryString += $"`{prop.Name}` = '{prop.GetValue(obj)}', ";
            }

            queryString = queryString.Remove(queryString.Length - 2);

            queryString += $" WHERE ID = {id}";

            NonQuery(queryString);
        }

        public Object SelectObject(Object obj, string query, string tabela = "defaultTable")
        {
            PropertyInfo[] properties = obj.GetType().GetProperties();
            // string queryString = "SELECT Nome, Telefone, ... FROM {obj.GetType().Name} WHERE";
            DataTable dataTable = Query(query);
            DataRow row = dataTable.Rows[0];
            foreach (PropertyInfo prop in properties)
            {
                prop.SetValue(obj, row[prop.Name]);
            }
            return obj;
        }
            
        public void NonQuery(string queryString)
        {
            using (var connection = new SqliteConnection("Data Source= ../Arquivos/Database.db"))
            {
                try
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = queryString;
                    command.ExecuteNonQuery();
                    command.CommandText = "select last_insert_rowid()";
                    LastID = (int)((Int64)(command.ExecuteScalar() ?? 0) );
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }

        public DataTable Query(string queryString)
        {
            DataTable data = new DataTable();

            using (var connection = new SqliteConnection("Data Source= ../Arquivos/Database.db"))
            {
                try
                {
                    connection.Open();
                    var command = connection.CreateCommand();
                    command.CommandText = queryString;
                    SqliteDataReader dataReader = command.ExecuteReader();
                    data.Load(dataReader);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            
            return data;
        }
    }
}