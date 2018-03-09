using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Elevator.Model;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

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
            catch (SqlException)           
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
            catch (SqlException)
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
                sqlCommand = string.Format("Select * From {0} where UPPER(REPLACE({1},' ','')) LIKE(UPPER(REPLACE('{2}',' ','')))", nameTable, value.getKey(), " %" + value.getValue().Trim() + "%");
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
        public void addStorage(string nameTable, int storage, int value)
        {
            string sqlCommand;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            for (int i = 1; i <= value; i++)
            {
                sqlCommand = string.Format("Insert into {0} values({1})", nameTable, storage + 1);
                storage++;
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.ExecuteNonQuery();
            }
            connection.Close();
        }
        public Int32 getStorage(string nameTable, string column)
        {
            Int32 max = 0;
            string sqlCommand;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    sqlCommand = string.Format("Select max({1}) from {0}", nameTable, column);
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    max = (Int32)cmd.ExecuteScalar();
                    connection.Close();
                    return max;
                }
            }
            catch (SqlException)
            {
                return 0;
            }
        }
        public void deleteStorage(string nameTable, int storage, int value, string nameStorage)
        {
            string sqlCommand;
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            for (int i = 1; i <= value; i++)
            { 
                sqlCommand = string.Format("Delete {0} where {1}='{2}'", nameTable, nameStorage, storage);
                storage--; 
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.ExecuteNonQuery();              
            }
            connection.Close();
        }
        public void selectImpurityTable(string nameTable, DataGridView dataGridViewImpurityQuality)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select * From {0}", nameTable);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dataGridViewImpurityQuality.Rows.Add();
                        DataGridViewRow row = dataGridViewImpurityQuality.Rows[c];
                        row.Cells[0].Value = reader.GetString(0);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        public bool addImpurity(string nameTable, string value)
        {
            string sqlCommand;
            try
            {
                sqlCommand = string.Format("Insert into {0} values({1})", nameTable, value);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public LinkedList<string> selectNormsTableByRaw(string nameTable, string norm, string nameImp, string nameRaw, DataGridView dataGridViewNorms)
        {
            if (!isClass(nameRaw))
                addClass(nameRaw);
            string sqlCommand = string.Empty;
            LinkedList<string> res = new LinkedList<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select n.{1}, n.{2} from {0} n join Class c " + 
                    "on c.id_class=n.id_class join Raw r on c.id_NameRaw=r.id_NameRaw " +
                    "where r.name_raw = '{3}'", nameTable, nameImp, norm, nameRaw);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dataGridViewNorms.Rows.Add();
                        DataGridViewRow row = dataGridViewNorms.Rows[c];
                        string listElement = reader.GetString(0);
                        res.AddLast(listElement);
                        row.Cells[0].Value = listElement;
                        row.Cells[1].Value = reader.GetString(1);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();
            }
            return res;
        }

        private bool isClass(string raw)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select count(*) From Class c join Raw r on c.id_NameRaw= r.id_NameRaw where " +
                    "r.name_raw = '{0}'", raw);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                int count = (Int32)command.ExecuteScalar();
                connection.Close();
                if (count == 0)
                    return false;
                else return true;
            }
        }

        private void addClass(string nameRaw)
        {
            string sqlCommand;           
            sqlCommand = string.Format("Insert into Class (id_NameRaw) values((select id_NameRaw from Raw where name_raw = '{0}'))", nameRaw);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
               connection.Open();
               SqlCommand cmd = new SqlCommand(sqlCommand, connection);
               cmd.ExecuteNonQuery();
               connection.Close();
            }
        }

        public LinkedList<string> selectNormsTableByClass(string nameTable, string norm, string nameImp, string nameClass, string nameRaw, DataGridView dataGridViewNorms)
        {
            string sqlCommand = string.Empty;
            LinkedList<string> res = new LinkedList<string>();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select n.{1}, n.{2} from {0} n join Class c " +
                    "on c.id_class=n.id_class join Raw r on r.id_NameRaw = c.id_NameRaw where c.number_class = '{3}' and r.name_raw = '{4}'", 
                    nameTable, nameImp, norm, nameClass, nameRaw);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dataGridViewNorms.Rows.Add();
                        DataGridViewRow row = dataGridViewNorms.Rows[c];
                        string listElement = reader.GetString(0);
                        res.AddLast(listElement);
                        row.Cells[0].Value = listElement;
                        row.Cells[1].Value = reader.GetString(1);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();
            }
            return res;
        }

        public string[] getImpurity(string nameTable, string nameImp, LinkedList<string> impurities)
        {
            LinkedList<string> res = new LinkedList<string>();
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string enemyValue = string.Empty;
                string[] enemyArray = impurities.ToArray<string>();
                if (enemyArray.Length > 0) enemyValue += string.Format("where {0} != '{1}'", nameImp, enemyArray[0]);
                for (int i = 1; i < enemyArray.Length; i++)
                {
                    enemyValue += string.Format(" and {0} != '{1}'", nameImp, enemyArray[i]);
                }
                sqlCommand = string.Format("Select * from {0} {1}", nameTable, enemyValue);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        string listElement = reader.GetString(0);
                        res.AddLast(listElement);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();
            }
            return res.ToArray<string>();
        }

        public bool addNorm(string nameTable, string name_imp, string valImp, string norm, string raw, string value, string numberClass)
        {
            string sqlCommand;
            if (numberClass != "")
            {
                try
                {
                    sqlCommand = string.Format("Insert into {0} ({1}, id_class, {2}) values('{3}', " +
                        "(select c.id_class from Class c join Raw r on c.id_NameRaw = r.id_NameRaw where r.name_raw = '{4}' and c.number_class = {6}), '{5}')",
                        nameTable, name_imp, norm, valImp, raw, value, numberClass);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    sqlCommand = string.Format("Insert into {0} ({1}, id_class, {2}) values('{3}', " +
                        "(select c.id_class from Class c join Raw r on c.id_NameRaw = r.id_NameRaw where r.name_raw = '{4}'), '{5}')",
                        nameTable, name_imp, norm, valImp, raw, value);
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public bool changeNorm(string valueImp, string nameTable, string raw, string valueNorm, string nameImp, string nameNorm, string numberClass)
        {
            string sqlCommand;
            if (numberClass != "")
            {
                try
                {
                    sqlCommand = string.Format("Update {0} Set {1} = '{2}' where {3}='{4}' and " +
                        "id_class = (select c.id_class from Class c join Raw r on c.id_NameRaw = r.id_NameRaw where r.name_raw ='{5}' and c.number_class = {6})",
                        nameTable, nameNorm, valueNorm, nameImp, valueImp, raw, numberClass);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
            else
            {
                try
                {
                    sqlCommand = string.Format("Update {0} Set {1} = '{2}' where {3}='{4}' and " +
                        "id_class = (select c.id_class from Class c join Raw r on c.id_NameRaw = r.id_NameRaw where r.name_raw ='{5}')",
                        nameTable, nameNorm, valueNorm, nameImp, valueImp, raw);

                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();
                        SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                        cmd.ExecuteNonQuery();
                        connection.Close();
                    }
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }       
        }
        public void deleteNorm(string nameTable, string nameImp, string valueImp, string raw, string numberClass)
        {
            string sqlCommand;
            if (numberClass != "")
            {
                sqlCommand = string.Format("Delete {0} where {1}='{2}' and id_class = (select c.id_class from Class c join Raw r " +
                "on c.id_NameRaw = r.id_NameRaw where r.name_raw ='{3}'  and c.number_class = {4})",
                nameTable, nameImp, valueImp, raw, numberClass);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }
            else
            {
                sqlCommand = string.Format("Delete {0} where {1}='{2}' and id_class = (select c.id_class from Class c join Raw r " +
                "on c.id_NameRaw = r.id_NameRaw where r.name_raw ='{3}')",
                nameTable, nameImp, valueImp, raw);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                    cmd.ExecuteNonQuery();
                    connection.Close();
                }
            }               
        }

        public string[] getRaw()
        {
            LinkedList<string> res = new LinkedList<string>();
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select name_Raw from Raw");
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        string listElement = reader.GetString(0);
                        res.AddLast(listElement);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();
            }
            return res.ToArray<string>();
        }

        public string[] getClasses(string raw)
        {
            LinkedList<string> res = new LinkedList<string>();
            if (isClass(raw))
            {
                string sqlCommand = string.Empty;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    sqlCommand = string.Format("Select c.number_class from Class c join Raw r on r.id_NameRaw = c.id_NameRaw where " +
                        "name_raw = '{0}' and c.number_class is not null", raw);
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlCommand, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.HasRows)
                    {
                        int c = 0;
                        while (reader.Read())
                        {
                            string listElement = reader.GetInt32(0).ToString();
                            res.AddLast(listElement);
                            c++;
                        }
                    }
                    reader.Close();
                    connection.Close();
                }
                return res.ToArray<string>();
            }
            else return res.ToArray<string>();
        }
    }
}
