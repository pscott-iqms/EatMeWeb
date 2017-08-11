using Objects;
using Oracle.ManagedDataAccess.Client;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class DAL
    {
        OracleConnection _conn;
        string _connString = "Data Source=(DESCRIPTION="
             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PSCOTT-1)(PORT=1521)))"
             + "(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=EATMETOO)));"
             + "User Id=eatme;Password=eatme;";
        public DAL()
        {
            _conn = new OracleConnection(_connString);
        }

        public User GetUser(string userName,string password)
        {
            User user = new User();
            _conn.Open();

            string sql = string.Format("select id,first_name,last_name from eatme_users where email = '{0}' and password = '{1}' ",userName,password); 
            OracleCommand cmd = new OracleCommand(sql, _conn);
            cmd.CommandType = CommandType.Text;

            OracleDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                
                user.Id = int.Parse(dr["id"].ToString());
                user.FirstName = dr["first_name"].ToString();
                user.LastName = dr["last_name"].ToString();
                
            }
            
            _conn.Close();

            return user;

        }
    }
}
