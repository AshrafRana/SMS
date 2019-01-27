using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace School_Managment_System
{
    class Adapter
    {
        SqlConnection connection;
        SqlDataAdapter dataAdp;
        SqlDataReader myReader;
        DataTable dt;
        SqlCommand cmd;

        public Adapter()
        {
            connection = Singleton.getConnection();
            dataAdp = new SqlDataAdapter();
            dt = new DataTable();
        }


        /* Insert record by query and get Id of this record*/
        public int insertGetId(SqlCommand _cmd)
        {
            int id;
            try
            {
                connection.Open();
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                id = Convert.ToInt32(cmd.ExecuteScalar());
                connection.Close();
                return id;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return 0;
            }

        }
        /* Insert Record record by query */
        public bool insert(SqlCommand _cmd)
        {
            
            try
            {
                connection.Open();
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");  
                return false;
            }
            
        }
        /* Update record by query */
        public bool Update(SqlCommand _cmd)
        {
            try
            {

                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return false;
            }
        }
        /* delete record by query */
        public bool Delete(SqlCommand _cmd)
        {
            try
            {

                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return false;
            }


        }

        /* select record */
        public bool Select(SqlCommand _cmd)
        {
            try
            {
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                myReader = cmd.ExecuteReader();

                if (myReader.Read())
                {

                    connection.Close();
                    return true;
                }
                else
                {
                    connection.Close();
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return false;

            }


        }
        public int SelectRecordID(SqlCommand _cmd)
        {
            int id = 0;
            try
            {
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                myReader = cmd.ExecuteReader();

                if (myReader.Read())
                {
                    id =Convert.ToInt32(myReader[0].ToString());
                    connection.Close();
                    
                    return id;
                }
                else
                {
                    connection.Close();
                    return 0;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return 0;

            }


        }

        //select column value 
        public string SelectColunmValue(SqlCommand _cmd)
        {
            string colunmValue = "";
            try
            {
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                myReader = cmd.ExecuteReader();

                if (myReader.Read())
                {
                    colunmValue =myReader[0].ToString();
                    connection.Close();

                    return colunmValue;
                }
                else
                {
                    connection.Close();
                    return "error";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return "error";

            }


        }

        public DataTable showDataGridView(SqlCommand _cmd)
        {
            try
            {
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dataAdp.SelectCommand = cmd;
                dataAdp.Fill(dt);
                connection.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;
            }

        }
        public DataTable showDataReports(SqlCommand _cmd)
        {
            try
            {
                DataSet ds = new DataSet();
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                dataAdp.SelectCommand = cmd;
                dataAdp.Fill(ds);
                dt = ds.Tables[0];
                connection.Close();
                return dt;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;
            }

        }
        //public DataTable showDataReports(SqlCommand _cmd)
        //{
        //    try
        //    {
        //        DataSet ds = new DataSet();
        //        cmd = _cmd;
        //        cmd.Connection = connection;
        //        cmd.CommandType = CommandType.StoredProcedure;
        //        connection.Open();
        //        dataAdp.SelectCommand = cmd;
        //        dataAdp.Fill(dt);

        //        connection.Close();
        //        return dt;

        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex + "");
        //        return null;
        //    }

        //}


        public List<string> showCombobox(SqlCommand _cmd)
        {
            List<string> list = new List<string>();
            try
            {
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();

                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {

                    list.Add(myReader[0].ToString());
                    
                }
                connection.Close();
                return list;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;

            }


        }
        public List<string> showDataTextbox(SqlCommand _cmd)
        {
            List<string> list = new List<string>();
            try
            {
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
            
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    for (int i = 0; i < myReader.FieldCount; i++)
                    {
                       
                        list.Add(myReader[i].ToString());
                    }
                   
                }
                connection.Close();
                return list;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;

            }


        }

        public List<string> showFamilyDataTextbox(SqlCommand _cmd)
        {
            List<string> list = new List<string>();
            try
            {
                cmd = _cmd;
                cmd.Connection = connection;
                cmd.CommandType = CommandType.StoredProcedure;
                connection.Open();
                myReader = cmd.ExecuteReader();

                while (myReader.Read())
                {
                    for (int i = 0; i < myReader.FieldCount; i++)
                    {
                        list.Add(myReader[i].ToString());
                    }
                }

                connection.Close();
                return list;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                return null;

            }


        }


        public void query(string q) {

            try
            {
                cmd = new SqlCommand(q, connection);
                connection.Open();
                cmd.ExecuteNonQuery();
                connection.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex + "");
                
            }

        }

    }
}
