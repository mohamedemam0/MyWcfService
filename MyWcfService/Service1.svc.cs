using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MyWcfService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1: IService1
    {

        string connectionString = ConfigurationManager.ConnectionStrings["EmamDBConnectionString"].ConnectionString.ToString();


        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if(composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if(composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }

        #region IService1 Members

        public string InsertUserDetails(UserDetails userInfo)
        {
            string Message;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            SqlCommand comm = new SqlCommand("INSERT into UsersTable(UserName,Password,Email) VALUES (@UserName,@Password,@Email)", conn);

            comm.Parameters.Add("@UserName", System.Data.SqlDbType.VarChar).Value = userInfo.UserName;
            comm.Parameters.Add("@Password", System.Data.SqlDbType.VarChar).Value = userInfo.Password;
            comm.Parameters.Add("@Email", System.Data.SqlDbType.VarChar).Value = userInfo.Email;

            int result = comm.ExecuteNonQuery();

            if(result == 1)
            {
                Message = userInfo.UserName + "Details Inserted Successfully";
            }
            else
            {
                Message = userInfo.UserName + "Details not Inserted Successfully";
            }

            conn.Close();
            return Message;
        }

        public List<UsersTable> FindUser(string uid)
        {
            DataClasses1DataContext data = new DataClasses1DataContext();
            var res = from r in data.UsersTables
                      where r.Password == uid
                      select r;

            return res.ToList();
        }

        #endregion
    }
}
