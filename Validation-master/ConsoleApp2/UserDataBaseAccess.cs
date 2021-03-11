using NHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquipmentQualification
{
    class UserDataBaseAccess
    {
        //public string Field { get; set; }
        private static string adres = "D:/Ingvar/C#/git_exercise/Validation-master/Данные/UsersBase.mdb";
        public static string connectString = $"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={adres};";
        private OleDbConnection myConnection = new OleDbConnection(connectString);
        public void Open(string field)
        {
            myConnection.Open();
            string query = $"SELECT {field} FROM [User]";
            var command = new OleDbCommand(query, myConnection);
            string field1 = command.ExecuteScalar().ToString();
            MessageBox.Show(field1, "Логин");
            myConnection.Close();
            //return field1;
        }

    }
}
