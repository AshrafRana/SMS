using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;

namespace School_Managment_System
{
    class Singleton
    {
        private static SqlConnection connection;
        private Singleton()
        { }

        public static SqlConnection getConnection()
        {
            if (connection == null)
            {
                // connection = new SqlConnection("Data Source=DESKTOP-PTH0QEP\\SQLEXPRESS; Initial Catalog=sms;Integrated Security=True");
                connection = new SqlConnection(@"Data Source=.\SQLEXPRESS;AttachDbFilename=D:\Ashraf SMS caster\bottleSMS\sms.mdf;Integrated Security=True;");

                return connection;
            }
            else
            {
                return connection;

            }
        }

    }
}
