using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


namespace School_Managment_System
{
    class BackupRestoreController
    {
        
        Adapter adp;
        SqlCommand cmd;


        public BackupRestoreController()
        {

            adp = new Adapter();
            cmd = new SqlCommand();
        

        }



        /*create backup file data base*/
        public string backupfile(string databaseName,string path ,string date)
        {
            cmd = new SqlCommand("BackupRestoreSp");
            cmd.Parameters.AddWithValue("@Action", "BACKUP");
            cmd.Parameters.AddWithValue("@name", databaseName);
            cmd.Parameters.AddWithValue("@path", path);
            cmd.Parameters.AddWithValue("@BackupDate", date);

            if (adp.insert(cmd))
            {
                return "Backup File Sucessfuly";
            }
            else
            {
                return "Backup File Not Create";
            }
        }

        /*create restore backup file data base*/
        public string restoreBackupfile(string path)
        {
            adp.query("RESTORE DATABASE sms  FROM DISK ='D:\\back\\sms_22-09-2017.BAK'");
            return "ss";
            //cmd = new SqlCommand("BackupRestoreSp");
            //cmd.Parameters.AddWithValue("@Action", "RESTORE");
            //cmd.Parameters.AddWithValue("@path", path);

            //if (adp.Update(cmd))
            //{
            //    return "Backup File Sucessfuly";
            //}
            //else
            //{
            //    return "Backup File Not Create";
            //}
        }
    }
}
