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

        public string[] getNoteToComboBox(string column, string contractor)
        {
            LinkedList<string> res = new LinkedList<string>();
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select {0} from {1}", column, contractor);
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
        public void selectContract(DataGridView dataGridViewContract)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select k.name_contr, c.id_contract, c.date_contr, c.goal From Contract c join Contractor k "+
                    "on c.id_contractor = k.id_contractor");
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dataGridViewContract.Rows.Add();
                        DataGridViewRow row = dataGridViewContract.Rows[c];
                        row.Cells[0].Value = reader.GetString(0);
                        row.Cells[1].Value = reader.GetString(1);
                        row.Cells[2].Value = reader.GetString(2);
                        row.Cells[3].Value = reader.GetString(3);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        public bool addContract(string nameContract, string nameContractor, string date, string goal)
        {
            string sqlCommand;
            try
            {
                sqlCommand = string.Format("Insert into Contract values((select id_contractor from Contractor where name_contr = '{0}'), '{1}', '{2}', '{3}')",
                    nameContractor, nameContract, goal, date);
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
        public bool updateContract (string nameContract, string nameContractor, string date, string goal)
        {
            string sqlCommand;
            try
            {
                sqlCommand = string.Format("Update Contract Set  date_contr = '{0}', goal = '{1}' where id_contractor = "+
                    "(select id_contractor from Contractor where name_contr = '{2}') and id_contract = '{3}'",
                    date, goal, nameContractor, nameContract);

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
        public void deleteContract(string nameContractor, string nameContract)
        {
            string sqlCommand;
            sqlCommand = string.Format("Delete Contract where id_contractor = (select id_contractor from Contractor where name_contr "+
                "= '{0}') and id_contract = '{1}' ", nameContractor, nameContract);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
        public void findContractor(string value, DataGridView dataGridViewContract)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select k.name_contr, c.id_contract, c.date_contr, c.goal From Contract c join Contractor k " +
                    "on c.id_contractor = k.id_contractor where UPPER(REPLACE(name_contr,' ','')) LIKE(UPPER(REPLACE('{0}',' ','')))",  " %" + value.Trim() + "%");
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dataGridViewContract.Rows.Add();
                        DataGridViewRow row = dataGridViewContract.Rows[c];
                        row.Cells[0].Value = reader.GetString(0);
                        row.Cells[1].Value = reader.GetString(1);
                        row.Cells[2].Value = reader.GetString(2);
                        row.Cells[3].Value = reader.GetString(3);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();

            }
        }
        public void selectDelivery(string nameTable, string[] columns, DataGridView dataGridViewContract)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select c.name_contr, r.name_raw, t.name_type_raw, s.name_subtype, d.{1}, st.year_crop, "+
                    "d.{2}, d.{3}, d.{4}, d.{5} From Contractor c join {0} d " +
                    "on c.id_contractor = d.id_contractor join Storage st on st.id_raw = d.id_raw join Raw r on st.id_NameRaw = "+
                    "r.id_NameRaw join Subtype_raw s on s.id_subtype = st.id_subtype join Type_raw t on s.id_type = t.id_type",
                    nameTable, columns[0], columns[1], columns[2], columns[3], columns[4]);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    int c = 0;
                    while (reader.Read())
                    {
                        dataGridViewContract.Rows.Add();
                        DataGridViewRow row = dataGridViewContract.Rows[c];
                        row.Cells[0].Value = reader.GetString(0);
                        row.Cells[1].Value = reader.GetString(1);
                        row.Cells[2].Value = reader.GetInt32(2);
                        row.Cells[3].Value = reader.GetInt32(3);
                        row.Cells[4].Value = reader.GetString(4);
                        row.Cells[5].Value = reader.GetInt32(5);
                        row.Cells[6].Value = reader.GetString(6);
                        row.Cells[7].Value = reader.GetString(7);
                        row.Cells[8].Value = reader.GetString(8);
                        row.Cells[9].Value = reader.GetString(9);
                        c++;
                    }
                }
                reader.Close();
                connection.Close();
            }
        }
        public string[] getTypeToComboBox(string column, string nameTable, string key, string columnParent, string nameTableParent, string value)
        {
            LinkedList<string> res = new LinkedList<string>();
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select t.{0} from {1} t join {2} p on t.{3} = p.{3} where {4} = '{5}'", 
                    column, nameTable, nameTableParent, key, columnParent, value);
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
        public string[] getSubtypes(string type, string raw)
        {
            LinkedList<string> res = new LinkedList<string>();
            if (!isSubtypes(type, raw))
                addSubtype(type, raw);
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select c.name_subtype from Subtype_raw c join Type_raw t on t.id_type = c.id_type join Raw r "+
                    "on r.id_NameRaw = t.id_NameRaw where t.name_type_raw = '{0}' and c.name_subtype is not null and r.name_raw = '{1}'", type, raw);
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
        private bool isSubtypes(string type, string raw)
        {
            string sqlCommand = string.Empty;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                sqlCommand = string.Format("Select count(*) From Subtype_raw c join Type_raw  t on c.id_type = t.id_type join Raw r "+
                    "on r.id_NameRaw = t.id_NameRaw where t.name_type_raw  = {0} and r.name_raw = '{1}'", type, raw);
                connection.Open();
                SqlCommand command = new SqlCommand(sqlCommand, connection);
                int count = (Int32)command.ExecuteScalar();
                connection.Close();
                if (count == 0)
                    return false;
                else return true;
            }
        }
        private void addSubtype(string nameType, string raw)
        {
            string sqlCommand;
            sqlCommand = string.Format("Insert into Subtype_raw (id_type) values((select t.id_type from Type_raw t join Raw r "+
                "on r.id_NameRaw = t.id_NameRaw where t.name_type_raw = {0} and r.name_raw = '{1}'))", nameType, raw);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand(sqlCommand, connection);
                cmd.ExecuteNonQuery();
                connection.Close();
            }
        }
    }
}
