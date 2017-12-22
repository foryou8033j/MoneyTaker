using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MoneyTaker
{
    public class DBManager
    {
        private string strConn = "Server="+DBConfig.SERVER+
                ";Database="+DBConfig.DB+
                ";Uid="+DBConfig.ID+
                ";Pwd="+DBConfig.PASSWORD+
                ";Charset=utf8";

        private MySqlConnection conn;

        public DBManager()
        {
            try
            {
                conn = new MySqlConnection(strConn);
                conn.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        /// <summary>
        /// 사용자 이름을 변경시킨다
        /// </summary>
        /// <param name="email"></param>
        /// <param name="name"></param>
        public void UpdateUserName(String email, String name)
        {

            try
            {
                MySqlCommand cmd = new MySqlCommand("UPDATE User SET Name = '" + name + "' WHERE Email = '" + email + "'", conn);
                cmd.ExecuteNonQuery();
            }catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
        }

        /// <summary>
        /// 사용자 최초 데이터를 DB에 삽입한다
        /// </summary>
        /// <param name="email"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool InsertRegisterData(String email, String password)
        {
            if (ExistUserEmail(email))
                return false;
            else
            {
                //패스워드 암호화하여 DB에 전송
                password = new EncryptTool().Encrypt(password);

                MySqlCommand cmd = new MySqlCommand("INSERT INTO User VALUES ('', '"+email+"', '"+ password+"')", conn);
                cmd.ExecuteNonQuery();
                return true;
            }
        }

        /// <summary>
        /// 이메일이 DB 상에 존재하는지 검사한다
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>
        public bool ExistUserEmail(String email)
        {
            foreach (DataRow r in Select("User", "Email = '"+email+"'").Tables[0].Rows)
            {
                if (email.Equals(r["Email"].ToString()))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Select 문을 실행한다
        /// </summary>
        /// <param name="table"></param>
        /// <param name="sqlWord"></param>
        /// <returns></returns>
        public DataSet Select(String table, String sqlWord)
        {
            DataSet dataSet = new DataSet();
            string sql = "SELECT * FROM " + table + " WHERE " + sqlWord;
            MySqlDataAdapter adpt = new MySqlDataAdapter(sql, conn);

            adpt.Fill(dataSet, table);

            return dataSet;
        }
        
    }
}
