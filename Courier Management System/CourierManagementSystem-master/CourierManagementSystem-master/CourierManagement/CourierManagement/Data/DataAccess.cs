using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;

namespace CourierManagement
{
    class DataAccess
    {
        private string ConnectionString { get; set; }

        public DataAccess(string connectionString)
        {
            ConnectionString = connectionString;
        }
        public DataAccess()
        {
          
            ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=H:\Semister Final\8th Semister\OOP2\Project\new one\CourierManagementSystem-master\CourierManagementSystem-master\CourierManagement\CourierManagementSystems.mdf;Integrated Security=True;Connect Timeout=30";
           
        }

        private SqlCommand GetCommand(string sqlQuery)
        {
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sqlQuery, conn);
            return sqlCmd;

        }


        public int Insert<T>(T entity, bool isIDIdentity) where T : BaseEntity
        {
            T t = GetById<T, int>(entity.Id);
            SqlCommand sqlCommand;
            if (t != null)
            {
                sqlCommand = getUpdateQuery<T>(entity);
            }
            else
            {
                sqlCommand = getInsertQuery<T>(entity, isIDIdentity);
            }

            //SqlCommand sqlCommand = GetCommand(sqlQuery);
            sqlCommand.Connection.Open();
            var rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowsAffected;
        }

        private SqlCommand getUpdateQuery<T>(T entity) where T : BaseEntity
        {

            var _column = "";
            var _value = "";
            var sql = "UPDATE  [" + entity.GetType().Name + "] SET ";
            foreach (var prop in entity.GetType().GetProperties())
            {
                if (prop.Name != "Id")
                {
                    _column = string.Format("[{0}]", prop.Name);
                    _value = string.Format("@{0}", prop.Name, prop.GetValue(entity, null));
                    sql += string.Format("{0}={1},", _column, _value);//exception handling
                }
            }
            sql = sql.TrimEnd(',');
            sql += " where Id='" + entity.Id + "'";
            SqlCommand sqlcommand = GetCommand(sql);
            foreach (var prop in entity.GetType().GetProperties())
            {
                sqlcommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(entity, null).ToString());
            }
            return sqlcommand;
        }

        private SqlCommand getInsertQuery<T>(T entity, bool isIDIdentity) where T : BaseEntity
        {
            var columns = "";
            var values = "";
            foreach (var prop in entity.GetType().GetProperties())//exception handling full foreach
            {
                if (prop.Name == "Id" && isIDIdentity)
                {
                    continue;
                }
                else
                {
                    columns += string.Format("[{0}],", prop.Name);
                    values += string.Format("@{0},", prop.Name, prop.GetValue(entity, null));//exception handling
                }
            }
            columns = columns.TrimEnd(',');
            values = values.TrimEnd(',');
            string sql1 = "INSERT INTO [" + entity.GetType().Name + "] (" + columns + ") values(" + values + " )";
            SqlCommand sqlcommand = GetCommand(sql1);
            foreach (var prop in entity.GetType().GetProperties())
            {
                sqlcommand.Parameters.AddWithValue("@" + prop.Name, prop.GetValue(entity, null).ToString());
            }
            return sqlcommand;
        }

        ///
        /// Get Query
        ///

        public List<T> GetList<T>(string whereClause = "") where T : BaseEntity
        {
            DataTable dataTable = Execute(getSelectQuery<T>(whereClause));
            return getEntityListFromDataTable<T>(dataTable);
        }

        public T GetById<T, IdType>(IdType id) where T : BaseEntity
        {
            DataTable dataTable = Execute(getSelectQuery<T>(" where Id='" + id + "';"));
            var t = getEntityListFromDataTable<T>(dataTable).FirstOrDefault<T>();
            return t;
        }


        public DataTable GetData<T>(string whereClause) where T : BaseEntity
        {
            return Execute(getSelectQuery<T>(whereClause));
        }


        private List<T> getEntityListFromDataTable<T>(DataTable dataTable) where T : BaseEntity
        {
            List<T> entities = new List<T>();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                //T t2 = new T();
                T t = (T)Activator.CreateInstance(typeof(T));
                foreach (var prop in t.GetType().GetProperties())
                {
                    var ValType = prop.PropertyType;
                    prop.SetValue(t, System.Convert.ChangeType(dataTable.Rows[i][prop.Name].ToString(), prop.PropertyType));
                }
                entities.Add(t);
            }
            return entities;
        }


        private string getSelectQuery<T>(string whereClause = "") where T : BaseEntity
        {
            string sql1 = "Select ";
            var entity = (T)Activator.CreateInstance(typeof(T));
            foreach (var prop in entity.GetType().GetProperties())
            {
                sql1 += string.Format("[{0}],", prop.Name);
            }

            sql1 = sql1.TrimEnd(',');
            sql1 += " from [" + entity.GetType().Name + "] " + whereClause;
            return sql1;
        }
        // where user name="ab's"
        public DataTable Execute(string sql)
        {
            SqlCommand cmd = GetCommand(sql);
            DataTable dt = Execute(cmd);
            return dt;
        }
        public DataTable Execute(SqlCommand command)
        {
            DataTable dt = new DataTable();
            command.Connection.Open();
            dt.Load(command.ExecuteReader());
            command.Connection.Close();
            return dt;
        }

        public int Delete(string table,string field,string id)
        {
            string sql = $"delete from {table} where {field} = '{id}'";
            SqlCommand sqlCommand = GetCommand(sql);
            sqlCommand.Connection.Open();
            var rowsAffected = sqlCommand.ExecuteNonQuery();
            sqlCommand.Connection.Close();
            return rowsAffected;
        }
    }
}
