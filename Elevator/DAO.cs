using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevator.Model;
using System.Data.SqlClient;
using System.Data;

namespace Elevator
{
    class DAO
    {
        private static DAO instance;
        private string connectionString = @"Data Source=.\SQLEXPRESS; Initial Catalog = D:\НАСТЯ\ДИПЛОМ\ВКРБ Михеева\База данных\AccountOfGrain.MDF; Integrated Security = True";
        private DAO()
        {
        }
        
        public static DAO getInstance()
        {
            if (instance == null)
            {
                instance = new DAO();
            }
            return instance;
        }
        public bool addNote(string nameTable, params FormValue<string, string>[] values)
        {
            string sqlCommand;
            string val = string.Empty;
            string names = string.Empty;
            if (values.Length > 0)
            {
                val += "'" + values[0].getValue() + "'";
                names += values[0].getKey();
            }
            for (int i = 1; i < values.Length; i++)
            {
                val += ", '" + values[i].getValue() + "'";
                names += ", " + values[i].getKey();
            }
            try
            {
                sqlCommand = string.Format("Insert into {0} ({1}) values({2})", nameTable, names, val);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool updateNote(string nameTable, FormValue<string, string> primaryKey, params FormValue<string, string>[] values)
        {
            string sqlCommand;
            string settingString = string.Empty;
            if (values.Length > 0) settingString += values[0].getKey() + "='" + values[0].getValue() + "'";
            for (int i = 1; i < values.Length; i++)
            {
                settingString += ", " + values[i].getKey() + "='" + values[i].getValue() + "'";
            }
            try
            {
                sqlCommand = string.Format("Update {0} Set {1} where {2}='{3}'", nameTable, settingString, primaryKey.getKey(), primaryKey.getValue());

                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void deleteNote(string nameTable, FormValue<string, string> primaryKey)
        {
            string sqlCommand;
            sqlCommand = string.Format("Delete {0} where {1}='{2}'", nameTable, primaryKey.getKey(), primaryKey.getValue());

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }

        public DataTable selectTable(string nameTable, params string[] colums)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                if (colums.Length == 0)
                {
                    sqlCommand = string.Format("Select * From {0}", nameTable);
                }
                else
                {
                    string names = string.Empty;
                    names += colums[0];
                    for (int i = 1; i < colums.Length; i++)
                    {
                        names += ", " + colums[i];
                    }
                    sqlCommand = string.Format("Select {1} From {0}", nameTable, names);
                }
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                connection.Close();
                return table;
            }
        }

        public DataTable findRow(string nameTable, FormValue<string, string> value)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select * From {0} where UPPER(REPLACE({1},' ','')) LIKE(UPPER(REPLACE('{2}',' ','')))", nameTable, value.getKey(),  " %" + value.getValue().Trim() + "%");
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);

                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                connection.Close();
                return table;
            }
        }
        public DataTable selectTableNote(string nameTable, string column, string value)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select * From {0} where {1}='{2}'", nameTable, column, value);                
                connection.Open();
                SqlDataAdapter dataAdapter = new SqlDataAdapter(sqlCommand, connection);
                SqlCommandBuilder builder = new SqlCommandBuilder(dataAdapter);
                DataTable table = new DataTable();
                dataAdapter.Fill(table);
                connection.Close();
                return table;
            }
        }
    }
}
